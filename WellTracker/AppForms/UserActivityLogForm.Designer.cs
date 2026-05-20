namespace WellTracker.AppForms
{
    partial class UserActivityLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserActivityLogForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblActivityType = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbActivityType = new System.Windows.Forms.ComboBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.txtCaloriesBurned = new System.Windows.Forms.TextBox();
            this.dtpActivityDate = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblActivityType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDuration, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCalories, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbActivityType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numDuration, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCaloriesBurned, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpActivityDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNotes, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNotes, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelButtons, 0, 6);
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 427);
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
            this.lblHeader.Text = "Учёт физической активности";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActivityType
            // 
            this.lblActivityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActivityType.Location = new System.Drawing.Point(0, 50);
            this.lblActivityType.Margin = new System.Windows.Forms.Padding(0);
            this.lblActivityType.Name = "lblActivityType";
            this.lblActivityType.Size = new System.Drawing.Size(240, 40);
            this.lblActivityType.TabIndex = 1;
            this.lblActivityType.Text = "Тип активности: ";
            this.lblActivityType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuration.Location = new System.Drawing.Point(3, 90);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(234, 40);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Длительность (мин):";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalories
            // 
            this.lblCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCalories.Location = new System.Drawing.Point(3, 130);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(234, 40);
            this.lblCalories.TabIndex = 3;
            this.lblCalories.Text = "Сожжено калорий:";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(3, 170);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(234, 40);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Дата:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbActivityType
            // 
            this.cmbActivityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivityType.FormattingEnabled = true;
            this.cmbActivityType.Location = new System.Drawing.Point(243, 53);
            this.cmbActivityType.Name = "cmbActivityType";
            this.cmbActivityType.Size = new System.Drawing.Size(354, 31);
            this.cmbActivityType.TabIndex = 5;
            this.cmbActivityType.SelectedIndexChanged += new System.EventHandler(this.cmbActivityType_SelectedIndexChanged);
            // 
            // numDuration
            // 
            this.numDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDuration.Location = new System.Drawing.Point(243, 93);
            this.numDuration.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(354, 30);
            this.numDuration.TabIndex = 6;
            this.numDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numDuration.ValueChanged += new System.EventHandler(this.numDuration_ValueChanged);
            // 
            // txtCaloriesBurned
            // 
            this.txtCaloriesBurned.BackColor = System.Drawing.Color.White;
            this.txtCaloriesBurned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaloriesBurned.Location = new System.Drawing.Point(243, 133);
            this.txtCaloriesBurned.Name = "txtCaloriesBurned";
            this.txtCaloriesBurned.ReadOnly = true;
            this.txtCaloriesBurned.Size = new System.Drawing.Size(354, 30);
            this.txtCaloriesBurned.TabIndex = 7;
            this.txtCaloriesBurned.Text = "0";
            // 
            // dtpActivityDate
            // 
            this.dtpActivityDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpActivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpActivityDate.Location = new System.Drawing.Point(243, 173);
            this.dtpActivityDate.Name = "dtpActivityDate";
            this.dtpActivityDate.Size = new System.Drawing.Size(354, 30);
            this.dtpActivityDate.TabIndex = 8;
            // 
            // lblNotes
            // 
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotes.Location = new System.Drawing.Point(3, 210);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(234, 150);
            this.lblNotes.TabIndex = 9;
            this.lblNotes.Text = "Заметки:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(243, 213);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(354, 144);
            this.txtNotes.TabIndex = 10;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanelButtons, 2);
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(594, 61);
            this.tableLayoutPanelButtons.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(300, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(291, 55);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(291, 55);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UserActivityLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserActivityLogForm";
            this.Text = "Учёт активности";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblActivityType;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbActivityType;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.TextBox txtCaloriesBurned;
        private System.Windows.Forms.DateTimePicker dtpActivityDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}