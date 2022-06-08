using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationManagementSystem
{
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            weeklyTotalVisitorTextBox.ReadOnly = true;
            weeklyReportTextBox.ReadOnly = true;
        }

        public void ShowData(List<ManageVisitorDetails> visitor)
        {
            decimal totalEarning = 0;
            decimal totalVisitor = 0;

            for (int i = 0; i < weeklyReportDataGridView.Rows.Count; i++)
            {
                totalEarning += Convert.ToDecimal(weeklyReportDataGridView.Rows[i].Cells["totalAmount"].Value);
            }

            for (int i = 0; i < weeklyReportDataGridView.Rows.Count; i++)
            {
                totalVisitor += Convert.ToDecimal(weeklyReportDataGridView.Rows[i].Cells["totalVisitor"].Value);
            }

            weeklyTotalVisitorTextBox.Text = totalVisitor.ToString();
            weeklyReportTextBox.Text = totalEarning.ToString();
            weeklyReportDataGridView.DataSource = visitor;

           
        }
    }
}
