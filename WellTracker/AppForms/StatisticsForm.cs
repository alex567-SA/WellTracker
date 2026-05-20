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
using System.Windows.Forms.DataVisualization.Charting;

namespace WellTracker.AppForms
{
    public partial class StatisticsForm : ParentForm
    {
        private int currentUserId = LoginForm.CurrentUserId;
        private int daysPeriod = 7;
        public StatisticsForm()
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

            InitializeCharts();
            LoadPeriods();


            this.Shown += (s, e) =>
            {
                var timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    CenterForm();

                    StyleChart(chartWeight);
                    StyleChart(chartSleep);
                    StyleChart(chartActivity);
                    StyleChart(chartStress);

                    LoadStatistics();
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

        private void InitializeCharts()
        {
            // общие настройки для всех графиков
            ConfigureChart(chartWeight, "Вес (кг)", SeriesChartType.Line, Color.FromArgb(244, 67, 54));
            ConfigureChart(chartSleep, "Сон (часы)", SeriesChartType.Column, Color.FromArgb(33, 150, 243));
            ConfigureChart(chartActivity, "Активность (мин)", SeriesChartType.Area, Color.FromArgb(76, 175, 80));
            ConfigureChart(chartStress, "Стресс (1-5)", SeriesChartType.SplineArea, Color.FromArgb(255, 152, 0));
        }

        private void ConfigureChart(Chart chart, string title, SeriesChartType type, Color color)
        {
            chart.Series.Clear();
            var series = new Series
            {
                Name = "Data",
                ChartType = type,
                Color = color,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6
            };
            chart.Series.Add(series);

            chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM";
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart.Titles.Clear();
            chart.Titles.Add(title);
            chart.Titles[0].Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
        private void LoadPeriods()
        {
            cmbPeriod.Items.Clear();
            cmbPeriod.Items.AddRange(new object[] { "7 дней", "30 дней", "Всё время" });
            cmbPeriod.SelectedIndex = 0;
            cmbPeriod.SelectedIndexChanged += CmbPeriod_SelectedIndexChanged;
        }

        private void CmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPeriod.SelectedIndex)
            {
                case 0: daysPeriod = 7; break;
                case 1: daysPeriod = 30; break;
                case 2: daysPeriod = 365; break; // Условно "всё время"
            }
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    LoadWeightChart(conn);
                    LoadSleepChart(conn);
                    LoadActivityChart(conn);
                    LoadStressChart(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWeightChart(SqlConnection conn)
        {
            chartWeight.Series["Data"].Points.Clear();

            string query = "SELECT WeightKg FROM [User] WHERE UserID = @UserId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", currentUserId);

            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                decimal currentWeight = Convert.ToDecimal(result);

                chartWeight.Series["Data"].Points.AddXY(DateTime.Today, currentWeight);
            }
            else
            {
                chartWeight.Series["Data"].Points.AddXY(DateTime.Today, 0);
            }
        }

        private void LoadSleepChart(SqlConnection conn)
        {
            chartSleep.Series["Data"].Points.Clear();

            string query = @"
                SELECT SurveyDate, SleepHours 
                FROM DailySurvey 
                WHERE UserID = @UserId 
                AND SurveyDate >= DATEADD(day, -@Days, GETDATE())
                ORDER BY SurveyDate";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", currentUserId);
            cmd.Parameters.AddWithValue("@Days", daysPeriod);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime date = Convert.ToDateTime(reader["SurveyDate"]);
                    decimal sleep = Convert.ToDecimal(reader["SleepHours"]);
                    chartSleep.Series["Data"].Points.AddXY(date, sleep);
                }
            }
        }

        private void LoadActivityChart(SqlConnection conn)
        {
            chartActivity.Series["Data"].Points.Clear();

            string query = @"
                SELECT ActivityDate, SUM(DurationMinutes) as TotalMinutes
                FROM UserActivityLog 
                WHERE UserID = @UserId 
                AND ActivityDate >= DATEADD(day, -@Days, GETDATE())
                GROUP BY ActivityDate
                ORDER BY ActivityDate";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", currentUserId);
            cmd.Parameters.AddWithValue("@Days", daysPeriod);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime date = Convert.ToDateTime(reader["ActivityDate"]);
                    int minutes = Convert.ToInt32(reader["TotalMinutes"]);
                    chartActivity.Series["Data"].Points.AddXY(date, minutes);
                }
            }
        }
        private void LoadStressChart(SqlConnection conn)
        {
            chartStress.Series["Data"].Points.Clear();

            string query = @"
                SELECT SurveyDate, StressLevel 
                FROM DailySurvey 
                WHERE UserID = @UserId 
                AND SurveyDate >= DATEADD(day, -@Days, GETDATE())
                ORDER BY SurveyDate";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", currentUserId);
            cmd.Parameters.AddWithValue("@Days", daysPeriod);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime date = Convert.ToDateTime(reader["SurveyDate"]);
                    int stress = Convert.ToInt32(reader["StressLevel"]);
                    chartStress.Series["Data"].Points.AddXY(date, stress);
                }
            }
        }

        private void StyleChart(Chart chart)
        {
            chart.BackColor = Color.White;
            chart.ChartAreas[0].BackColor = Color.White;
            chart.ChartAreas[0].BorderColor = ColorTranslator.FromHtml("#E0E0E0");
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = ColorTranslator.FromHtml("#78909C");
            chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = ColorTranslator.FromHtml("#78909C");
            chart.ChartAreas[0].AxisX.TitleForeColor = ColorTranslator.FromHtml("#546E7A");
            chart.ChartAreas[0].AxisY.TitleForeColor = ColorTranslator.FromHtml("#546E7A");
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = ColorTranslator.FromHtml("#F5F5F5");
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = ColorTranslator.FromHtml("#F5F5F5");

            chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM";
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }
    }
}
