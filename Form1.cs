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
using System.Text.RegularExpressions;

namespace RecreationManagementSystem
{
    public partial class Form1 : Form
    {
        XmlSerializer xmlSerializer;
        List<User> users;
        public Form1()
        {
            InitializeComponent();
            users = new List<User>();
            xmlSerializer = new XmlSerializer(typeof(List<User>));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginComboBox.SelectedIndex = 0;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Signup register = new Signup();
            this.Hide();
            register.Show();
        }

        private void loginClearBtn_Click(object sender, EventArgs e)
        {
            loginComboBox.SelectedIndex = 0;
            loginUserTextBox.Clear();
            loginPasswordTextBox.Clear();
            loginShowPassword.Checked = false;
            rememberMeToggleSwitch.Checked = false;
        }

        private void loginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (loginShowPassword.Checked)
            {
                loginPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                loginPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void loginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/User.xml", FileMode.Open, FileAccess.Read);
            users = (List<User>)xmlSerializer.Deserialize(fileStream);

            string logComboBox = loginComboBox.SelectedItem.ToString();
            //string logComboBox = loginComboBox.GetItemText(loginComboBox.SelectedItem);
            string logUserName = loginUserTextBox.Text;
            string logPassword = loginPasswordTextBox.Text;
            bool dataFound = false;


            foreach (var user in users)
            {
                if (logComboBox == user.role && logUserName == user.userName && logPassword == user.password)
                {
                    //checking condition when role is selected the system will transfer admin and staff into their respective page
                    if (logComboBox == "STAFF")
                    {
                        MessageBox.Show("You are logged in as STAFF", "Login");
                        loginComboBox.SelectedIndex = 0;
                        loginUserTextBox.Clear();
                        loginPasswordTextBox.Clear();
                        loginShowPassword.Checked = false;
                        rememberMeToggleSwitch.Checked = false;
                        dataFound = true;

                        //Transferring Admin into ticket rate page
                        VisitorDetails visitorDetailsPage = new VisitorDetails();
                        this.Hide();
                        visitorDetailsPage.Show();

                    }
                    break;
                }

                if (logComboBox == "ADMIN" && logUserName == "Admin49@gmail.com" && logPassword == "Admin@123")
                {
                    MessageBox.Show("You are logged in as ADMIN", "Login");
                    loginComboBox.SelectedIndex = 0;
                    loginUserTextBox.Clear();
                    loginPasswordTextBox.Clear();
                    loginShowPassword.Checked = false;
                    rememberMeToggleSwitch.Checked = false;
                    dataFound = true;

                    //Transferring Admin into ticket rate page
                    TicketRate ticketRatePage = new TicketRate();
                    this.Hide();
                    ticketRatePage.Show();
                    break;
                }


                
               
                if (loginComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select role", "Login");
                    dataFound = true;
                    break;
                }

                if (logUserName == "" || logPassword == "")
                {
                    MessageBox.Show("Please enter username or password", "Login");
                    dataFound = true;
                    break;
                }

            }
            if (!dataFound)
            {
                foreach(var user in users)
                {
                    if (logUserName != user.userName || logPassword != user.password)
                    {
                        MessageBox.Show("Invalid username or password has been entered", "Login");
                        break;
                    }

                    if (loginComboBox.SelectedIndex == 1 || loginComboBox.SelectedIndex == 2)
                    {
                        MessageBox.Show("Invalid role has been selected", "Login");
                        break;
                    }
                }
            }
        }

        private void labelForgetPassword_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/User.xml", FileMode.Open, FileAccess.Read);
            users = (List<User>)xmlSerializer.Deserialize(fileStream);

            string logComboBox = loginComboBox.SelectedItem.ToString();
            string logUserName = loginUserTextBox.Text;
            bool dataFound = false;


            foreach (var user in users)
            {
                if (logComboBox == "ADMIN" && logUserName == "Admin49@gmail.com")
                {
                    MessageBox.Show("Your password is 'Admin@123'", "Login");
                    dataFound = true;
                    break;
                }
                if (logComboBox == user.role && logUserName == user.userName)
                {
                    MessageBox.Show("Your password is " + user.password, "Login");
                    loginComboBox.SelectedIndex = 0;
                    loginUserTextBox.Clear();
                    loginPasswordTextBox.Clear();
                    loginShowPassword.Checked = false;
                    rememberMeToggleSwitch.Checked = false;
                    dataFound = true;
                    break;
                }
                if (loginComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select role", "Login");
                    dataFound = true;
                    break;
                }

                if (logUserName == "")
                {
                    MessageBox.Show("Please enter username!!", "Login");
                    dataFound = true;
                    break;
                }
            }
            if (!dataFound)
            {
                foreach (var user in users)
                {
                    if (logComboBox != user.role && logUserName == user.userName)
                    {
                        MessageBox.Show("Invalid role has been selected", "Login");
                        break;
                    }

                    if (logUserName != user.userName)
                    {
                        MessageBox.Show("Password not found!! Invalid username has been entered", "Login");
                        break;
                    }
                }
            }
        }
    }
}
