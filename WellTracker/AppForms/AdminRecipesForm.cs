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
    public partial class AdminRecipesForm : ParentForm
    {
        private int currentUserId = LoginForm.CurrentUserId;
        private int selectedRecipeId = 0;
        public AdminRecipesForm()
        {
            InitializeComponent();

            numCalories.Maximum = 5000;
            numProtein.Maximum = 500;
            numFat.Maximum = 500;
            numCarbs.Maximum = 500;

            this.Shown += (s, e) =>
            {
                var timer = new Timer();
                timer.Interval = 100;
                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    timer.Dispose();
                    CenterForm();
                    LoadCategories();
                    LoadRecipes();
                    SetAddMode(); 
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

        private void LoadCategories()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT CategoryID, Description FROM RecipeCategory ORDER BY Description";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "Description";
                    cmbCategory.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}");
            }
        }

        private void LoadRecipes()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = @"
                        SELECT RecipeID, Name, CaloriesPerServing, Protein, Fat, Carbs 
                        FROM Recipe 
                        ORDER BY Name";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewRecipes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки рецептов: {ex.Message}");
            }
        }

        private void SetAddMode()
        {
            selectedRecipeId = 0;
            btnSave.Text = "Добавить рецепт";
            btnDelete.Enabled = false;

            // Очистка полей
            txtName.Text = "";
            numCalories.Value = 0;
            numProtein.Value = 0;
            numFat.Value = 0;
            numCarbs.Value = 0;
            txtIngredients.Text = "";
            txtInstructions.Text = "";

            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
        }

        private void SetEditMode(int recipeId)
        {
            selectedRecipeId = recipeId;
            btnSave.Text = "Сохранить изменения";
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название рецепта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query;
                        SqlCommand cmd;

                        if (selectedRecipeId == 0)
                        {
                            query = @"
                                INSERT INTO Recipe (Name, CategoryID, Description, Ingredients, Instructions, Servings, CaloriesPerServing, Protein, Fat, Carbs, CreatedByUserID, CreatedAt)
                                VALUES (@Name, @CategoryID, @Desc, @Ing, @Instr, 1, @Cal, @Prot, @Fat, @Carb, @UserId, GETDATE())";
                            cmd = new SqlCommand(query, conn, transaction);
                        }
                        else
                        {
                            query = @"
                                UPDATE Recipe 
                                SET Name = @Name, CategoryID = @CategoryID, Description = @Desc, Ingredients = @Ing, Instructions = @Instr, 
                                    CaloriesPerServing = @Cal, Protein = @Prot, Fat = @Fat, Carbs = @Carb
                                WHERE RecipeID = @Id";
                            cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@Id", selectedRecipeId);
                        }

                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Desc", "Описание"); 
                        cmd.Parameters.AddWithValue("@Ing", txtIngredients.Text);
                        cmd.Parameters.AddWithValue("@Instr", txtInstructions.Text);
                        cmd.Parameters.AddWithValue("@Cal", numCalories.Value);
                        cmd.Parameters.AddWithValue("@Prot", numProtein.Value);
                        cmd.Parameters.AddWithValue("@Fat", numFat.Value);
                        cmd.Parameters.AddWithValue("@Carb", numCarbs.Value);
                        cmd.Parameters.AddWithValue("@UserId", currentUserId);

                        cmd.ExecuteNonQuery();
                        transaction.Commit();

                        MessageBox.Show(selectedRecipeId == 0 ? "Рецепт добавлен!" : "Рецепт обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadRecipes(); // Обновить таблицу
                        SetAddMode(); // Вернуться в режим добавления
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRecipeId == 0) return;

            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить этот рецепт?", "Подтверждение",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "DELETE FROM Recipe WHERE RecipeID = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", selectedRecipeId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Рецепт удалён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecipes();
                SetAddMode();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetAddMode();
        }

        private void dataGridViewRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRecipes.Rows[e.RowIndex];

                selectedRecipeId = Convert.ToInt32(row.Cells["RecipeID"].Value);

                // Заполняем поля данными из строки
                txtName.Text = row.Cells["Name"].Value.ToString();
                numCalories.Value = Convert.ToDecimal(row.Cells["CaloriesPerServing"].Value);
                numProtein.Value = Convert.ToDecimal(row.Cells["Protein"].Value);
                numFat.Value = Convert.ToDecimal(row.Cells["Fat"].Value);
                numCarbs.Value = Convert.ToDecimal(row.Cells["Carbs"].Value);

                LoadFullRecipeDetails(selectedRecipeId);

                SetEditMode(selectedRecipeId);
            }
        }

        private void LoadFullRecipeDetails(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT Ingredients, Instructions FROM Recipe WHERE RecipeID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtIngredients.Text = reader["Ingredients"] != DBNull.Value ? reader["Ingredients"].ToString() : "";
                    txtInstructions.Text = reader["Instructions"] != DBNull.Value ? reader["Instructions"].ToString() : "";
                }
            }
        }
    }
}
