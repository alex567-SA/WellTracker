namespace WellTracker.AppForms
{
    partial class RecipeSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeSelectionForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGoal = new System.Windows.Forms.Label();
            this.cmbGoalFilter = new System.Windows.Forms.ComboBox();
            this.dataGridViewRecipes = new System.Windows.Forms.DataGridView();
            this.well_tracker_krutov_aaDataSet = new WellTracker.well_tracker_krutov_aaDataSet();
            this.goalTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goalTypeTableAdapter = new WellTracker.well_tracker_krutov_aaDataSetTableAdapters.GoalTypeTableAdapter();
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeTableAdapter = new WellTracker.well_tracker_krutov_aaDataSetTableAdapters.RecipeTableAdapter();
            this.welltrackerkrutovaaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeCategoryTableAdapter = new WellTracker.well_tracker_krutov_aaDataSetTableAdapters.RecipeCategoryTableAdapter();
            this.RecipeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesPerServingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.well_tracker_krutov_aaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welltrackerkrutovaaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewRecipes, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(121, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSelect, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 543);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 54);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(400, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(391, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Location = new System.Drawing.Point(3, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(391, 48);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Выбрать рецепт";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(794, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Выбор рецептов";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblGoal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbGoalFilter, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblGoal
            // 
            this.lblGoal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoal.Location = new System.Drawing.Point(3, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(391, 34);
            this.lblGoal.TabIndex = 2;
            this.lblGoal.Text = "Категория:";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGoalFilter
            // 
            this.cmbGoalFilter.DataSource = this.recipeCategoryBindingSource;
            this.cmbGoalFilter.DisplayMember = "Description";
            this.cmbGoalFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGoalFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoalFilter.FormattingEnabled = true;
            this.cmbGoalFilter.Location = new System.Drawing.Point(400, 3);
            this.cmbGoalFilter.Name = "cmbGoalFilter";
            this.cmbGoalFilter.Size = new System.Drawing.Size(391, 31);
            this.cmbGoalFilter.TabIndex = 3;
            this.cmbGoalFilter.ValueMember = "CategoryID";
            this.cmbGoalFilter.SelectedIndexChanged += new System.EventHandler(this.cmbGoalFilter_SelectedIndexChanged);
            // 
            // dataGridViewRecipes
            // 
            this.dataGridViewRecipes.AllowUserToAddRows = false;
            this.dataGridViewRecipes.AllowUserToDeleteRows = false;
            this.dataGridViewRecipes.AutoGenerateColumns = false;
            this.dataGridViewRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewRecipes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecipeID,
            this.colName,
            this.descriptionDataGridViewTextBoxColumn,
            this.ingredientsDataGridViewTextBoxColumn,
            this.instructionsDataGridViewTextBoxColumn,
            this.servingsDataGridViewTextBoxColumn,
            this.caloriesPerServingDataGridViewTextBoxColumn,
            this.proteinDataGridViewTextBoxColumn,
            this.fatDataGridViewTextBoxColumn,
            this.carbsDataGridViewTextBoxColumn});
            this.dataGridViewRecipes.DataSource = this.recipeBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecipes.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecipes.Location = new System.Drawing.Point(3, 93);
            this.dataGridViewRecipes.Name = "dataGridViewRecipes";
            this.dataGridViewRecipes.ReadOnly = true;
            this.dataGridViewRecipes.RowHeadersWidth = 51;
            this.dataGridViewRecipes.RowTemplate.Height = 24;
            this.dataGridViewRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecipes.Size = new System.Drawing.Size(794, 444);
            this.dataGridViewRecipes.TabIndex = 2;
            // 
            // well_tracker_krutov_aaDataSet
            // 
            this.well_tracker_krutov_aaDataSet.DataSetName = "well_tracker_krutov_aaDataSet";
            this.well_tracker_krutov_aaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goalTypeBindingSource
            // 
            this.goalTypeBindingSource.DataMember = "GoalType";
            this.goalTypeBindingSource.DataSource = this.well_tracker_krutov_aaDataSet;
            // 
            // goalTypeTableAdapter
            // 
            this.goalTypeTableAdapter.ClearBeforeFill = true;
            // 
            // recipeBindingSource
            // 
            this.recipeBindingSource.DataMember = "Recipe";
            this.recipeBindingSource.DataSource = this.well_tracker_krutov_aaDataSet;
            // 
            // recipeTableAdapter
            // 
            this.recipeTableAdapter.ClearBeforeFill = true;
            // 
            // welltrackerkrutovaaDataSetBindingSource
            // 
            this.welltrackerkrutovaaDataSetBindingSource.DataSource = this.well_tracker_krutov_aaDataSet;
            this.welltrackerkrutovaaDataSetBindingSource.Position = 0;
            // 
            // recipeCategoryBindingSource
            // 
            this.recipeCategoryBindingSource.DataMember = "RecipeCategory";
            this.recipeCategoryBindingSource.DataSource = this.well_tracker_krutov_aaDataSet;
            // 
            // recipeCategoryTableAdapter
            // 
            this.recipeCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // RecipeID
            // 
            this.RecipeID.DataPropertyName = "RecipeID";
            this.RecipeID.HeaderText = "RecipeID";
            this.RecipeID.MinimumWidth = 6;
            this.RecipeID.Name = "RecipeID";
            this.RecipeID.ReadOnly = true;
            this.RecipeID.Visible = false;
            this.RecipeID.Width = 106;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colName.DefaultCellStyle = dataGridViewCellStyle1;
            this.colName.FillWeight = 11.81535F;
            this.colName.HeaderText = "Название";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 115;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 44.55371F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 118;
            // 
            // ingredientsDataGridViewTextBoxColumn
            // 
            this.ingredientsDataGridViewTextBoxColumn.DataPropertyName = "Ingredients";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ingredientsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ingredientsDataGridViewTextBoxColumn.FillWeight = 172.0969F;
            this.ingredientsDataGridViewTextBoxColumn.HeaderText = "Ингредиенты";
            this.ingredientsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientsDataGridViewTextBoxColumn.Name = "ingredientsDataGridViewTextBoxColumn";
            this.ingredientsDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingredientsDataGridViewTextBoxColumn.Width = 145;
            // 
            // instructionsDataGridViewTextBoxColumn
            // 
            this.instructionsDataGridViewTextBoxColumn.DataPropertyName = "Instructions";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructionsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.instructionsDataGridViewTextBoxColumn.FillWeight = 668.9841F;
            this.instructionsDataGridViewTextBoxColumn.HeaderText = "Способ приготовления";
            this.instructionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructionsDataGridViewTextBoxColumn.Name = "instructionsDataGridViewTextBoxColumn";
            this.instructionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.instructionsDataGridViewTextBoxColumn.Width = 203;
            // 
            // servingsDataGridViewTextBoxColumn
            // 
            this.servingsDataGridViewTextBoxColumn.DataPropertyName = "Servings";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servingsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.servingsDataGridViewTextBoxColumn.FillWeight = 0.5100151F;
            this.servingsDataGridViewTextBoxColumn.HeaderText = "Кол-во порций";
            this.servingsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servingsDataGridViewTextBoxColumn.Name = "servingsDataGridViewTextBoxColumn";
            this.servingsDataGridViewTextBoxColumn.ReadOnly = true;
            this.servingsDataGridViewTextBoxColumn.Width = 146;
            // 
            // caloriesPerServingDataGridViewTextBoxColumn
            // 
            this.caloriesPerServingDataGridViewTextBoxColumn.DataPropertyName = "CaloriesPerServing";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.caloriesPerServingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.caloriesPerServingDataGridViewTextBoxColumn.FillWeight = 0.5100151F;
            this.caloriesPerServingDataGridViewTextBoxColumn.HeaderText = "Калорий/порция";
            this.caloriesPerServingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caloriesPerServingDataGridViewTextBoxColumn.Name = "caloriesPerServingDataGridViewTextBoxColumn";
            this.caloriesPerServingDataGridViewTextBoxColumn.ReadOnly = true;
            this.caloriesPerServingDataGridViewTextBoxColumn.Width = 173;
            // 
            // proteinDataGridViewTextBoxColumn
            // 
            this.proteinDataGridViewTextBoxColumn.DataPropertyName = "Protein";
            this.proteinDataGridViewTextBoxColumn.FillWeight = 0.5100151F;
            this.proteinDataGridViewTextBoxColumn.HeaderText = "Белки (г)";
            this.proteinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proteinDataGridViewTextBoxColumn.Name = "proteinDataGridViewTextBoxColumn";
            this.proteinDataGridViewTextBoxColumn.ReadOnly = true;
            this.proteinDataGridViewTextBoxColumn.Width = 99;
            // 
            // fatDataGridViewTextBoxColumn
            // 
            this.fatDataGridViewTextBoxColumn.DataPropertyName = "Fat";
            this.fatDataGridViewTextBoxColumn.FillWeight = 0.5100151F;
            this.fatDataGridViewTextBoxColumn.HeaderText = "Жиры (г)";
            this.fatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fatDataGridViewTextBoxColumn.Name = "fatDataGridViewTextBoxColumn";
            this.fatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carbsDataGridViewTextBoxColumn
            // 
            this.carbsDataGridViewTextBoxColumn.DataPropertyName = "Carbs";
            this.carbsDataGridViewTextBoxColumn.FillWeight = 0.5100151F;
            this.carbsDataGridViewTextBoxColumn.HeaderText = "Углеводы (г)";
            this.carbsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carbsDataGridViewTextBoxColumn.Name = "carbsDataGridViewTextBoxColumn";
            this.carbsDataGridViewTextBoxColumn.ReadOnly = true;
            this.carbsDataGridViewTextBoxColumn.Width = 125;
            // 
            // RecipeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MinimumSize = new System.Drawing.Size(1008, 983);
            this.Name = "RecipeSelectionForm";
            this.Text = "Выбор рецепта";
            this.Load += new System.EventHandler(this.RecipeSelectionForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.well_tracker_krutov_aaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welltrackerkrutovaaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.ComboBox cmbGoalFilter;
        private System.Windows.Forms.DataGridView dataGridViewRecipes;
        private well_tracker_krutov_aaDataSet well_tracker_krutov_aaDataSet;
        private System.Windows.Forms.BindingSource goalTypeBindingSource;
        private well_tracker_krutov_aaDataSetTableAdapters.GoalTypeTableAdapter goalTypeTableAdapter;
        private System.Windows.Forms.BindingSource recipeBindingSource;
        private well_tracker_krutov_aaDataSetTableAdapters.RecipeTableAdapter recipeTableAdapter;
        private System.Windows.Forms.BindingSource welltrackerkrutovaaDataSetBindingSource;
        private System.Windows.Forms.BindingSource recipeCategoryBindingSource;
        private well_tracker_krutov_aaDataSetTableAdapters.RecipeCategoryTableAdapter recipeCategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesPerServingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbsDataGridViewTextBoxColumn;
    }
}