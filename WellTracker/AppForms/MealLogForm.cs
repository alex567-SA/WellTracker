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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace WellTracker.AppForms
{
    public partial class MealLogForm : ParentForm
    {
        private class FoodItem
        {
            public int? RecipeId { get; set; }
            public string Name { get; set; }
            public decimal CaloriesPer100g { get; set; }
            public decimal ProteinPer100g { get; set; }
            public decimal FatPer100g { get; set; }
            public decimal CarbsPer100g { get; set; }

            public override string ToString() => Name;
        }
        public MealLogForm()
        {
            InitializeComponent();

            txtCustomFood.Enabled = false;

            cmbFood.DataSource = recipeBindingSource;
            cmbFood.DisplayMember = "Name";
            cmbFood.ValueMember = "RecipeID";

            dtpDate.MaxDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;
            numAmount.Value = 100;

            LoadFoodItems();

            cmbFood.SelectedIndexChanged += cmbFood_SelectedIndexChanged;
            numAmount.ValueChanged += numAmount_ValueChanged;
            txtCustomFood.TextChanged += txtCustomFood_TextChanged;

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

        private void LoadFoodItems()
        {
            try
            {
                cmbFood.DataSource = null;       
                cmbFood.DisplayMember = "";      
                cmbFood.ValueMember = "";        
                cmbFood.Items.Clear();

                // пункт своё блюдо (индекс 0)
                cmbFood.Items.Add(new FoodItem
                {
                    Name = "[Своё блюдо]",
                    RecipeId = null,
                    CaloriesPer100g = 0,
                    ProteinPer100g = 0,
                    FatPer100g = 0,
                    CarbsPer100g = 0
                });

                // рецепты из БД
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    var cmd = new SqlCommand("SELECT RecipeID, Name, CaloriesPerServing, Protein, Fat, Carbs FROM Recipe", conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // безопасное чтение данных 
                            int id = reader.GetInt32(reader.GetOrdinal("RecipeID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            // CaloriesPerServing в БД имеет тип int --> в decimal
                            int caloriesInt = reader.IsDBNull(reader.GetOrdinal("CaloriesPerServing")) ? 0 : reader.GetInt32(reader.GetOrdinal("CaloriesPerServing"));

                            // проверка остальных полей на null
                            decimal protein = reader.IsDBNull(reader.GetOrdinal("Protein")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Protein"));
                            decimal fat = reader.IsDBNull(reader.GetOrdinal("Fat")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Fat"));
                            decimal carbs = reader.IsDBNull(reader.GetOrdinal("Carbs")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Carbs"));

                            cmbFood.Items.Add(new FoodItem
                            {
                                RecipeId = id,
                                Name = name,
                                CaloriesPer100g = caloriesInt, 
                                ProteinPer100g = protein,
                                FatPer100g = fat,
                                CarbsPer100g = carbs
                            });
                        }
                    }
                }

                if (cmbFood.Items.Count > 1)
                {
                    cmbFood.SelectedIndex = 1;
                }
                else
                {
                    cmbFood.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка еды: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFood.SelectedItem is FoodItem selectedItem)
            {
                if (selectedItem.RecipeId.HasValue)
                {
                    // выбран рецепт из БД --> блок ручного ввода
                    txtCustomFood.Enabled = false;
                    txtCustomFood.Text = ""; 

                    UpdateNutritionValues(selectedItem);
                }
                else
                {

                    // своё блюдо --> разрешаем ручной ввод
                    txtCustomFood.Enabled = true;


                    ClearNutritionValues();
                }
            }
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            if (cmbFood.SelectedItem is FoodItem selectedItem && selectedItem.RecipeId.HasValue)
            {
                UpdateNutritionValues(selectedItem);
            }
        }

        private void txtCustomFood_TextChanged(object sender, EventArgs e)
        {
            if (cmbFood.SelectedIndex == 0)
            {
                ClearNutritionValues();
            }
        }

        private void UpdateNutritionValues(FoodItem food)
        {
            decimal amount = numAmount.Value;
            numCalories.Value = Math.Round(food.CaloriesPer100g * amount / 100, 0);
            numProtein.Value = Math.Round(food.ProteinPer100g * amount / 100, 1);
            numFat.Value = Math.Round(food.FatPer100g * amount / 100, 1);
            numCarbs.Value = Math.Round(food.CarbsPer100g * amount / 100, 1);
        }

        private void ClearNutritionValues()
        {
            numCalories.Value = 0;
            numProtein.Value = 0;
            numFat.Value = 0;
            numCarbs.Value = 0;
        }

        private bool ValidateInput()
        {
            if (cmbMealType.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип приёма пищи.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbFood.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите еду или укажите своё блюдо.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbFood.SelectedIndex == 0 && string.IsNullOrWhiteSpace(txtCustomFood.Text))
            {
                MessageBox.Show("Укажите название своего блюда.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Количество должно быть больше 0 грамм.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SaveMealToDatabase()
        {
            if (!ValidateInput()) return;

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    var cmd = new SqlCommand(@"
                        INSERT INTO [UserMealLog] 
                        (UserID, MealTypeID, RecipeID, CustomFoodName, Amount, Calories, Protein, Fat, Carbs, LogDate)
                        VALUES (@userId, @mealTypeId, @recipeId, @customFood, @amount, @calories, @protein, @fat, @carbs, @date)", conn);

                    cmd.Parameters.AddWithValue("@userId", LoginForm.CurrentUserId);
                    cmd.Parameters.AddWithValue("@mealTypeId", cmbMealType.SelectedIndex + 1); // 1=Завтрак, 2=Обед и т.д.
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@amount", numAmount.Value);
                    cmd.Parameters.AddWithValue("@calories", numCalories.Value);
                    cmd.Parameters.AddWithValue("@protein", numProtein.Value);
                    cmd.Parameters.AddWithValue("@fat", numFat.Value);
                    cmd.Parameters.AddWithValue("@carbs", numCarbs.Value);

                    if (cmbFood.SelectedIndex == 0)
                    {
                        // Своё блюдо
                        cmd.Parameters.AddWithValue("@recipeId", DBNull.Value);
                        cmd.Parameters.AddWithValue("@customFood", txtCustomFood.Text.Trim());
                    }
                    else
                    {
                        // Рецепт
                        var selectedItem = (FoodItem)cmbFood.SelectedItem;
                        cmd.Parameters.AddWithValue("@recipeId", selectedItem.RecipeId);
                        cmd.Parameters.AddWithValue("@customFood", DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Приём пищи успешно добавлен!", "Успех",
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
            SaveMealToDatabase();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MealLogForm_Load(object sender, EventArgs e)
        {

        }

        //private void MealLogForm_Load(object sender, EventArgs e)
        //{
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "well_tracker_krutov_aaDataSet.Recipe". При необходимости она может быть перемещена или удалена.
        //    this.recipeTableAdapter.Fill(this.well_tracker_krutov_aaDataSet.Recipe);

        //}
    }
}