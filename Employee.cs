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
    public partial class Employee : Form
    {
        XmlSerializer xmlSerializer; 
        List<ManageEmployee> employees;
        public Employee()
        {
            InitializeComponent();
            employees = new List<ManageEmployee>();
            xmlSerializer = new XmlSerializer(typeof(List<ManageEmployee>));
        }

        private void manageTicketBtn_Click(object sender, EventArgs e)
        {
            TicketRate ticketRatePage = new TicketRate();  //creating object of TicketRate class
            this.Hide();
            ticketRatePage.Show();
            
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            this.Hide();
            loginPage.Show();
        }

        private void employeeAddBtn_Click(object sender, EventArgs e)
        {
            ManageEmployee staff = new ManageEmployee();
            bool isAdded = false;
            bool dataFound = false;
            
           try{
                //getting values in input field and storing it into property
                staff.staffID = staffIDTextBox.Text;
                staff.staffName = staffNameTextBox.Text;
                staff.address = addressTextBox.Text;
                staff.contact = contactTextBox.Text;
                staff.salary = double.Parse(salaryTextBox.Text);

                //Condition check if staff ID is already present in the gridview, do not allow the admin  to add the staff again
                foreach (var staffs in employees)
                {
                    if (staff.staffID == staffs.staffID)
                    {
                        MessageBox.Show("Staff ID already exists!!", "Manage Employees");
                        dataFound = true;
                        break;
                    }
                }
                if(!dataFound)
                {
                    if (staffIDTextBox.Text == "" || staffNameTextBox.Text == "" || addressTextBox.Text == "" || contactTextBox.Text == "" || salaryTextBox.Text == "")
                    {
                        MessageBox.Show("Please fill all the textbox correctly!!", "Add Employee");
                    }
                    else
                    {
                        //Adding data into List
                        employees.Add(staff);
                        var xmlWriterSettings = new XmlWriterSettings() { Indent = true };
                        //creating xml file
                        using (XmlWriter xmlWriter = XmlWriter.Create("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/Employee.xml", xmlWriterSettings))
                        {
                            xmlSerializer.Serialize(xmlWriter, employees); //exporting data into xml file
                        }
                        isAdded = true;

                        if (isAdded == true)
                        {
                            FileStream fStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/Employee.xml", FileMode.Open, FileAccess.Read);
                            employees = (List<ManageEmployee>)xmlSerializer.Deserialize(fStream);  //extracting data from xml file
                            employeeDataGridView.DataSource = employees;
                            MessageBox.Show("Employees data are successfully added", "Manage Employee");
                            fStream.Close();
                        }
                        clearText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeeClearBtn_Click(object sender, EventArgs e)
        {
            clearText(); //calling clearText() method
        }

       

        private void employeeUpdateBtn_Click(object sender, EventArgs e)
        {
            //updating data stored in datagridview
            employeeDataGridView.SelectedRows[0].Cells[0].Value = staffIDTextBox.Text;
            employeeDataGridView.SelectedRows[0].Cells[1].Value = staffNameTextBox.Text;
            employeeDataGridView.SelectedRows[0].Cells[2].Value = addressTextBox.Text;
            employeeDataGridView.SelectedRows[0].Cells[3].Value = contactTextBox.Text;
            employeeDataGridView.SelectedRows[0].Cells[4].Value = salaryTextBox.Text;
            clearText();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            clearText(); //calling clearText() method
            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/Employee.xml", FileMode.Open, FileAccess.Read);
            employees = (List<ManageEmployee>)xmlSerializer.Deserialize(fileStream);
            employeeDataGridView.DataSource = employees;
            fileStream.Close();
        }

        //Creating a clear textbox method to clear all the textfield
        public void clearText()
        {
            staffIDTextBox.Clear();
            staffNameTextBox.Clear();
            addressTextBox.Clear();
            contactTextBox.Clear();
            salaryTextBox.Clear();
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting values in input field when user select the cell
            if (e.RowIndex >= 0)
            {
                staffIDTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                staffNameTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                addressTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                contactTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                double.Parse(salaryTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            else
            {
                MessageBox.Show("Select a row", "Manage Employees");
            }
        }

        private void employeeDelBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void manageDiscountBtn_Click(object sender, EventArgs e)
        {
            Discount discountForm = new Discount();
            this.Hide();
            discountForm.Show();
        }
    }
}
