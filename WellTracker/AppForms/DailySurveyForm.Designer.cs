namespace WellTracker
{
    partial class DailySurveyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySurveyForm));
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.cmbStress = new System.Windows.Forms.ComboBox();
            this.lblStress = new System.Windows.Forms.Label();
            this.numSleep = new System.Windows.Forms.NumericUpDown();
            this.lblSleep = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSleepQuality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numWaterGlasses = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHeadache = new System.Windows.Forms.CheckBox();
            this.cmbFatigueLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEnergyLevel = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSleep)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterGlasses)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(203, 173);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(294, 34);
            this.txtComment.TabIndex = 8;
            // 
            // lblComment
            // 
            this.lblComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComment.Location = new System.Drawing.Point(3, 170);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(194, 40);
            this.lblComment.TabIndex = 7;
            this.lblComment.Text = "Комментарий:";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbStress
            // 
            this.cmbStress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStress.FormattingEnabled = true;
            this.cmbStress.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.cmbStress.Location = new System.Drawing.Point(203, 133);
            this.cmbStress.Name = "cmbStress";
            this.cmbStress.Size = new System.Drawing.Size(294, 31);
            this.cmbStress.TabIndex = 6;
            // 
            // lblStress
            // 
            this.lblStress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStress.Location = new System.Drawing.Point(3, 130);
            this.lblStress.Name = "lblStress";
            this.lblStress.Size = new System.Drawing.Size(194, 40);
            this.lblStress.TabIndex = 5;
            this.lblStress.Text = "Уровень стресса:";
            this.lblStress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSleep
            // 
            this.numSleep.DecimalPlaces = 1;
            this.numSleep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSleep.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSleep.Location = new System.Drawing.Point(203, 93);
            this.numSleep.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numSleep.Name = "numSleep";
            this.numSleep.Size = new System.Drawing.Size(294, 30);
            this.numSleep.TabIndex = 4;
            // 
            // lblSleep
            // 
            this.lblSleep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSleep.Location = new System.Drawing.Point(3, 90);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(194, 40);
            this.lblSleep.TabIndex = 3;
            this.lblSleep.Text = "Сон (часы):";
            this.lblSleep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(203, 53);
            this.dtpDate.MaxDate = new System.DateTime(2026, 5, 18, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(294, 30);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Value = new System.DateTime(2026, 5, 18, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(3, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(194, 40);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Дата:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSleep, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numSleep, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbStress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblComment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtComment, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbSleepQuality, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.numWaterGlasses, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.chkHeadache, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbFatigueLevel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmbEnergyLevel, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(281, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblHeader, 2);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(494, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Ежедневный опрос";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Качество сна:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSleepQuality
            // 
            this.cmbSleepQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSleepQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSleepQuality.FormattingEnabled = true;
            this.cmbSleepQuality.Items.AddRange(new object[] {
            "Плохое ",
            "Удовлетворительное ",
            "Хорошее",
            "Отличное"});
            this.cmbSleepQuality.Location = new System.Drawing.Point(203, 213);
            this.cmbSleepQuality.Name = "cmbSleepQuality";
            this.cmbSleepQuality.Size = new System.Drawing.Size(294, 31);
            this.cmbSleepQuality.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Стаканы воды:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numWaterGlasses
            // 
            this.numWaterGlasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWaterGlasses.Location = new System.Drawing.Point(203, 253);
            this.numWaterGlasses.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWaterGlasses.Name = "numWaterGlasses";
            this.numWaterGlasses.Size = new System.Drawing.Size(294, 30);
            this.numWaterGlasses.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "Головная боль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Усталость:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkHeadache
            // 
            this.chkHeadache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkHeadache.Location = new System.Drawing.Point(203, 293);
            this.chkHeadache.Name = "chkHeadache";
            this.chkHeadache.Size = new System.Drawing.Size(294, 34);
            this.chkHeadache.TabIndex = 18;
            this.chkHeadache.Text = "Есть";
            this.chkHeadache.UseVisualStyleBackColor = true;
            // 
            // cmbFatigueLevel
            // 
            this.cmbFatigueLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFatigueLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFatigueLevel.FormattingEnabled = true;
            this.cmbFatigueLevel.Items.AddRange(new object[] {
            "Низкая",
            "Ниже средней",
            "Средняя",
            "Выше средней",
            "Высокая"});
            this.cmbFatigueLevel.Location = new System.Drawing.Point(203, 333);
            this.cmbFatigueLevel.Name = "cmbFatigueLevel";
            this.cmbFatigueLevel.Size = new System.Drawing.Size(294, 31);
            this.cmbFatigueLevel.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "Энергия:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEnergyLevel
            // 
            this.cmbEnergyLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEnergyLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnergyLevel.FormattingEnabled = true;
            this.cmbEnergyLevel.Items.AddRange(new object[] {
            "Низкая",
            "Ниже средней",
            "Средняя",
            "Выше средней",
            "Высокая"});
            this.cmbEnergyLevel.Location = new System.Drawing.Point(203, 373);
            this.cmbEnergyLevel.Name = "cmbEnergyLevel";
            this.cmbEnergyLevel.Size = new System.Drawing.Size(294, 31);
            this.cmbEnergyLevel.TabIndex = 21;
            // 
            // btnSave
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(494, 44);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(3, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(494, 47);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DailySurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MinimumSize = new System.Drawing.Size(1008, 983);
            this.Name = "DailySurveyForm";
            this.Text = "Ежедневный опрос";
            ((System.ComponentModel.ISupportInitialize)(this.numSleep)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterGlasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.ComboBox cmbStress;
        private System.Windows.Forms.Label lblStress;
        private System.Windows.Forms.NumericUpDown numSleep;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSleepQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWaterGlasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHeadache;
        private System.Windows.Forms.ComboBox cmbFatigueLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEnergyLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}