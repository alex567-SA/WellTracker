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
using WellTracker.Models;

namespace WellTracker.AppForms
{
    public partial class DashboardForm : ParentForm
    {

        public DashboardForm()
        {
            InitializeComponent();

            this.Activated += DashboardForm_Activated;

            this.Shown += (s, e) =>
            {
                var timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    CenterTableLayoutPanel();
                    LoadUserData();
                };
                timer.Start();
            };
        }

        private void CenterTableLayoutPanel()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.WorkingArea;
            int x = (screenBounds.Width - tableLayoutPanel1.Width) / 2;
            int y = (screenBounds.Height - tableLayoutPanel1.Height) / 2;
            tableLayoutPanel1.Location = new Point(x, y);
        }

        private void LoadUserData()
        {
            if (LoginForm.CurrentUserId == -1)
            {
                MessageBox.Show("Ошибка: пользователь не авторизован!");
                return;
            }

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Имя пользователя
                    var userCmd = new SqlCommand("SELECT FullName FROM [User] WHERE UserID = @userId", conn);
                    userCmd.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);
                    string fullName = (string)userCmd.ExecuteScalar();
                    lblGreeting.Text = $"Здравствуйте, {fullName}!";

                    // Загрузка данных
                    LoadDailySurveyData(conn);
                    LoadCaloriesData(conn);  
                    LoadActivityLogData(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void LoadDailySurveyData(SqlConnection conn)
        {
            var cmd = new SqlCommand(@"
        SELECT TOP 1 SleepHours, StressLevel 
        FROM [DailySurvey] 
        WHERE UserID = @userId AND SurveyDate = CAST(GETDATE() AS DATE)
        ORDER BY SurveyDate DESC", conn);
            cmd.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    lblSleep.Text = $"Сон: {reader["SleepHours"]}ч";
                    lblStress.Text = $"Стресс: {GetStressLevelText((int)reader["StressLevel"])}";
                }
                else
                {
                    lblSleep.Text = "Сон: —";
                    lblStress.Text = "Стресс: —";
                }
            }
        }

        private void LoadMealLogData(SqlConnection conn)
        {
            var cmd = new SqlCommand(@"
        SELECT ISNULL(SUM(Calories), 0) AS TotalCalories
        FROM [UserMealLog]
        WHERE UserID = @userId AND LogDate = CAST(GETDATE() AS DATE)", conn);
            cmd.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);

            object result = cmd.ExecuteScalar();
            int totalCalories = Convert.ToInt32(result);

            lblCalories.Text = totalCalories > 0
                ? $"Калории: {totalCalories}/2500"
                : "Калории: —";
        }

        private void LoadActivityLogData(SqlConnection conn)
        {
            var cmd = new SqlCommand(@"
        SELECT ISNULL(SUM(DurationMinutes), 0) AS TotalMinutes
        FROM [UserActivityLog]
        WHERE UserID = @userId AND ActivityDate = CAST(GETDATE() AS DATE)", conn);
            cmd.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);

            object result = cmd.ExecuteScalar();
            int totalMinutes = Convert.ToInt32(result);
            int estimatedSteps = totalMinutes * 100; // грубая оценка: ~100 шагов в минуту

            lblSteps.Text = estimatedSteps > 0
                ? $"Шаги: {estimatedSteps}/10000"
                : "Шаги: —";
        }

        private string GetStressLevelText(int stressLevel)
        {
            switch (stressLevel)
            {
                case 1: return "Низкий";
                case 2: return "Ниже среднего";
                case 3: return "Средний";
                case 4: return "Выше среднего";
                case 5: return "Высокий";
                default: return "Неизвестно";
            }
        }

        private void btnMealLog_Click(object sender, EventArgs e)
        {
            if (LoginForm.CurrentUserId == -1)
            {
                MessageBox.Show("Ошибка: пользователь не авторизован.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var form = new MealLogForm();
            form.ShowDialog(); 

            LoadUserData();
        }

        private void btnDailySurvey_Click(object sender, EventArgs e)
        {
            var activityForm = new UserActivityLogForm();
            activityForm.ShowDialog();

            LoadUserData();
        }

        private void btnRecipeSelection_Click(object sender, EventArgs e)
        {
            if (LoginForm.CurrentUserId == -1)
            {
                MessageBox.Show("Ошибка: пользователь не авторизован.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var form = new RecipeSelectionForm();
            form.ShowDialog(); 

            LoadUserData();
        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            if (LoginForm.CurrentUserId == -1)
            {
                MessageBox.Show("Ошибка: пользователь не авторизован.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var form = new TipsForm();
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.CurrentUserId = -1; // Сбрасываем сессию
            new LoginForm().Show();
            this.Close();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
            SELECT r.Name, r.CaloriesPerServing 
            FROM UserFavoriteRecipe ufr
            JOIN Recipe r ON ufr.RecipeID = r.RecipeID
            WHERE ufr.UserID = @UserId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", LoginForm.CurrentUserId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listBoxFavorites.DataSource = dt;
                listBoxFavorites.DisplayMember = "Name"; // Показываем название
            }

            if (!IsDailySurveyCompletedForToday(LoginForm.CurrentUserId))
            {
                var surveyForm = new DailySurveyForm();
                surveyForm.ShowDialog();
            }

        }

        private bool IsDailySurveyCompletedForToday(int userId)
        {
            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(*) FROM DailySurvey WHERE UserID = @UserId AND SurveyDate = @Date";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Date", DateTime.Today);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public void LoadFavoriteRecipes()
        {
            try
            {
                listBoxFavorites.DataSource = null;
                listBoxFavorites.Items.Clear();

                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT r.Name 
                FROM UserFavoriteRecipe ufr
                INNER JOIN Recipe r ON ufr.RecipeID = r.RecipeID
                WHERE ufr.UserID = @UserId
                ORDER BY r.Name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", LoginForm.CurrentUserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listBoxFavorites.Items.Add(reader["Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки избранного: {ex.Message}");
            }
        }

        private void LoadCaloriesData(SqlConnection conn)
        {
            try
            {
                var cmdConsumed = new SqlCommand(@"
            SELECT ISNULL(SUM(Calories), 0) AS TotalCalories
            FROM [UserMealLog]
            WHERE UserID = @userId AND LogDate = CAST(GETDATE() AS DATE)", conn);
                cmdConsumed.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);

                int consumedCalories = Convert.ToInt32(cmdConsumed.ExecuteScalar());

                var cmdBurned = new SqlCommand(@"
            SELECT ISNULL(SUM(CaloriesBurned), 0) 
            FROM UserActivityLog 
            WHERE UserID = @userId AND ActivityDate = CAST(GETDATE() AS DATE)", conn);
                cmdBurned.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);

                int burnedCalories = Convert.ToInt32(cmdBurned.ExecuteScalar());

                var cmdUser = new SqlCommand(@"
            SELECT WeightKg, HeightCm, GenderId, BirthDate, GoalTypeId 
            FROM [User] WHERE UserID = @userId", conn);
                cmdUser.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);

                using (var reader = cmdUser.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        decimal weight = Convert.ToDecimal(reader["WeightKg"]);
                        decimal height = Convert.ToDecimal(reader["HeightCm"]);
                        int genderId = Convert.ToInt32(reader["GenderId"]);
                        DateTime birthDate = Convert.ToDateTime(reader["BirthDate"]);
                        int goalTypeId = Convert.ToInt32(reader["GoalTypeId"]);

                        int age = DateTime.Today.Year - birthDate.Year;
                        if (DateTime.Today < birthDate.AddYears(age)) age--;

                        // Формула Миффлина-Сан Жеора
                        decimal bmr = (10 * weight) + (6.25m * height) - (5 * age);
                        bmr += (genderId == 1) ? 5 : -161; // 1 = мужской

                        // Корректировка по цели
                        decimal dailyNorm = bmr;
                        if (goalTypeId == 1) dailyNorm = bmr * 0.85m; // Похудение
                        else if (goalTypeId == 3) dailyNorm = bmr * 1.15m; // Набор массы

                        lblCalories.Text = $"Калории: {consumedCalories}/{Math.Round(dailyNorm, 0)} (сожжено: {burnedCalories})";
                    }
                }
            }
            catch (Exception ex)
            {
                lblCalories.Text = "Калории: —";
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void DashboardForm_Activated(object sender, EventArgs e)
        {
            LoadFavoriteRecipes();
            LoadUserData();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            var editForm = new ProfileEditForm(
        ProfileEditForm.FormMode.EditProfile,
        LoginForm.CurrentUserId
    );
            editForm.ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var statsForm = new StatisticsForm();
            statsForm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}

