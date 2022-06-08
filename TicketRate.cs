using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace RecreationManagementSystem
{
    public partial class TicketRate : Form
    {
        XmlSerializer xmlSerializer; //declaring xmlSerializer
        List<ManageTicket> tickets;   //creating List 'tickets' of ManageTicket class type
        int indexRow;
        public TicketRate()
        {
            InitializeComponent();
            tickets = new List<ManageTicket>(); //creating object
            xmlSerializer = new XmlSerializer(typeof(List<ManageTicket>)); //creating object
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            //This event will transfer user from TicketRate form to Login page
            Form1 loginPage = new Form1(); //creating object of login page
            this.Hide();  //hiding TicketRate page
            loginPage.Show();    //displaying login page
        }

        private void TicketRate_Load(object sender, EventArgs e)
        {
            clearText(); //calling clearText() method which will erase all the inputfiled
            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/TicketPrice.xml", FileMode.Open, FileAccess.Read);
            tickets = (List<ManageTicket>)xmlSerializer.Deserialize(fileStream);
            ticketDataGridView.DataSource = tickets;  //showing data into datagridview
            fileStream.Close();
        }

        private void ticketAddBtn_Click(object sender, EventArgs e)
        {
            
            ManageTicket ticketRate = new ManageTicket();   //creating object of ManageTicket class
            bool isAdded = false;
           
            try
            {
                //getting values into input field and storing it into property
                ticketRate.hours = hourComboBox.SelectedItem.ToString();
                ticketRate.customerType = categoryComboBox.SelectedItem.ToString();
                ticketRate.ticketPrice = double.Parse(priceTextBox.Text);

                //checking condition if input field will be found empty, it will show message
                if (hourComboBox.SelectedIndex == 0 || categoryComboBox.SelectedIndex == 0 || priceTextBox.Text == "")
                {
                    MessageBox.Show("Please enter appropriate value!!", "Manage Ticket");
                }
                else
                {
                    //Adding data into List
                    tickets.Add(ticketRate);
                    var xmlWriterSettings = new XmlWriterSettings() { Indent = true };
                    //creating an xml file
                    using (XmlWriter xmlWriter = XmlWriter.Create("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/TicketPrice.xml", xmlWriterSettings))
                    {
                        xmlSerializer.Serialize(xmlWriter, tickets); //exporting data into xml file
                    }
                    isAdded = true;
                    
                    if (isAdded == true)
                    {
                        FileStream fStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/TicketPrice.xml", FileMode.Open, FileAccess.Read);
                        tickets = (List<ManageTicket>)xmlSerializer.Deserialize(fStream); //extracting data from xml file
                        ticketDataGridView.DataSource = tickets;     //displaying data into datagridview
                        MessageBox.Show("Data are successfully added", "Manage Ticket");
                        fStream.Close();
                    }
                    clearText();   //calling clearText() method to erase input field
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ticketClearBtn_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void ticketDelBtn_Click(object sender, EventArgs e)
        {
           
           

        }


        

        private void manageEmployeeBtn_Click(object sender, EventArgs e)
        {
            Employee manageEmployeeForm = new Employee();   //creating object of Employee class
            this.Hide();
            manageEmployeeForm.Show();
        }

        private void ticketDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting datagridview value into input filed when user click on cell of datagridview
            indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                hourComboBox.SelectedItem = ticketDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                categoryComboBox.SelectedItem = ticketDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                double.Parse(priceTextBox.Text = ticketDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("Select a row", "Manage Ticket");
            }
           
        }

        private void manageDiscountBtn_Click(object sender, EventArgs e)
        {
            Discount discountForm = new Discount();  //creating object of Discount class
            this.Hide();
            discountForm.Show();
        }

        private void ticketUpdateBtn_Click(object sender, EventArgs e)
        {
            //updating value of datagridview
            /*
                 ticketDataGridView.SelectedRows[0].Cells[0].Value = hourComboBox.SelectedItem;
                 ticketDataGridView.SelectedRows[0].Cells[1].Value = categoryComboBox.SelectedItem;
                 ticketDataGridView.SelectedRows[0].Cells[2].Value = priceTextBox.Text;
                 clearText();
             */
            DataGridViewRow newData = ticketDataGridView.Rows[indexRow];
            newData.Cells[0].Value = hourComboBox.SelectedItem;
            newData.Cells[1].Value = categoryComboBox.SelectedItem;
            newData.Cells[2].Value = priceTextBox.Text;
            clearText();


        }
        //creating clearText() method which will erase all the input field when called
        public void clearText()
        {
            categoryComboBox.SelectedIndex = 0;
            hourComboBox.SelectedIndex = 0;
            priceTextBox.Clear();
        }
    }
}
