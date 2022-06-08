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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }
        int initialPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            initialPoint += 1;
            progressBar.Value = initialPoint;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                Form1 login = new Form1();
                this.Hide();
                login.Show();
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
