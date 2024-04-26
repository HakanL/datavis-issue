namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation rectangleAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation();
            System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation rectangleAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation();
            System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation rectangleAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 66.666671752929688D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 16.666667938232422D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 16.666667938232422D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // chart
            // 
            rectangleAnnotation1.AnchorAlignment = ContentAlignment.MiddleCenter;
            rectangleAnnotation1.AnchorDataPointName = "Good\\r0";
            rectangleAnnotation1.AnchorOffsetX = -22.11D;
            rectangleAnnotation1.AnchorOffsetY = -25D;
            rectangleAnnotation1.Name = "RectangleAnnotation1";
            rectangleAnnotation1.Text = "67%";
            rectangleAnnotation2.AnchorAlignment = ContentAlignment.MiddleCenter;
            rectangleAnnotation2.AnchorDataPointName = "Neither\\r0";
            rectangleAnnotation2.AnchorOffsetX = -5.61D;
            rectangleAnnotation2.AnchorOffsetY = -25D;
            rectangleAnnotation2.Name = "RectangleAnnotation2";
            rectangleAnnotation2.Text = "17%";
            rectangleAnnotation3.AnchorAlignment = ContentAlignment.MiddleCenter;
            rectangleAnnotation3.AnchorDataPointName = "Bad\\r0";
            rectangleAnnotation3.AnchorOffsetX = -5.61D;
            rectangleAnnotation3.AnchorOffsetY = -25D;
            rectangleAnnotation3.Name = "RectangleAnnotation3";
            rectangleAnnotation3.Text = "17%";
            chart.Annotations.Add(rectangleAnnotation1);
            chart.Annotations.Add(rectangleAnnotation2);
            chart.Annotations.Add(rectangleAnnotation3);
            chart.BackColor = Color.Transparent;
            chart.BorderlineColor = Color.FromArgb(26, 59, 105);
            chart.BorderSkin.BackColor = Color.CornflowerBlue;
            chart.BorderSkin.BackSecondaryColor = Color.CornflowerBlue;
            chart.BorderSkin.PageColor = Color.AliceBlue;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 3;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 12;
            chartArea1.AxisX.LabelStyle.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            chartArea1.AxisX.LabelStyle.Format = "G0";
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 7D;
            chartArea1.AxisX.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisX.MajorTickMark.LineWidth = 0;
            chartArea1.AxisX.MinorGrid.LineColor = Color.Silver;
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 8.25F);
            chartArea1.AxisX2.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisX2.MinorGrid.LineColor = Color.Silver;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 12;
            chartArea1.AxisY.LabelStyle.Font = new Font("Calibri", 12F);
            chartArea1.AxisY.LabelStyle.Format = "{N0} %";
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineWidth = 2;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.MinorGrid.LineColor = Color.Silver;
            chartArea1.AxisY.TitleFont = new Font("Calibri", 12F);
            chartArea1.AxisY2.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisY2.MinorGrid.LineColor = Color.Silver;
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BorderColor = Color.FromArgb(26, 59, 105);
            chartArea1.BorderWidth = 0;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 65F;
            chartArea1.InnerPlotPosition.X = 35F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "Default";
            chart.ChartAreas.Add(chartArea1);
            chart.Location = new Point(0, 0);
            chart.Name = "chart";
            chart.PaletteCustomColors = new Color[]
    {
    Color.Blue,
    Color.Yellow,
    Color.Red
    };
            series1.BorderColor = Color.FromArgb(64, 64, 64);
            series1.BorderWidth = 0;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.CustomProperties = "PointWidth=0.7, LabelStyle=Top";
            series1.Font = new Font("Calibri", 9.75F);
            series1.LabelBackColor = Color.White;
            series1.LabelBorderColor = Color.Black;
            series1.LabelFormat = "{N0} %";
            series1.LegendText = "{Good}";
            series1.Name = "Good";
            dataPoint1.LabelBackColor = Color.White;
            dataPoint1.LabelBorderColor = Color.Black;
            series1.Points.Add(dataPoint1);
            series2.BorderColor = Color.FromArgb(64, 64, 64);
            series2.BorderWidth = 0;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.CustomProperties = "PointWidth=0.7";
            series2.Font = new Font("Calibri", 9.75F);
            series2.LabelBackColor = Color.White;
            series2.LabelBorderColor = Color.Black;
            series2.LabelFormat = "{N0} %";
            series2.LegendText = "{Neither}";
            series2.Name = "Neither";
            dataPoint2.LabelBackColor = Color.White;
            dataPoint2.LabelBorderColor = Color.Black;
            series2.Points.Add(dataPoint2);
            series3.BorderColor = Color.FromArgb(64, 64, 64);
            series3.BorderWidth = 0;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series3.CustomProperties = "PointWidth=0.7";
            series3.Font = new Font("Calibri", 9.75F);
            series3.LabelBackColor = Color.White;
            series3.LabelBorderColor = Color.Black;
            series3.LabelFormat = "{N0} %";
            series3.LegendText = "{Bad}";
            series3.Name = "Bad";
            dataPoint3.LabelBackColor = Color.White;
            dataPoint3.LabelBorderColor = Color.Black;
            series3.Points.Add(dataPoint3);
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Color = Color.Transparent;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Default";
            series4.Name = "Other";
            series4.Points.Add(dataPoint4);
            chart.Series.Add(series1);
            chart.Series.Add(series2);
            chart.Series.Add(series3);
            chart.Series.Add(series4);
            chart.Size = new Size(1233, 132);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 171);
            Controls.Add(chart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
