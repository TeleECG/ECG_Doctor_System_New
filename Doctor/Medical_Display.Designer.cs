namespace Doctor
{
    partial class Medical_Display
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
            this.ECG1Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ECG2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ECG3Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Puls1 = new System.Windows.Forms.Label();
            this.HRV1 = new System.Windows.Forms.Label();
            this.Puls2 = new System.Windows.Forms.Label();
            this.Hrv2 = new System.Windows.Forms.Label();
            this.Hrv3 = new System.Windows.Forms.Label();
            this.Puls3 = new System.Windows.Forms.Label();
            this.puls1l = new System.Windows.Forms.Label();
            this.hrv1l = new System.Windows.Forms.Label();
            this.hrv2l = new System.Windows.Forms.Label();
            this.puls2l = new System.Windows.Forms.Label();
            this.hrv3l = new System.Windows.Forms.Label();
            this.puls3l = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ECG1Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ECG2Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ECG3Chart)).BeginInit();
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
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
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
            this.DateB.Click += new System.EventHandler(this.DateB_Click);
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
            // ECG1Chart
            // 
            chartArea1.AxisX.MajorGrid.Interval = 0.2D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.OrangeRed;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 0.04D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.OrangeRed;
            chartArea1.Name = "ChartArea1";
            this.ECG1Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ECG1Chart.Legends.Add(legend1);
            this.ECG1Chart.Location = new System.Drawing.Point(64, 230);
            this.ECG1Chart.Name = "ECG1Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Måling 1";
            this.ECG1Chart.Series.Add(series1);
            this.ECG1Chart.Size = new System.Drawing.Size(955, 142);
            this.ECG1Chart.TabIndex = 10;
            this.ECG1Chart.Text = "chart1";
            this.ECG1Chart.Visible = false;
            // 
            // ECG2Chart
            // 
            chartArea2.AxisX.MajorGrid.Interval = 0.2D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.OrangeRed;
            chartArea2.AxisX.MajorGrid.LineWidth = 2;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.Interval = 0.04D;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.OrangeRed;
            chartArea2.Name = "ChartArea1";
            this.ECG2Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ECG2Chart.Legends.Add(legend2);
            this.ECG2Chart.Location = new System.Drawing.Point(64, 378);
            this.ECG2Chart.Name = "ECG2Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Måling 2";
            this.ECG2Chart.Series.Add(series2);
            this.ECG2Chart.Size = new System.Drawing.Size(954, 142);
            this.ECG2Chart.TabIndex = 11;
            this.ECG2Chart.Text = "chart1";
            this.ECG2Chart.Visible = false;
            // 
            // ECG3Chart
            // 
            chartArea3.AxisX.MajorGrid.Interval = 0.2D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.OrangeRed;
            chartArea3.AxisX.MajorGrid.LineWidth = 2;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisX.MinorGrid.Interval = 0.04D;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.OrangeRed;
            chartArea3.Name = "ChartArea1";
            this.ECG3Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ECG3Chart.Legends.Add(legend3);
            this.ECG3Chart.Location = new System.Drawing.Point(64, 526);
            this.ECG3Chart.Name = "ECG3Chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Måling 3";
            this.ECG3Chart.Series.Add(series3);
            this.ECG3Chart.Size = new System.Drawing.Size(954, 142);
            this.ECG3Chart.TabIndex = 12;
            this.ECG3Chart.Text = "chart1";
            this.ECG3Chart.Visible = false;
            // 
            // Puls1
            // 
            this.Puls1.AutoSize = true;
            this.Puls1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puls1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Puls1.Location = new System.Drawing.Point(1055, 230);
            this.Puls1.Name = "Puls1";
            this.Puls1.Size = new System.Drawing.Size(56, 27);
            this.Puls1.TabIndex = 13;
            this.Puls1.Text = "Puls:";
            // 
            // HRV1
            // 
            this.HRV1.AutoSize = true;
            this.HRV1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRV1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HRV1.Location = new System.Drawing.Point(1055, 287);
            this.HRV1.Name = "HRV1";
            this.HRV1.Size = new System.Drawing.Size(56, 27);
            this.HRV1.TabIndex = 14;
            this.HRV1.Text = "HRV:";
            // 
            // Puls2
            // 
            this.Puls2.AutoSize = true;
            this.Puls2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puls2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Puls2.Location = new System.Drawing.Point(1055, 378);
            this.Puls2.Name = "Puls2";
            this.Puls2.Size = new System.Drawing.Size(56, 27);
            this.Puls2.TabIndex = 15;
            this.Puls2.Text = "Puls:";
            // 
            // Hrv2
            // 
            this.Hrv2.AutoSize = true;
            this.Hrv2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hrv2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hrv2.Location = new System.Drawing.Point(1055, 436);
            this.Hrv2.Name = "Hrv2";
            this.Hrv2.Size = new System.Drawing.Size(56, 27);
            this.Hrv2.TabIndex = 16;
            this.Hrv2.Text = "HRV:";
            // 
            // Hrv3
            // 
            this.Hrv3.AutoSize = true;
            this.Hrv3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hrv3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hrv3.Location = new System.Drawing.Point(1055, 584);
            this.Hrv3.Name = "Hrv3";
            this.Hrv3.Size = new System.Drawing.Size(56, 27);
            this.Hrv3.TabIndex = 18;
            this.Hrv3.Text = "HRV:";
            // 
            // Puls3
            // 
            this.Puls3.AutoSize = true;
            this.Puls3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puls3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Puls3.Location = new System.Drawing.Point(1055, 526);
            this.Puls3.Name = "Puls3";
            this.Puls3.Size = new System.Drawing.Size(56, 27);
            this.Puls3.TabIndex = 17;
            this.Puls3.Text = "Puls:";
            // 
            // puls1l
            // 
            this.puls1l.AutoSize = true;
            this.puls1l.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puls1l.ForeColor = System.Drawing.Color.DodgerBlue;
            this.puls1l.Location = new System.Drawing.Point(1158, 224);
            this.puls1l.Name = "puls1l";
            this.puls1l.Size = new System.Drawing.Size(51, 35);
            this.puls1l.TabIndex = 19;
            this.puls1l.Text = "hej";
            // 
            // hrv1l
            // 
            this.hrv1l.AutoSize = true;
            this.hrv1l.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrv1l.ForeColor = System.Drawing.Color.Gold;
            this.hrv1l.Location = new System.Drawing.Point(1158, 287);
            this.hrv1l.Name = "hrv1l";
            this.hrv1l.Size = new System.Drawing.Size(51, 35);
            this.hrv1l.TabIndex = 20;
            this.hrv1l.Text = "hej";
            // 
            // hrv2l
            // 
            this.hrv2l.AutoSize = true;
            this.hrv2l.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrv2l.ForeColor = System.Drawing.Color.Gold;
            this.hrv2l.Location = new System.Drawing.Point(1159, 436);
            this.hrv2l.Name = "hrv2l";
            this.hrv2l.Size = new System.Drawing.Size(51, 35);
            this.hrv2l.TabIndex = 22;
            this.hrv2l.Text = "hej";
            // 
            // puls2l
            // 
            this.puls2l.AutoSize = true;
            this.puls2l.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puls2l.ForeColor = System.Drawing.Color.DodgerBlue;
            this.puls2l.Location = new System.Drawing.Point(1159, 378);
            this.puls2l.Name = "puls2l";
            this.puls2l.Size = new System.Drawing.Size(51, 35);
            this.puls2l.TabIndex = 21;
            this.puls2l.Text = "hej";
            // 
            // hrv3l
            // 
            this.hrv3l.AutoSize = true;
            this.hrv3l.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrv3l.ForeColor = System.Drawing.Color.Gold;
            this.hrv3l.Location = new System.Drawing.Point(1158, 578);
            this.hrv3l.Name = "hrv3l";
            this.hrv3l.Size = new System.Drawing.Size(51, 35);
            this.hrv3l.TabIndex = 24;
            this.hrv3l.Text = "hej";
            // 
            // puls3l
            // 
            this.puls3l.AutoSize = true;
            this.puls3l.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puls3l.ForeColor = System.Drawing.Color.DodgerBlue;
            this.puls3l.Location = new System.Drawing.Point(1159, 520);
            this.puls3l.Name = "puls3l";
            this.puls3l.Size = new System.Drawing.Size(51, 35);
            this.puls3l.TabIndex = 23;
            this.puls3l.Text = "hej";
            // 
            // Medical_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1357, 685);
            this.Controls.Add(this.hrv3l);
            this.Controls.Add(this.puls3l);
            this.Controls.Add(this.hrv2l);
            this.Controls.Add(this.puls2l);
            this.Controls.Add(this.hrv1l);
            this.Controls.Add(this.puls1l);
            this.Controls.Add(this.Hrv3);
            this.Controls.Add(this.Puls3);
            this.Controls.Add(this.Hrv2);
            this.Controls.Add(this.Puls2);
            this.Controls.Add(this.HRV1);
            this.Controls.Add(this.Puls1);
            this.Controls.Add(this.ECG3Chart);
            this.Controls.Add(this.ECG2Chart);
            this.Controls.Add(this.ECG1Chart);
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
            this.Name = "Medical_Display";
            this.Text = "Medical_Display";
            ((System.ComponentModel.ISupportInitialize)(this.ECG1Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ECG2Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ECG3Chart)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart ECG1Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ECG2Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ECG3Chart;
        private System.Windows.Forms.Label Puls1;
        private System.Windows.Forms.Label HRV1;
        private System.Windows.Forms.Label Puls2;
        private System.Windows.Forms.Label Hrv2;
        private System.Windows.Forms.Label Hrv3;
        private System.Windows.Forms.Label Puls3;
        private System.Windows.Forms.Label puls1l;
        private System.Windows.Forms.Label hrv1l;
        private System.Windows.Forms.Label hrv2l;
        private System.Windows.Forms.Label puls2l;
        private System.Windows.Forms.Label hrv3l;
        private System.Windows.Forms.Label puls3l;
    }
}

