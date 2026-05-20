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
using WellTracker.AppForms;

namespace WellTracker
{
    public partial class DailySurveyForm : ParentForm
    {
        public DailySurveyForm()
        {
            InitializeComponent();

            dtpDate.MaxDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;
            numSleep.Value = 7.5m;
            numWaterGlasses.Value = 8;

            CenterTableLayoutPanel();
            this.Shown += (s, e) =>
            {
                var timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
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

        private bool ValidateInput()
        {
            if (numSleep.Value <= 0)
            {
                MessageBox.Show("Время сна должно быть больше 0 часов.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbStress.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите уровень стресса.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SaveSurveyToDatabase()
        {
            if (!ValidateInput()) return;

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // проверка на дубликаты 
                    var checkCmd = new SqlCommand(@"
                        SELECT COUNT(*) FROM [DailySurvey] 
                        WHERE UserID = @userId AND SurveyDate = @date", conn);
                    checkCmd.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);
                    checkCmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);

                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount > 0)
                    {
                        MessageBox.Show("Опрос за эту дату уже заполнен!", "Внимание",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    var insertCmd = new SqlCommand(@"
                        INSERT INTO [DailySurvey] 
                        (UserID, SurveyDate, SleepHours, SleepQuality, StressLevel,
                         WaterGlasses, Headache, FatigueLevel, EnergyLevel)
                        VALUES (@userId, @date, @sleep, @sleepQuality, @stress,
                                 @water, @headache, @fatigue, @energy)", conn);

                    insertCmd.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);
                    insertCmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                    insertCmd.Parameters.AddWithValue("@sleep", numSleep.Value);

                    // текст в цифры 
                    insertCmd.Parameters.AddWithValue("@sleepQuality", cmbSleepQuality.SelectedIndex + 1);
                    insertCmd.Parameters.AddWithValue("@stress", cmbStress.SelectedIndex + 1);
                    insertCmd.Parameters.AddWithValue("@water", numWaterGlasses.Value);
                    insertCmd.Parameters.AddWithValue("@headache", chkHeadache.Checked);
                    insertCmd.Parameters.AddWithValue("@fatigue", cmbFatigueLevel.SelectedIndex + 1);
                    insertCmd.Parameters.AddWithValue("@energy", cmbEnergyLevel.SelectedIndex + 1);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно сохранены!", "Успех",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSurveyToDatabase();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

