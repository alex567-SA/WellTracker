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
    public partial class SettingsForm : ParentForm
    {
        private int currentUserId = LoginForm.CurrentUserId;

        public SettingsForm()
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
                    LoadSettings();
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

        private void LoadSettings()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    // В будущем можно создать таблицу UserSettings
                    rbMetric.Checked = true; // По умолчанию метрическая
                    rbLight.Checked = true;  // По умолчанию светлая тема
                    chkWaterReminder.Checked = true;
                    chkActivityReminder.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки настроек: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Применяем тему (если выбрана тёмная)
                    if (rbDark.Checked)
                    {
                        ApplyDarkTheme();
                    }
                    else
                    {
                        ApplyLightTheme();
                    }
                }

                MessageBox.Show("Настройки сохранены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения настроек: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel || ctrl is TableLayoutPanel)
                {
                    ctrl.BackColor = Color.FromArgb(40, 40, 40);
                    ctrl.ForeColor = Color.White;
                }
            }
        }

        private void ApplyLightTheme()
        {
            // Возвращаем светлую тему
            this.BackColor = SystemColors.Control;
            this.ForeColor = Color.FromArgb(244, 67, 54);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Panel || ctrl is TableLayoutPanel)
                {
                    ctrl.BackColor = SystemColors.Control;
                    ctrl.ForeColor = Color.FromArgb(244, 67, 54);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDark.Checked)
            {
                ApplyDarkTheme();
            }
        }

        private void rbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLight.Checked)
            {
                ApplyLightTheme();
            }
        }
    }
}
