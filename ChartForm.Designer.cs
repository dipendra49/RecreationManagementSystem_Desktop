
namespace RecreationManagementSystem
{
    partial class ChartForm
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
            this.ticketRatePanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelBarChart = new System.Windows.Forms.Label();
            this.barChartControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.barChartControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.barChartControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ticketRatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketRatePanel
            // 
            this.ticketRatePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.ticketRatePanel.Controls.Add(this.chart1);
            this.ticketRatePanel.Controls.Add(this.labelBarChart);
            this.ticketRatePanel.Location = new System.Drawing.Point(2, 53);
            this.ticketRatePanel.Name = "ticketRatePanel";
            this.ticketRatePanel.Size = new System.Drawing.Size(1230, 685);
            this.ticketRatePanel.TabIndex = 20;
            this.ticketRatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ticketRatePanel_Paint);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 135);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Visitors";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Earnings";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1196, 388);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // labelBarChart
            // 
            this.labelBarChart.AutoSize = true;
            this.labelBarChart.BackColor = System.Drawing.Color.DarkOrange;
            this.labelBarChart.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarChart.ForeColor = System.Drawing.Color.White;
            this.labelBarChart.Location = new System.Drawing.Point(513, 10);
            this.labelBarChart.Name = "labelBarChart";
            this.labelBarChart.Size = new System.Drawing.Size(196, 45);
            this.labelBarChart.TabIndex = 17;
            this.labelBarChart.Text = "BAR CHART";
            // 
            // barChartControlBox3
            // 
            this.barChartControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barChartControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.barChartControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.barChartControlBox3.HoverState.Parent = this.barChartControlBox3;
            this.barChartControlBox3.IconColor = System.Drawing.Color.DimGray;
            this.barChartControlBox3.Location = new System.Drawing.Point(1105, 12);
            this.barChartControlBox3.Name = "barChartControlBox3";
            this.barChartControlBox3.ShadowDecoration.Parent = this.barChartControlBox3;
            this.barChartControlBox3.Size = new System.Drawing.Size(32, 29);
            this.barChartControlBox3.TabIndex = 23;
            // 
            // barChartControlBox1
            // 
            this.barChartControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barChartControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.barChartControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.barChartControlBox1.ForeColor = System.Drawing.Color.Black;
            this.barChartControlBox1.HoverState.Parent = this.barChartControlBox1;
            this.barChartControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.barChartControlBox1.Location = new System.Drawing.Point(1187, 12);
            this.barChartControlBox1.Name = "barChartControlBox1";
            this.barChartControlBox1.ShadowDecoration.Parent = this.barChartControlBox1;
            this.barChartControlBox1.Size = new System.Drawing.Size(32, 29);
            this.barChartControlBox1.TabIndex = 22;
            // 
            // barChartControlBox2
            // 
            this.barChartControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barChartControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.barChartControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.barChartControlBox2.HoverState.Parent = this.barChartControlBox2;
            this.barChartControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.barChartControlBox2.Location = new System.Drawing.Point(1145, 12);
            this.barChartControlBox2.Name = "barChartControlBox2";
            this.barChartControlBox2.ShadowDecoration.Parent = this.barChartControlBox2;
            this.barChartControlBox2.Size = new System.Drawing.Size(32, 29);
            this.barChartControlBox2.TabIndex = 21;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 739);
            this.Controls.Add(this.barChartControlBox3);
            this.Controls.Add(this.barChartControlBox1);
            this.Controls.Add(this.barChartControlBox2);
            this.Controls.Add(this.ticketRatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartForm";
            this.ticketRatePanel.ResumeLayout(false);
            this.ticketRatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ticketRatePanel;
        private System.Windows.Forms.Label labelBarChart;
        private Guna.UI2.WinForms.Guna2ControlBox barChartControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox barChartControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox barChartControlBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}