namespace Doctor
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPRTB = new System.Windows.Forms.TextBox();
            this.DateLB = new System.Windows.Forms.ListBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.DateB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AdressTB = new System.Windows.Forms.TextBox();
            this.ECGChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ECGChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPR-nummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dato for måling:";
            // 
            // CPRTB
            // 
            this.CPRTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPRTB.Location = new System.Drawing.Point(216, 39);
            this.CPRTB.Name = "CPRTB";
            this.CPRTB.Size = new System.Drawing.Size(232, 34);
            this.CPRTB.TabIndex = 2;
            // 
            // DateLB
            // 
            this.DateLB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLB.FormattingEnabled = true;
            this.DateLB.ItemHeight = 27;
            this.DateLB.Location = new System.Drawing.Point(216, 114);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(232, 85);
            this.DateLB.TabIndex = 3;
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Green;
            this.SearchB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchB.Location = new System.Drawing.Point(486, 32);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(115, 46);
            this.SearchB.TabIndex = 4;
            this.SearchB.Text = "Søg";
            this.SearchB.UseVisualStyleBackColor = false;
            // 
            // DateB
            // 
            this.DateB.BackColor = System.Drawing.Color.Green;
            this.DateB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DateB.Location = new System.Drawing.Point(486, 130);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(115, 51);
            this.DateB.TabIndex = 5;
            this.DateB.Text = "Vis måling";
            this.DateB.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(690, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Navn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(690, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse:";
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameTB.Location = new System.Drawing.Point(795, 29);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.ReadOnly = true;
            this.NameTB.Size = new System.Drawing.Size(249, 39);
            this.NameTB.TabIndex = 8;
            // 
            // AdressTB
            // 
            this.AdressTB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdressTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdressTB.Location = new System.Drawing.Point(795, 101);
            this.AdressTB.Multiline = true;
            this.AdressTB.Name = "AdressTB";
            this.AdressTB.ReadOnly = true;
            this.AdressTB.Size = new System.Drawing.Size(249, 38);
            this.AdressTB.TabIndex = 9;
            // 
            // ECGChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ECGChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ECGChart.Legends.Add(legend1);
            this.ECGChart.Location = new System.Drawing.Point(69, 260);
            this.ECGChart.Name = "ECGChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Måling 1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Måling 2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Måling 3";
            this.ECGChart.Series.Add(series1);
            this.ECGChart.Series.Add(series2);
            this.ECGChart.Series.Add(series3);
            this.ECGChart.Size = new System.Drawing.Size(955, 300);
            this.ECGChart.TabIndex = 10;
            this.ECGChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1090, 611);
            this.Controls.Add(this.ECGChart);
            this.Controls.Add(this.AdressTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.CPRTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ECGChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CPRTB;
        private System.Windows.Forms.ListBox DateLB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Button DateB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AdressTB;
        private System.Windows.Forms.DataVisualization.Charting.Chart ECGChart;
    }
}

