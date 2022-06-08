using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace RecreationManagementSystem
{
    public partial class Discount : Form
    {
        XmlSerializer xmlSerializer;
        List<ManageDiscount> discounts;
        int indexRow;
        public Discount()
        {
            InitializeComponent();
            discounts = new List<ManageDiscount>();
            xmlSerializer = new XmlSerializer(typeof(List<ManageDiscount>));

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            this.Hide();
            loginPage.Show();
        }

        private void manageTicketBtn_Click(object sender, EventArgs e)
        {
            TicketRate ticketRatePage = new TicketRate();
            this.Hide();
            ticketRatePage.Show();
        }

        private void manageEmployeeBtn_Click(object sender, EventArgs e)
        {

            Employee manageEmployeeForm = new Employee();
            this.Hide();
            manageEmployeeForm.Show();
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            clear();
            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/Discount.xml", FileMode.Open, FileAccess.Read);
            discounts = (List<ManageDiscount>)xmlSerializer.Deserialize(fileStream);
            discountDataGridView.DataSource = discounts;
            fileStream.Close();
        }

        //Creating a method to clear all the input fields
        public void clear()
        {
            visitorInGroupComboBox.SelectedIndex = 0;
            discountTextBox.Clear();
        }

        private void ticketAddBtn_Click(object sender, EventArgs e)
        {
            ManageDiscount discountObj = new ManageDiscount();
            bool isAdded = false;

            try
            {
                discountObj.visitorGroup = visitorInGroupComboBox.SelectedItem.ToString();
                discountObj.discount = Int32.Parse(discountTextBox.Text);
                

                if (visitorInGroupComboBox.SelectedIndex == 0 || discountTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the details", "Manage Discount");
                }
                else
                {
                    //Adding data into List
                    discounts.Add(discountObj);
                    var xmlWriterSettings = new XmlWriterSettings() { Indent = true };
                    using (XmlWriter xmlWriter = XmlWriter.Create("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/Discount.xml", xmlWriterSettings))
                    {
                        xmlSerializer.Serialize(xmlWriter, discounts);
                    }
                    isAdded = true;

                    if (isAdded == true)
                    {
                        FileStream fStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/Discount.xml", FileMode.Open, FileAccess.Read);
                        discounts = (List<ManageDiscount>)xmlSerializer.Deserialize(fStream);
                        discountDataGridView.DataSource = discounts;
                        MessageBox.Show("Data are successfully added", "Manage Discount");
                        fStream.Close();
                    }
                    clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ticketClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void discountDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                visitorInGroupComboBox.SelectedItem = discountDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                int.Parse(discountTextBox.Text = discountDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            else
            {
                MessageBox.Show("Select a row", "Manage Discount");
            }

        }

        

        private void ticketDelBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void manageDisUpdateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = discountDataGridView.Rows[indexRow];
            newData.Cells[0].Value = visitorInGroupComboBox.SelectedItem;
            newData.Cells[1].Value = discountTextBox.Text;
            clear();
            
        }
    }
}
