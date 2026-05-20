using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WellTracker.AppForms
{
    public partial class TipsForm : ParentForm
    {
        private int currentUserId = LoginForm.CurrentUserId;

        public TipsForm()
        {
            InitializeComponent();

            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.Padding = new Padding(40, 30, 40, 30);

            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is Label lbl)
                {
                    if (!lbl.Name.Contains("Header"))
                    {
                        lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                        lbl.ForeColor = ColorTranslator.FromHtml("#546E7A");
                        lbl.TextAlign = ContentAlignment.MiddleRight;
                    }
                }
            }

            this.Shown += (s, e) =>
            {
                var timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    CenterForm();
                    LoadTips();
                };
                timer.Start();
            };
        }

        private void CenterForm()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.WorkingArea;
            int x = (screenBounds.Width - this.Width) / 2;
            int y = (screenBounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void LoadTips()
        {
            listBoxTips.Items.Clear();
            listBoxTips.Items.Add("🔍 Анализируем ваши данные...");
            listBoxTips.Update();

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // статистика за 7 дней
                    var stats = GetUserStats(conn);

                    // получаем шаблоны советов
                    var tips = GetActiveTips(conn);

                    // проверка условий
                    var matchedTips = new List<string>();

                    foreach (var tip in tips)
                    {
                        if (CheckCondition(tip.ConditionDescription, stats))
                        {
                            matchedTips.Add($"💡 {tip.TipText}");
                        }
                    }

                    // результат
                    listBoxTips.Items.Clear();

                    if (matchedTips.Count == 0)
                    {
                        listBoxTips.Items.Add("✨ Отлично! Вы соблюдаете баланс. Продолжайте в том же духе!");
                        listBoxTips.Items.Add("");
                        listBoxTips.Items.Add("📌 Советы появятся, когда система заметит возможность для улучшения.");
                    }
                    else
                    {
                        listBoxTips.Items.Add($"Найдено советов: {matchedTips.Count}");
                        listBoxTips.Items.Add(new string('─', 40));
                        foreach (var tip in matchedTips)
                        {
                            listBoxTips.Items.Add(tip);
                            listBoxTips.Items.Add(""); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                listBoxTips.Items.Clear();
                listBoxTips.Items.Add($"⚠️ Ошибка загрузки советов: {ex.Message}");
            }
        }

        private UserStats GetUserStats(SqlConnection conn)
        {
            var stats = new UserStats();

            // Текущий вес и цель из профиля
            var cmdUser = new SqlCommand(@"
                SELECT WeightKg, GoalTypeId FROM [User] WHERE UserID = @UserId", conn);
            cmdUser.Parameters.AddWithValue("@UserId", currentUserId);
            using (var reader = cmdUser.ExecuteReader())
            {
                if (reader.Read())
                {
                    stats.CurrentWeight = Convert.ToDecimal(reader["WeightKg"]);
                    stats.GoalTypeId = Convert.ToInt32(reader["GoalTypeId"]);
                }
            }

            // Средний сон и стресс за последние 7 дней
            var cmdSurvey = new SqlCommand(@"
                SELECT 
                    AVG(CAST(SleepHours AS FLOAT)) as AvgSleep,
                    AVG(CAST(StressLevel AS FLOAT)) as AvgStress,
                    SUM(CASE WHEN SleepHours < 6 THEN 1 ELSE 0 END) as LowSleepDays
                FROM DailySurvey 
                WHERE UserID = @UserId 
                AND SurveyDate >= DATEADD(day, -7, GETDATE())", conn);
            cmdSurvey.Parameters.AddWithValue("@UserId", currentUserId);
            using (var reader = cmdSurvey.ExecuteReader())
            {
                if (reader.Read())
                {
                    stats.AvgSleep = reader["AvgSleep"] != DBNull.Value ? Convert.ToDecimal(reader["AvgSleep"]) : 0;
                    stats.AvgStress = reader["AvgStress"] != DBNull.Value ? Convert.ToDecimal(reader["AvgStress"]) : 0;
                    stats.LowSleepDays = reader["LowSleepDays"] != DBNull.Value ? Convert.ToInt32(reader["LowSleepDays"]) : 0;
                }
            }

            // Потреблено калорий и белка сегодня
            var cmdMeal = new SqlCommand(@"
                SELECT 
                    ISNULL(SUM(Calories), 0) as TotalCalories,
                    ISNULL(SUM(Protein), 0) as TotalProtein
                FROM UserMealLog 
                WHERE UserID = @UserId 
                AND LogDate = CAST(GETDATE() AS DATE)", conn);
            cmdMeal.Parameters.AddWithValue("@UserId", currentUserId);
            stats.ConsumedCalories = Convert.ToInt32(cmdMeal.ExecuteScalar());

            cmdMeal.Parameters.Clear();
            cmdMeal.CommandText = @"
                SELECT ISNULL(SUM(Protein), 0) FROM UserMealLog 
                WHERE UserID = @UserId AND LogDate = CAST(GETDATE() AS DATE)";
            cmdMeal.Parameters.AddWithValue("@UserId", currentUserId);
            stats.ConsumedProtein = Convert.ToDecimal(cmdMeal.ExecuteScalar());

            // Активность сегодня (минуты)
            var cmdActivity = new SqlCommand(@"
                SELECT ISNULL(SUM(DurationMinutes), 0) 
                FROM UserActivityLog 
                WHERE UserID = @UserId 
                AND ActivityDate = CAST(GETDATE() AS DATE)", conn);
            cmdActivity.Parameters.AddWithValue("@UserId", currentUserId);
            stats.TodayActivityMinutes = Convert.ToInt32(cmdActivity.ExecuteScalar());

            // Рассчитываем норму калорий (Миффлин-Сан Жеора, упрощённо)
            stats.DailyCalorieNorm = CalculateDailyNorm(stats.CurrentWeight, stats.GoalTypeId);

            return stats;
        }

        private List<TipTemplate> GetActiveTips(SqlConnection conn)
        {
            var tips = new List<TipTemplate>();
            var cmd = new SqlCommand(@"
                SELECT ConditionDescription, TipText, Priority 
                FROM PersonalizedTip 
                WHERE IsActive = 1 
                ORDER BY Priority", conn);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tips.Add(new TipTemplate
                    {
                        ConditionDescription = reader["ConditionDescription"].ToString(),
                        TipText = reader["TipText"].ToString(),
                        Priority = Convert.ToInt32(reader["Priority"])
                    });
                }
            }
            return tips;
        }

        // Проверяем условие и возвращаем true, если совет актуален
        private bool CheckCondition(string condition, UserStats stats)
        {
            if (condition.Contains("SleepHours < 6") && stats.LowSleepDays >= 3)
                return true;

            if (condition.Contains("StressLevel >= 4") && stats.AvgStress >= 4)
                return true;

            if (condition.Contains("ActivityMinutes < 30") && stats.TodayActivityMinutes < 30)
                return true;

            if (condition.Contains("CaloriesConsumed > Norm") && stats.ConsumedCalories > stats.DailyCalorieNorm * 1.2m)
                return true;

            if (condition.Contains("Protein < 0.8 * WeightKg") && stats.ConsumedProtein < 0.8m * stats.CurrentWeight)
                return true;

            if (condition.Contains("WaterIntake"))
                return false;

            return false;
        }

        private decimal CalculateDailyNorm(decimal weight, int goalTypeId)
        {
            // BMR (упрощённо, без роста/возраста)
            decimal bmr = 10 * weight + 150; // Базовая оценка

            // Корректировка по цели
            if (goalTypeId == 1) return bmr * 0.85m; // Похудение
            if (goalTypeId == 3) return bmr * 1.15m; // Набор
            return bmr; // Поддержание
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Классы для хранения данных
        private class UserStats
        {
            public decimal CurrentWeight { get; set; }
            public int GoalTypeId { get; set; }
            public decimal AvgSleep { get; set; }
            public decimal AvgStress { get; set; }
            public int LowSleepDays { get; set; }
            public int ConsumedCalories { get; set; }
            public decimal ConsumedProtein { get; set; }
            public int TodayActivityMinutes { get; set; }
            public decimal DailyCalorieNorm { get; set; }
        }

        private class TipTemplate
        {
            public string ConditionDescription { get; set; }
            public string TipText { get; set; }
            public int Priority { get; set; }
        }
    }
}
