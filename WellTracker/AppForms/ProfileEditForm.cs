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
    public partial class ProfileEditForm : ParentForm
    {
        // режимы работы формы
        public enum FormMode
        {
            Register,    // регистрация
            EditProfile  // редактирование
        }
        
        private FormMode currentMode;
        private int currentUserId = -1;

        public ProfileEditForm()
        {
            InitializeComponent();

            currentMode = FormMode.Register; // По умолчанию режим регистрации
            InitializeForm();
        }

        public ProfileEditForm(FormMode mode, int userId = -1)
        {
            InitializeComponent();
            currentMode = mode;
            currentUserId = userId;
            InitializeForm();
        }

        public void InitializeForm()
        {
            LoadReferenceData();
            InitializeNumericRanges(); 


            if (currentMode == FormMode.EditProfile)
            {
                this.Text = "Редактирование профиля";
                btnRegistration.Text = "Сохранить изменения";

                // скрыть поля регистрации
                lblEmail.Visible = false;
                txtEmail.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                lblPasswordConfirm.Visible = false;
                txtPasswordConfirm.Visible = false;
                checkBoxShowPassword.Visible = false;

                // загрузка данных текущего пользователя 
                LoadUserData();
            }
            else
            {
                this.Text = "Регистрация";
                btnRegistration.Text = "Зарегистрироваться";
            }

            UpdateFormTexts();

            this.Shown += (s, e) =>
            {
                var timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    CenterTableLayoutPanel();
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
            if (currentUserId <= 0) return;

            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = @"
                        SELECT FullName, BirthDate, GenderID, HeightCm, WeightKg, GoalTypeID 
                        FROM [User] 
                        WHERE UserID = @UserId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", currentUserId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFullName.Text = reader["FullName"].ToString();
                        DTPBirthday.Value = Convert.ToDateTime(reader["BirthDate"]);
                        numUpDownHeight.Value = reader["HeightCm"] != DBNull.Value ? Convert.ToDecimal(reader["HeightCm"]) : 170;
                        numUpDownWeight.Value = reader["WeightKg"] != DBNull.Value ? Convert.ToDecimal(reader["WeightKg"]) : 70;

                        // выбранные значения в cmb
                        if (comboBoxGender.DataSource != null)
                        {
                            var genderId = Convert.ToInt32(reader["GenderID"]);
                            foreach (var item in comboBoxGender.Items)
                            {
                                if (item is Gender g && g.GenderId == genderId)
                                {
                                    comboBoxGender.SelectedItem = item;
                                    break;
                                }
                            }
                        }

                        if (cmbGoal.DataSource != null)
                        {
                            var goalTypeId = reader["GoalTypeID"] != DBNull.Value ? Convert.ToInt32(reader["GoalTypeID"]) : 0;
                            foreach (var item in cmbGoal.Items)
                            {
                                if (item is GoalType gt && gt.GoalTypeId == goalTypeId)
                                {
                                    cmbGoal.SelectedItem = item;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки профиля: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateRegistration()
        {
            if (currentMode == FormMode.EditProfile)
            {
                return ValidateEditProfile();
            }

            // email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email обязателен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!IsValidEmail(txtEmail.Text) && txtEmail.Text != "admin@local")
            {
                MessageBox.Show("Некорректный формат email.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // пароль
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Пароль обязателен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать минимум 6 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // подтверждение пароля
            if (txtPasswordConfirm.Text != txtPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return ValidateCommonFields();
        }

        private bool ValidateEditProfile()
        {
            return ValidateCommonFields();
        }

        private bool ValidateCommonFields()
        {
            // полное имя
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || txtFullName.Text.Length < 2 || txtFullName.Text.Length > 100)
            {
                MessageBox.Show("Имя должно быть от 2 до 100 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // дата рождения (возраст ≥ 14 лет)
            DateTime birthDate = DTPBirthday.Value.Date;
            int age = DateTime.Today.Year - birthDate.Year;
            if (DateTime.Today < birthDate.AddYears(age)) age--;
            if (age < 14)
            {
                MessageBox.Show("Возраст должен быть не менее 14 лет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // пол
            if (comboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите пол.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // рост
            decimal height = numUpDownHeight.Value;
            if (height < 100 || height > 250)
            {
                MessageBox.Show("Рост должен быть от 100 до 250 см.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // вес
            decimal weight = numUpDownWeight.Value;
            if (weight < 30 || weight > 200)
            {
                MessageBox.Show("Вес должен быть от 30 до 200 кг.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // цель
            if (cmbGoal.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите цель.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // уникальность email (только для регистрации)
            if (currentMode == FormMode.Register && !IsEmailUnique(txtEmail.Text))
            {
                MessageBox.Show("Пользователь с таким email уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsEmailUnique(string email)
        {
            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                int count = (int)cmd.ExecuteScalar();
                return count == 0;
            }
        }

        private void SaveUserToDatabase()
        {
            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                if (currentMode == FormMode.Register)
                {
                    // регистрация - insert
                    var cmd = new SqlCommand(@"
                        INSERT INTO [User] 
                        (Email, PasswordHash, FullName, GenderId, BirthDate, HeightCm, WeightKg, GoalTypeId, UserRoleId, CreatedAt)
                        VALUES (@email, @passwordHash, @fullName, @genderId, @birthDate, @height, @weight, @goalTypeId, 2, GETDATE())",
                        conn);

                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@passwordHash", txtPassword.Text); // Для отладки - открытый текст
                    cmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@genderId", ((Gender)comboBoxGender.SelectedItem).GenderId);
                    cmd.Parameters.AddWithValue("@birthDate", DTPBirthday.Value.Date);
                    cmd.Parameters.AddWithValue("@height", numUpDownHeight.Value);
                    cmd.Parameters.AddWithValue("@weight", numUpDownWeight.Value);
                    cmd.Parameters.AddWithValue("@goalTypeId", ((GoalType)cmbGoal.SelectedItem).GoalTypeId);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // редактирование - update
                    var cmd = new SqlCommand(@"
                        UPDATE [User] 
                        SET 
                            FullName = @fullName,
                            GenderId = @genderId,
                            BirthDate = @birthDate,
                            HeightCm = @height,
                            WeightKg = @weight,
                            GoalTypeId = @goalTypeId
                        WHERE UserID = @userId",
                        conn);

                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@genderId", ((Gender)comboBoxGender.SelectedItem).GenderId);
                    cmd.Parameters.AddWithValue("@birthDate", DTPBirthday.Value.Date);
                    cmd.Parameters.AddWithValue("@height", numUpDownHeight.Value);
                    cmd.Parameters.AddWithValue("@weight", numUpDownWeight.Value);
                    cmd.Parameters.AddWithValue("@goalTypeId", ((GoalType)cmbGoal.SelectedItem).GoalTypeId);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public class Gender
        {
            public int GenderId { get; set; }
            public string DisplayName { get; set; }
        }

        public class GoalType
        {
            public int GoalTypeId { get; set; }
            public string Description { get; set; } 
        }

        private void LoadReferenceData()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;

                // пол
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT GenderID AS GenderID, DisplayName FROM Gender", conn);
                    var reader = cmd.ExecuteReader();

                    var genders = new List<Gender>();
                    while (reader.Read())
                    {
                        genders.Add(new Gender
                        {
                            GenderId = (int)reader["GenderID"],
                            DisplayName = reader["DisplayName"].ToString()
                        });
                    }

                    comboBoxGender.DataSource = genders;
                    comboBoxGender.DisplayMember = "DisplayName";
                    comboBoxGender.ValueMember = "GenderID";
                }

                // цели
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT GoalTypeID, Description FROM GoalType", conn);
                    var reader = cmd.ExecuteReader();

                    var goals = new List<GoalType>();
                    while (reader.Read())
                    {
                        goals.Add(new GoalType
                        {
                            GoalTypeId = (int)reader["GoalTypeID"],
                            Description = reader["Description"].ToString()
                        });
                    }

                    cmbGoal.DataSource = goals;
                    cmbGoal.DisplayMember = "Description";
                    cmbGoal.ValueMember = "GoalTypeID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки справочников: {ex.Message}");
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (!ValidateRegistration()) return;

            try
            {
                SaveUserToDatabase();

                if (currentMode == FormMode.Register)
                {
                    MessageBox.Show("Регистрация успешно завершена!\nТеперь вы можете войти в систему.", "Успех",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Профиль успешно обновлён!", "Успех",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Пользователь с таким email уже существует.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных:\n{ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = checkBoxShowPassword.Checked ? '\0' : '*';
            txtPassword.PasswordChar = passwordChar;
            txtPasswordConfirm.PasswordChar = passwordChar;
        }

        private void InitializeNumericRanges()
        {
            numUpDownHeight.Minimum = 50;
            numUpDownHeight.Maximum = 250;
            numUpDownHeight.DecimalPlaces = 2;

            numUpDownWeight.Minimum = 20;
            numUpDownWeight.Maximum = 300;
            numUpDownWeight.DecimalPlaces = 2;
        }

        private void UpdateFormTexts()
        {
            if (currentMode == FormMode.EditProfile)
            {
                this.Text = "Редактирование профиля";
                lblTitle.Text = "Редактирование профиля";
                lblWelcome.Visible = false;
                btnRegistration.Text = "Сохранить изменения";
            }
            else
            {
                this.Text = "Регистрация в WellTracker";
                lblTitle.Text = "Регистрация в WellTracker";
                btnRegistration.Text = "Зарегистрироваться";
            }
        }
    }
}
