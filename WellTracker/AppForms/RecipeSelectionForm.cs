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
    public partial class RecipeSelectionForm : ParentForm
    {
        private class GoalTypeItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            public override string ToString() => Name;
        }
        private DataTable recipesTable = new DataTable();
        public RecipeSelectionForm()
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecipes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рецепт из списка.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewRecipes.SelectedRows[0];
            int recipeId = Convert.ToInt32(selectedRow.Cells["RecipeID"].Value);
            string recipeName = selectedRow.Cells["colName"].Value.ToString();

            string connStr = ConfigurationManager.ConnectionStrings["WellTrackerDb"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // проверка на дубликаты в избраном 
                    string checkQuery = "SELECT COUNT(*) FROM UserFavoriteRecipe WHERE UserID = @UserId AND RecipeID = @RecipeId";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserId", LoginForm.CurrentUserId);
                        checkCmd.Parameters.AddWithValue("@RecipeId", recipeId);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Этот рецепт уже есть в ваших избранных.", "Информация",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // добавление в избранное
                    string insertQuery = @"
                INSERT INTO UserFavoriteRecipe (UserID, RecipeID, AddedDate)
                VALUES (@UserId, @RecipeId, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", LoginForm.CurrentUserId);
                        cmd.Parameters.AddWithValue("@RecipeId", recipeId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Рецепт '{recipeName}' добавлен в избранное!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (Form form in Application.OpenForms)
                {
                    if (form is DashboardForm dashboard)
                    {
                        dashboard.LoadFavoriteRecipes(); // Перезагрузить избранное
                        break;
                    }
                }

                // this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecipeSelectionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "well_tracker_krutov_aaDataSet.RecipeCategory". При необходимости она может быть перемещена или удалена.
            this.recipeCategoryTableAdapter.Fill(this.well_tracker_krutov_aaDataSet.RecipeCategory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "well_tracker_krutov_aaDataSet.Recipe". При необходимости она может быть перемещена или удалена.
            this.recipeTableAdapter.Fill(this.well_tracker_krutov_aaDataSet.Recipe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "well_tracker_krutov_aaDataSet.GoalType". При необходимости она может быть перемещена или удалена.
            this.goalTypeTableAdapter.Fill(this.well_tracker_krutov_aaDataSet.GoalType);

        }

        private void cmbGoalFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGoalFilter.SelectedValue != null && cmbGoalFilter.SelectedValue != DBNull.Value)
            {
                int categoryId = (int)cmbGoalFilter.SelectedValue;

                recipeBindingSource.Filter = $"CategoryID = {categoryId}";
            }
            else
            {
                recipeBindingSource.RemoveFilter();
            }
        }
    }
}
