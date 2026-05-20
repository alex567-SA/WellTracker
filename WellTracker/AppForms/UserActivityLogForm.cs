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
    public partial class UserActivityLogForm : ParentForm
    {
        private int currentUserId = LoginForm.CurrentUserId;
        private decimal currentUserWeight = 70;

        public UserActivityLogForm()
        {
            InitializeComponent();

 

            this.Shown += (s, e) =>
            {
                var timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    CenterForm();
                };
                timer.Start();
            };

            LoadActivityTypes();
            LoadUserWeight();

            dtpActivityDate.Value = DateTime.Today;
            dtpActivityDate.MaxDate = DateTime.Today;
        }

        private void CenterForm()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.WorkingArea;
            int x = (screenBounds.Width - this.Width) / 2;
            int y = (screenBounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void LoadUserWeight()
        {
            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT WeightKg FROM [User] WHERE UserID = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    currentUserWeight = Convert.ToDecimal(result);
                }
            }
        }

        private void LoadActivityTypes()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT ActivityTypeID, DisplayName FROM ActivityType ORDER BY DisplayName";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbActivityType.DataSource = dt;
                    cmbActivityType.SelectedIndex = 0;
                    cmbActivityType.DisplayMember = "DisplayName";
                    cmbActivityType.ValueMember = "ActivityTypeID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки типов активности: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateCalories()
        {
            if (cmbActivityType.SelectedItem == null || numDuration.Value == 0)
            {
                txtCaloriesBurned.Text = "0";
                return;
            }

            try
            {
                // Получаем MET значение для выбранной активности
                int activityTypeId = Convert.ToInt32(((DataRowView)cmbActivityType.SelectedItem)["ActivityTypeID"]);

                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT MetValue FROM ActivityType WHERE ActivityTypeID = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", activityTypeId);

                    conn.Open();
                    object metValueObj = cmd.ExecuteScalar();

                    if (metValueObj != null)
                    {
                        decimal metValue = Convert.ToDecimal(metValueObj);
                        int duration = Convert.ToInt32(numDuration.Value);

                        decimal calories = duration * (metValue * 3.5m * currentUserWeight) / 200m;

                        txtCaloriesBurned.Text = Math.Round(calories, 0).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка расчёта калорий: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbActivityType.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип активности.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numDuration.Value <= 0)
            {
                MessageBox.Show("Укажите продолжительность активности.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = @"
                        INSERT INTO UserActivityLog 
                        (UserID, ActivityTypeID, DurationMinutes, CaloriesBurned, ActivityDate, Notes)
                        VALUES 
                        (@UserId, @ActivityTypeId, @Duration, @Calories, @Date, @Notes)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", currentUserId);
                    cmd.Parameters.AddWithValue("@ActivityTypeId",
                        ((DataRowView)cmbActivityType.SelectedItem)["ActivityTypeID"]);
                    cmd.Parameters.AddWithValue("@Duration", numDuration.Value);

                    int calories = string.IsNullOrWhiteSpace(txtCaloriesBurned.Text) ? 0 :
                                   Convert.ToInt32(txtCaloriesBurned.Text);
                    cmd.Parameters.AddWithValue("@Calories", calories);

                    cmd.Parameters.AddWithValue("@Date", dtpActivityDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Активность успешно сохранена!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            cmbActivityType.SelectedIndex = 0; 
            numDuration.Value = 30; 
            txtCaloriesBurned.Text = "0";
            txtNotes.Clear();
            dtpActivityDate.Value = DateTime.Today;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbActivityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateCalories();
        }

        private void numDuration_ValueChanged(object sender, EventArgs e)
        {
            CalculateCalories();
        }
    }
}
