using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationManagementSystem
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            dailyAdultReportTextBox.ReadOnly = true;
            dailyChildReportTextBox.ReadOnly = true;
            totalGroupDailyTextBox.ReadOnly = true;
        }

        public void ShowDailyData(List<ManageVisitorDetails> visitor)
        {
            decimal totalChild = 0;
            decimal totalAdult = 0;
            decimal totalGroup = 0;

            for (int i = 0; i < dailyReportDataGridView.Rows.Count; i++)
            {
                totalChild += Convert.ToDecimal(dailyReportDataGridView.Rows[i].Cells["child"].Value);
            }

            for (int i = 0; i < dailyReportDataGridView.Rows.Count; i++)
            {
                totalAdult += Convert.ToDecimal(dailyReportDataGridView.Rows[i].Cells["adult"].Value);
            }

            for (int i = 0; i < dailyReportDataGridView.Rows.Count; i++)
            {
                totalGroup += Convert.ToDecimal(dailyReportDataGridView.Rows[i].Cells["totalVisitor"].Value);
            }

            dailyAdultReportTextBox.Text = totalAdult.ToString();
            dailyChildReportTextBox.Text = totalChild.ToString();
            totalGroupDailyTextBox.Text = totalGroup.ToString();
            dailyReportDataGridView.DataSource = visitor;


        }
    }
}
