using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Xml;

namespace RecreationManagementSystem
{
    public partial class Signup : Form
    {
        XmlSerializer xmlSerializer;
        List<User> users;
        public Signup()
        {
            users = new List<User>();
            InitializeComponent();
            xmlSerializer = new XmlSerializer(typeof(List<User>));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            regUserTextBox.Clear();
            regPasswordTextBox.Clear();
            regConPassTextBox.Clear();
            regShowPass.Checked = false;
            
            
        }

        private void regShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (regShowPass.Checked)
            {
                regPasswordTextBox.UseSystemPasswordChar = false;
                regConPassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                regPasswordTextBox.UseSystemPasswordChar = true;
                regConPassTextBox.UseSystemPasswordChar = true;
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
           
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            User person = new User();
            person.role = "STAFF";
            person.userName = regUserTextBox.Text;
            person.password = regPasswordTextBox.Text;
            person.confirmPassword = regConPassTextBox.Text;
            Boolean dataFound = false;

            //regex function
            Regex userReg = new Regex(@"^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}");
            Regex passwordReg = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            //Condition if username is already present in the gridview, do not allow the user to signup again
            foreach (var user in users)
            {
                if (person.userName == user.userName)
                {
                    MessageBox.Show("Username already exists", "Signup");
                    dataFound = true;
                    break;
                }
            }
            if (!dataFound)
            {
                if (userReg.IsMatch(person.userName) && passwordReg.IsMatch(person.password) && regPasswordTextBox.Text == regConPassTextBox.Text)
                {
                    users.Add(person);

                    var xmlWriterSettings = new XmlWriterSettings() { Indent = true };
                    using (XmlWriter xmlWriter = XmlWriter.Create("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/User.xml", xmlWriterSettings))
                    {
                        xmlSerializer.Serialize(xmlWriter, users);
                       
                        
                    }
                    

                    MessageBox.Show("Signed up successfully!! Your account has been created.", "Signup");
                    regUserTextBox.Clear();
                    regPasswordTextBox.Clear();
                    regConPassTextBox.Clear();
                    regShowPass.Checked = false;
                }
                else if (regPasswordTextBox.Text != regConPassTextBox.Text)
                {
                    MessageBox.Show("Enter matching password!!", "Signup");
                }
                else if (regPasswordTextBox.Text =="" || regConPassTextBox.Text == "")
                {
                    MessageBox.Show("Empty input field is found. Please fill all the textbox!!", "Signup");
                }
                else if (!passwordReg.IsMatch(person.password))
                {
                    MessageBox.Show("Kindly choose strong password!!", "Signup");
                }
                else
                {
                    MessageBox.Show("Invalid email!!", "Signup");
                }

            }
        }
    }
}
