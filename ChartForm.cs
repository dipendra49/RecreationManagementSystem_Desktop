using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace RecreationManagementSystem
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ticketRatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadData(List<ManageVisitorDetails> visitors)
        {
            if (visitors != null)
            {
                chart1.DataSource = visitors;
                chart1.Series["Total Visitors"].ChartType = SeriesChartType.Column;
                chart1.Series["Total Earnings"].ChartType = SeriesChartType.Column;
                //set the member of the chart data source used to data bind to the X-values of the series  
                //chart1.Series["Total Visitors"].XValueMember = "Sunday";
                chart1.Series["Total Earnings"].XValueMember = "day";
                //set the member columns of the chart data source used to data bind to the X-values of the series  
                chart1.Series["Total Visitors"].YValueMembers = "totalVisitor";
                chart1.Series["Total Earnings"].YValueMembers = "totalAmount";
                chart1.Titles.Add("Earning Chart");
            }
            else
            {
                MessageBox.Show("List is empty!");
            }

        }
    }
}
