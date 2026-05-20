namespace WellTracker.AppForms
{
    partial class MealLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealLogForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMealType = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblCustomFood = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.well_tracker_krutov_aaDataSet = new WellTracker.well_tracker_krutov_aaDataSet();
            this.txtCustomFood = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numCalories = new System.Windows.Forms.NumericUpDown();
            this.numProtein = new System.Windows.Forms.NumericUpDown();
            this.numFat = new System.Windows.Forms.NumericUpDown();
            this.numCarbs = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.recipeTableAdapter = new WellTracker.well_tracker_krutov_aaDataSetTableAdapters.RecipeTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.well_tracker_krutov_aaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMealType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFood, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomFood, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblAmount, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCalories, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbMealType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFood, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomFood, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numAmount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(189, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblHeader, 2);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(594, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Учёт питания";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(3, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(234, 40);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Дата:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMealType
            // 
            this.lblMealType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealType.Location = new System.Drawing.Point(3, 90);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(234, 40);
            this.lblMealType.TabIndex = 2;
            this.lblMealType.Text = "Тип приёма пищи:";
            this.lblMealType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFood
            // 
            this.lblFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFood.Location = new System.Drawing.Point(3, 130);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(234, 40);
            this.lblFood.TabIndex = 3;
            this.lblFood.Text = "Еда:";
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomFood
            // 
            this.lblCustomFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomFood.Location = new System.Drawing.Point(3, 170);
            this.lblCustomFood.Name = "lblCustomFood";
            this.lblCustomFood.Size = new System.Drawing.Size(234, 40);
            this.lblCustomFood.TabIndex = 4;
            this.lblCustomFood.Text = "Своё блюдо:";
            this.lblCustomFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Location = new System.Drawing.Point(3, 210);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(234, 40);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Количество (г):";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalories
            // 
            this.lblCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCalories.Location = new System.Drawing.Point(3, 250);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(234, 40);
            this.lblCalories.TabIndex = 6;
            this.lblCalories.Text = "Калории/БЖУ:";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(594, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(243, 53);
            this.dtpDate.MaxDate = new System.DateTime(2026, 5, 18, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(354, 30);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.Value = new System.DateTime(2026, 5, 18, 0, 0, 0, 0);
            // 
            // cmbMealType
            // 
            this.cmbMealType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Items.AddRange(new object[] {
            "Завтрак",
            "Обед",
            "Ужин",
            "Перекус"});
            this.cmbMealType.Location = new System.Drawing.Point(243, 93);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(354, 31);
            this.cmbMealType.TabIndex = 10;
            // 
            // cmbFood
            // 
            this.cmbFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(243, 133);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(354, 31);
            this.cmbFood.TabIndex = 11;
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
            // 
            // recipeBindingSource
            // 
            this.recipeBindingSource.DataMember = "Recipe";
            this.recipeBindingSource.DataSource = this.well_tracker_krutov_aaDataSet;
            // 
            // well_tracker_krutov_aaDataSet
            // 
            this.well_tracker_krutov_aaDataSet.DataSetName = "well_tracker_krutov_aaDataSet";
            this.well_tracker_krutov_aaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCustomFood
            // 
            this.txtCustomFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomFood.Location = new System.Drawing.Point(243, 173);
            this.txtCustomFood.Name = "txtCustomFood";
            this.txtCustomFood.Size = new System.Drawing.Size(354, 30);
            this.txtCustomFood.TabIndex = 12;
            this.txtCustomFood.TextChanged += new System.EventHandler(this.txtCustomFood_TextChanged);
            // 
            // numAmount
            // 
            this.numAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numAmount.Location = new System.Drawing.Point(243, 213);
            this.numAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(354, 30);
            this.numAmount.TabIndex = 13;
            this.numAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.numCalories, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numProtein, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numFat, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.numCarbs, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(243, 253);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 34);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // numCalories
            // 
            this.numCalories.DecimalPlaces = 1;
            this.numCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCalories.Location = new System.Drawing.Point(2, 2);
            this.numCalories.Margin = new System.Windows.Forms.Padding(2);
            this.numCalories.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCalories.Name = "numCalories";
            this.numCalories.Size = new System.Drawing.Size(84, 30);
            this.numCalories.TabIndex = 0;
            // 
            // numProtein
            // 
            this.numProtein.DecimalPlaces = 1;
            this.numProtein.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numProtein.Location = new System.Drawing.Point(90, 2);
            this.numProtein.Margin = new System.Windows.Forms.Padding(2);
            this.numProtein.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numProtein.Name = "numProtein";
            this.numProtein.Size = new System.Drawing.Size(84, 30);
            this.numProtein.TabIndex = 1;
            // 
            // numFat
            // 
            this.numFat.DecimalPlaces = 1;
            this.numFat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numFat.Location = new System.Drawing.Point(178, 2);
            this.numFat.Margin = new System.Windows.Forms.Padding(2);
            this.numFat.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numFat.Name = "numFat";
            this.numFat.Size = new System.Drawing.Size(84, 30);
            this.numFat.TabIndex = 2;
            // 
            // numCarbs
            // 
            this.numCarbs.DecimalPlaces = 1;
            this.numCarbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCarbs.Location = new System.Drawing.Point(266, 2);
            this.numCarbs.Margin = new System.Windows.Forms.Padding(2);
            this.numCarbs.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numCarbs.Name = "numCarbs";
            this.numCarbs.Size = new System.Drawing.Size(86, 30);
            this.numCarbs.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(3, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(594, 54);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // recipeTableAdapter
            // 
            this.recipeTableAdapter.ClearBeforeFill = true;
            // 
            // MealLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MinimumSize = new System.Drawing.Size(1008, 983);
            this.Name = "MealLogForm";
            this.Text = "Учёт приёма пищи";
            this.Load += new System.EventHandler(this.MealLogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.well_tracker_krutov_aaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblCustomFood;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.TextBox txtCustomFood;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numCalories;
        private System.Windows.Forms.NumericUpDown numProtein;
        private System.Windows.Forms.NumericUpDown numFat;
        private System.Windows.Forms.NumericUpDown numCarbs;
        private well_tracker_krutov_aaDataSet well_tracker_krutov_aaDataSet;
        private System.Windows.Forms.BindingSource recipeBindingSource;
        private well_tracker_krutov_aaDataSetTableAdapters.RecipeTableAdapter recipeTableAdapter;
    }
}