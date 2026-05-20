using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WellTracker.AppForms;
using WellTracker.Models;

namespace WellTracker.AppForms
{
    public partial class LoginForm : ParentForm
    {
        public static int CurrentUserId = -1;

        public LoginForm()
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

            this.Shown += new EventHandler(LoginForm_Shown);

            tableLayoutPanel1.Size = new Size(400, 300);
            tableLayoutPanel1.AutoSize = false;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            var timer = new Timer();
            timer.Interval = 1;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                timer.Dispose();
                CenterTableLayoutPanel();
            };
            timer.Start();
        }

        private void CenterTableLayoutPanel()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.WorkingArea;

            int x = (screenBounds.Width - tableLayoutPanel1.Width) / 2;
            int y = (screenBounds.Height - tableLayoutPanel1.Height) / 2;

            tableLayoutPanel1.Location = new Point(x, y);
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail1.Text.Trim();
            string password = txtPassword1.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните email и пароль.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;

                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    var cmd = new SqlCommand(@"
                SELECT u.UserRoleId, u.UserId, u.FullName
                FROM [User] u
                WHERE u.Email = @email AND u.PasswordHash = @passwordHash", connection);

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@passwordHash", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        int userRoleId = -1;
                        int userId = -1;

                        if (reader.Read())
                        {
                            userRoleId = (int)reader["UserRoleId"];
                            userId = (int)reader["UserId"];

                            LoginForm.CurrentUserId = userId;

                            reader.Close();

                            if (userRoleId == 1) // Admin
                                new AdminRecipesForm().Show();
                            else
                                new DashboardForm().Show();

                            this.Hide(); // Скрываем форму входа
                        }
                        else
                        {
                            MessageBox.Show("Неверный email или пароль.", "Ошибка авторизации",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных:\n{ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarion1_Click(object sender, EventArgs e)
        {
            new ProfileEditForm().Show();
        }
    }
}
