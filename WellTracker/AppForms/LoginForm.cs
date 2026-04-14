using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WellTracker.AppForms;
using System.Configuration;

namespace WellTracker.AppForms
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {
            new ProfileEditForm().Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();      
            string password = txtPassword.Text;    

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

                    // Для отладки: пароль сравнивается как открытый текст
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@passwordHash", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userRoleId = (int)reader["UserRoleId"];

                            reader.Close();

                            if (userRoleId == 1) // Admin
                                new AdminRecipesForm().Show();
                            else
                                new DashboardForm().Show();

                            this.Hide();
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
    }
}
