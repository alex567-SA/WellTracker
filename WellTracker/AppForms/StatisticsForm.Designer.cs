namespace WellTracker.AppForms
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartStress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartActivity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSleep = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.chartWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartStress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartActivity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartSleep, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPeriod, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartWeight, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 936);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartStress
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStress.ChartAreas.Add(chartArea1);
            this.chartStress.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStress.Legends.Add(legend1);
            this.chartStress.Location = new System.Drawing.Point(498, 306);
            this.chartStress.Name = "chartStress";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Legend = "Legend1";
            series1.Name = "Уровень стресса";
            this.chartStress.Series.Add(series1);
            this.chartStress.Size = new System.Drawing.Size(488, 626);
            this.chartStress.TabIndex = 5;
            this.chartStress.Text = "chart4";
            // 
            // chartActivity
            // 
            chartArea2.Name = "ChartArea1";
            this.chartActivity.ChartAreas.Add(chartArea2);
            this.chartActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartActivity.Legends.Add(legend2);
            this.chartActivity.Location = new System.Drawing.Point(4, 306);
            this.chartActivity.Name = "chartActivity";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "Активность (мин)";
            this.chartActivity.Series.Add(series2);
            this.chartActivity.Size = new System.Drawing.Size(487, 626);
            this.chartActivity.TabIndex = 4;
            this.chartActivity.Text = "chart3";
            // 
            // chartSleep
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSleep.ChartAreas.Add(chartArea3);
            this.chartSleep.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartSleep.Legends.Add(legend3);
            this.chartSleep.Location = new System.Drawing.Point(498, 55);
            this.chartSleep.Name = "chartSleep";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Сон (часы)";
            this.chartSleep.Series.Add(series3);
            this.chartSleep.Size = new System.Drawing.Size(488, 244);
            this.chartSleep.TabIndex = 3;
            this.chartSleep.Text = "Продолжительность сна";
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Location = new System.Drawing.Point(4, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(487, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Статистика прогресса";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "7 дней",
            "30 дней",
            "Всё время"});
            this.cmbPeriod.Location = new System.Drawing.Point(498, 4);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(488, 31);
            this.cmbPeriod.TabIndex = 1;
            // 
            // chartWeight
            // 
            chartArea4.Name = "ChartArea1";
            this.chartWeight.ChartAreas.Add(chartArea4);
            this.chartWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartWeight.Legends.Add(legend4);
            this.chartWeight.Location = new System.Drawing.Point(4, 55);
            this.chartWeight.Name = "chartWeight";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Вес (кг)";
            this.chartWeight.Series.Add(series4);
            this.chartWeight.Size = new System.Drawing.Size(487, 244);
            this.chartWeight.TabIndex = 2;
            this.chartWeight.Text = "Динамика веса";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 936);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MinimumSize = new System.Drawing.Size(1008, 983);
            this.Name = "StatisticsForm";
            this.Text = "Статистика и прогресс";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStress;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActivity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSleep;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeight;
    }
}