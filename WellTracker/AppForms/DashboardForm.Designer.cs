namespace WellTracker.AppForms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblSleep = new System.Windows.Forms.Label();
            this.lblStress = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMealLog = new System.Windows.Forms.Button();
            this.btnDailySurvey = new System.Windows.Forms.Button();
            this.btnRecipeSelection = new System.Windows.Forms.Button();
            this.btnTips = new System.Windows.Forms.Button();
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGreeting, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBoxFavorites, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFavorite, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnStatistics, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 861);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.Location = new System.Drawing.Point(3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(794, 80);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Панель пользователя";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreeting
            // 
            this.lblGreeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreeting.Location = new System.Drawing.Point(3, 80);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(794, 60);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Здравствуйте, [Имя]!";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblCalories, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSteps, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSleep, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStress, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 114);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblCalories
            // 
            this.lblCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCalories.Location = new System.Drawing.Point(3, 0);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(192, 114);
            this.lblCalories.TabIndex = 0;
            this.lblCalories.Text = "Калории: 2100/2500";
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSteps
            // 
            this.lblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSteps.Location = new System.Drawing.Point(201, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(192, 114);
            this.lblSteps.TabIndex = 1;
            this.lblSteps.Text = "Шаги: 4200/10000";
            this.lblSteps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSleep
            // 
            this.lblSleep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSleep.Location = new System.Drawing.Point(399, 0);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(192, 114);
            this.lblSleep.TabIndex = 2;
            this.lblSleep.Text = "Сон: 7ч";
            this.lblSleep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStress
            // 
            this.lblStress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStress.Location = new System.Drawing.Point(597, 0);
            this.lblStress.Name = "lblStress";
            this.lblStress.Size = new System.Drawing.Size(194, 114);
            this.lblStress.TabIndex = 3;
            this.lblStress.Text = "Стресс: Средний";
            this.lblStress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnMealLog, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDailySurvey, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRecipeSelection, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnTips, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 263);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 194);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnMealLog
            // 
            this.btnMealLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMealLog.Location = new System.Drawing.Point(10, 10);
            this.btnMealLog.Margin = new System.Windows.Forms.Padding(10);
            this.btnMealLog.Name = "btnMealLog";
            this.btnMealLog.Size = new System.Drawing.Size(178, 174);
            this.btnMealLog.TabIndex = 0;
            this.btnMealLog.Text = "Учёт питания";
            this.btnMealLog.UseVisualStyleBackColor = true;
            this.btnMealLog.Click += new System.EventHandler(this.btnMealLog_Click);
            // 
            // btnDailySurvey
            // 
            this.btnDailySurvey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDailySurvey.Location = new System.Drawing.Point(208, 10);
            this.btnDailySurvey.Margin = new System.Windows.Forms.Padding(10);
            this.btnDailySurvey.Name = "btnDailySurvey";
            this.btnDailySurvey.Size = new System.Drawing.Size(178, 174);
            this.btnDailySurvey.TabIndex = 1;
            this.btnDailySurvey.Text = "Активность";
            this.btnDailySurvey.UseVisualStyleBackColor = true;
            this.btnDailySurvey.Click += new System.EventHandler(this.btnDailySurvey_Click);
            // 
            // btnRecipeSelection
            // 
            this.btnRecipeSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecipeSelection.Location = new System.Drawing.Point(406, 10);
            this.btnRecipeSelection.Margin = new System.Windows.Forms.Padding(10);
            this.btnRecipeSelection.Name = "btnRecipeSelection";
            this.btnRecipeSelection.Size = new System.Drawing.Size(178, 174);
            this.btnRecipeSelection.TabIndex = 2;
            this.btnRecipeSelection.Text = "Рецепты";
            this.btnRecipeSelection.UseVisualStyleBackColor = true;
            this.btnRecipeSelection.Click += new System.EventHandler(this.btnRecipeSelection_Click);
            // 
            // btnTips
            // 
            this.btnTips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTips.Location = new System.Drawing.Point(604, 10);
            this.btnTips.Margin = new System.Windows.Forms.Padding(10);
            this.btnTips.Name = "btnTips";
            this.btnTips.Size = new System.Drawing.Size(180, 174);
            this.btnTips.TabIndex = 3;
            this.btnTips.Text = "Советы";
            this.btnTips.UseVisualStyleBackColor = true;
            this.btnTips.Click += new System.EventHandler(this.btnTips_Click);
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.ItemHeight = 23;
            this.listBoxFavorites.Location = new System.Drawing.Point(3, 603);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(794, 144);
            this.listBoxFavorites.TabIndex = 5;
            // 
            // lblFavorite
            // 
            this.lblFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFavorite.Location = new System.Drawing.Point(3, 520);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(794, 80);
            this.lblFavorite.TabIndex = 6;
            this.lblFavorite.Text = "Избранные рецепты";
            this.lblFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnLogout, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEditProfile, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 463);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(794, 54);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.Location = new System.Drawing.Point(400, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(391, 48);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditProfile.Location = new System.Drawing.Point(3, 3);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(391, 48);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "Редактировать профиль";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatistics.Location = new System.Drawing.Point(3, 753);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(794, 44);
            this.btnStatistics.TabIndex = 8;
            this.btnStatistics.Text = "Статистика";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Location = new System.Drawing.Point(3, 803);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(794, 55);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MinimumSize = new System.Drawing.Size(1008, 983);
            this.Name = "DashboardForm";
            this.Text = "Панель пользователя";
            this.Activated += new System.EventHandler(this.DashboardForm_Activated);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.Label lblStress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnMealLog;
        private System.Windows.Forms.Button btnDailySurvey;
        private System.Windows.Forms.Button btnRecipeSelection;
        private System.Windows.Forms.Button btnTips;
        private System.Windows.Forms.ListBox listBoxFavorites;
        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnSettings;
    }
}