namespace WellTracker.AppForms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rpNotifications = new System.Windows.Forms.GroupBox();
            this.chkActivityReminder = new System.Windows.Forms.RadioButton();
            this.chkWaterReminder = new System.Windows.Forms.RadioButton();
            this.grpTheme = new System.Windows.Forms.GroupBox();
            this.rbDark = new System.Windows.Forms.RadioButton();
            this.rbLight = new System.Windows.Forms.RadioButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpUnits = new System.Windows.Forms.GroupBox();
            this.rbImperial = new System.Windows.Forms.RadioButton();
            this.rbMetric = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.rpNotifications.SuspendLayout();
            this.grpTheme.SuspendLayout();
            this.grpUnits.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rpNotifications, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.grpTheme, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpUnits, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(143, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 234);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rpNotifications
            // 
            this.rpNotifications.Controls.Add(this.chkActivityReminder);
            this.rpNotifications.Controls.Add(this.chkWaterReminder);
            this.rpNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpNotifications.Location = new System.Drawing.Point(3, 133);
            this.rpNotifications.Name = "rpNotifications";
            this.rpNotifications.Size = new System.Drawing.Size(714, 34);
            this.rpNotifications.TabIndex = 2;
            this.rpNotifications.TabStop = false;
            this.rpNotifications.Text = "Напоминания";
            // 
            // chkActivityReminder
            // 
            this.chkActivityReminder.AutoSize = true;
            this.chkActivityReminder.Location = new System.Drawing.Point(399, 0);
            this.chkActivityReminder.Name = "chkActivityReminder";
            this.chkActivityReminder.Size = new System.Drawing.Size(247, 27);
            this.chkActivityReminder.TabIndex = 5;
            this.chkActivityReminder.TabStop = true;
            this.chkActivityReminder.Text = "Напоминать об активности";
            this.chkActivityReminder.UseVisualStyleBackColor = true;
            // 
            // chkWaterReminder
            // 
            this.chkWaterReminder.AutoSize = true;
            this.chkWaterReminder.Location = new System.Drawing.Point(192, 0);
            this.chkWaterReminder.Name = "chkWaterReminder";
            this.chkWaterReminder.Size = new System.Drawing.Size(186, 27);
            this.chkWaterReminder.TabIndex = 4;
            this.chkWaterReminder.TabStop = true;
            this.chkWaterReminder.Text = "Напоминать о воде";
            this.chkWaterReminder.UseVisualStyleBackColor = true;
            // 
            // grpTheme
            // 
            this.grpTheme.Controls.Add(this.rbDark);
            this.grpTheme.Controls.Add(this.rbLight);
            this.grpTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTheme.Location = new System.Drawing.Point(3, 93);
            this.grpTheme.Name = "grpTheme";
            this.grpTheme.Size = new System.Drawing.Size(714, 34);
            this.grpTheme.TabIndex = 2;
            this.grpTheme.TabStop = false;
            this.grpTheme.Text = "Тема оформления";
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Location = new System.Drawing.Point(316, 0);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(89, 27);
            this.rbDark.TabIndex = 3;
            this.rbDark.TabStop = true;
            this.rbDark.Text = "Тёмная";
            this.rbDark.UseVisualStyleBackColor = true;
            this.rbDark.CheckedChanged += new System.EventHandler(this.rbDark_CheckedChanged);
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Location = new System.Drawing.Point(192, 0);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(94, 27);
            this.rbLight.TabIndex = 2;
            this.rbLight.TabStop = true;
            this.rbLight.Text = "Светлая";
            this.rbLight.UseVisualStyleBackColor = true;
            this.rbLight.CheckedChanged += new System.EventHandler(this.rbLight_CheckedChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(714, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Настройки приложения";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpUnits
            // 
            this.grpUnits.Controls.Add(this.rbImperial);
            this.grpUnits.Controls.Add(this.rbMetric);
            this.grpUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUnits.Location = new System.Drawing.Point(3, 53);
            this.grpUnits.Name = "grpUnits";
            this.grpUnits.Size = new System.Drawing.Size(714, 34);
            this.grpUnits.TabIndex = 1;
            this.grpUnits.TabStop = false;
            this.grpUnits.Text = "Единицы измерения";
            // 
            // rbImperial
            // 
            this.rbImperial.AutoSize = true;
            this.rbImperial.Location = new System.Drawing.Point(446, 1);
            this.rbImperial.Name = "rbImperial";
            this.rbImperial.Size = new System.Drawing.Size(249, 27);
            this.rbImperial.TabIndex = 1;
            this.rbImperial.TabStop = true;
            this.rbImperial.Text = "Имперская (фунты, дюймы)";
            this.rbImperial.UseVisualStyleBackColor = true;
            // 
            // rbMetric
            // 
            this.rbMetric.AutoSize = true;
            this.rbMetric.Location = new System.Drawing.Point(192, 0);
            this.rbMetric.Name = "rbMetric";
            this.rbMetric.Size = new System.Drawing.Size(194, 27);
            this.rbMetric.TabIndex = 0;
            this.rbMetric.TabStop = true;
            this.rbMetric.Text = "Метрическая (кг, см)";
            this.rbMetric.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 173);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 58);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(360, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(351, 52);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(351, 52);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MinimumSize = new System.Drawing.Size(1008, 983);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.rpNotifications.ResumeLayout(false);
            this.rpNotifications.PerformLayout();
            this.grpTheme.ResumeLayout(false);
            this.grpTheme.PerformLayout();
            this.grpUnits.ResumeLayout(false);
            this.grpUnits.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox rpNotifications;
        private System.Windows.Forms.GroupBox grpTheme;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpUnits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbImperial;
        private System.Windows.Forms.RadioButton rbMetric;
        private System.Windows.Forms.RadioButton rbDark;
        private System.Windows.Forms.RadioButton rbLight;
        private System.Windows.Forms.RadioButton chkActivityReminder;
        private System.Windows.Forms.RadioButton chkWaterReminder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}