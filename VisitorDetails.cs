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
    public partial class VisitorDetails : Form
    {
        XmlSerializer xmlSerializer;
        List<ManageVisitorDetails> visitors;
        public VisitorDetails()
        {
            InitializeComponent();
            visitors = new List<ManageVisitorDetails>();
            xmlSerializer = new XmlSerializer(typeof(List<ManageVisitorDetails>));
        }

        private void ticketNumTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }
        public void autoTicketNum()
        {
           
            
        }

        private void ticketAddBtn_Click(object sender, EventArgs e)
        {
            ManageVisitorDetails visitorObj = new ManageVisitorDetails();
            bool isAdded = false;

            try
            {
                visitorObj.ticketNo = int.Parse(ticketNumTextBox.Text);
                visitorObj.visitorName = visitorNameTextBox.Text;
                DateTime date = DateTime.Now;
                dateTextBox.Text = date.ToString("d");
                visitorObj.date = dateTextBox.Text;
                DayOfWeek day = date.DayOfWeek;
                dayTextBox.Text = day.ToString();
                visitorObj.day = dayTextBox.Text;
                visitorObj.child = int.Parse(childTextBox.Text);
                visitorObj.adult = int.Parse(adultTextBox.Text);
                //totalVisitorsTextBox.Text = (int.Parse(childTextBox.Text) + int.Parse(adultTextBox.Text)).ToString();
                totalVisitorsTextBox.ReadOnly = true;
                visitorObj.totalVisitor = int.Parse(totalVisitorsTextBox.Text);
                visitorObj.duration = durationComboBox.SelectedItem.ToString();
                visitorObj.discount = discountTextBox.Text;
                visitorObj.totalAmount = double.Parse(totalAmountTextBox.Text);


                if (ticketNumTextBox.Text == "" || visitorNameTextBox.Text == "" || childTextBox.Text == "" || adultTextBox.Text == "" ||
                    totalVisitorsTextBox.Text == "" || durationComboBox.SelectedIndex == 0 || discountTextBox.Text == "" || totalAmountTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the input field", "Manage Visitor's Details");
                }
                else
                {
                    //Adding data into List
                    visitors.Add(visitorObj);
                    var xmlWriterSettings = new XmlWriterSettings() { Indent = true };
                    using (XmlWriter xmlWriter = XmlWriter.Create("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/VisitorDetails.xml", xmlWriterSettings))
                    {
                        xmlSerializer.Serialize(xmlWriter, visitors);
                    }
                    isAdded = true;

                    if (isAdded == true)
                    {
                        FileStream fStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/VisitorDetails.xml", FileMode.Open, FileAccess.Read);
                        visitors = (List<ManageVisitorDetails>)xmlSerializer.Deserialize(fStream);
                        visitorDataGridView.DataSource = visitors;
                        MessageBox.Show("Data are successfully added", "Manage Visitor's Details");
                        fStream.Close();



                    }

                    clear();
                    //ticketNumTextBox.Text = visitorObj.ticketNo++.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void VisitorDetails_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateTextBox.Text = date.ToString("d");
            DayOfWeek day = date.DayOfWeek;
            dayTextBox.Text = day.ToString();
            totalVisitorsTextBox.ReadOnly = true;
            durationComboBox.SelectedIndex = 0;
            totalAmountTextBox.ReadOnly = true;
            discountTextBox.ReadOnly = true;
            dateTextBox.ReadOnly = true;
            dayTextBox.ReadOnly = true;

            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/VisitorDetails.xml", FileMode.Open, FileAccess.Read);
            visitors = (List<ManageVisitorDetails>)xmlSerializer.Deserialize(fileStream);
            visitorDataGridView.DataSource = visitors;
            fileStream.Close();

        }

        private void totalVisitorsTextBox_TextChanged(object sender, EventArgs e)
        {
            string num = (totalVisitorsTextBox.Text);
            switch (num)
            {
                case "5":
                    discountTextBox.Text = "10%";
                    break;

                case "10":
                    discountTextBox.Text = "15%";
                    break;

                case "15":
                    discountTextBox.Text = "20%";
                    break;

                case "20":
                    discountTextBox.Text = "25%";
                    break;

                default:
                    discountTextBox.Text = "0%";
                    break;
            }


        }

        private void childTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(childTextBox.Text) && !string.IsNullOrEmpty(adultTextBox.Text))
            {
                totalVisitorsTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) + Convert.ToInt32(adultTextBox.Text)));
            }

            if (!string.IsNullOrEmpty(childTextBox.Text) && !string.IsNullOrEmpty(adultTextBox.Text) && durationComboBox.SelectedIndex != 0)
            {
                if (durationComboBox.SelectedIndex == 1)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550));
                    }
                    
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550)-disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                }

                if (durationComboBox.SelectedIndex == 2)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000)-disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                }

                if (durationComboBox.SelectedIndex == 3)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500)-disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

                if (durationComboBox.SelectedIndex == 4)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100)-disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

                if (durationComboBox.SelectedIndex == 5)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700)-disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

            }
            if (durationComboBox.SelectedIndex == 0)
            {
                totalAmountTextBox.Clear();
            }
        }

        private void adultTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(childTextBox.Text) && !string.IsNullOrEmpty(adultTextBox.Text))
            {
                totalVisitorsTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) + Convert.ToInt32(adultTextBox.Text)));
            }

            if (!string.IsNullOrEmpty(childTextBox.Text) && !string.IsNullOrEmpty(adultTextBox.Text) && durationComboBox.SelectedIndex != 0)
            {
                if (durationComboBox.SelectedIndex == 1)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                }

                if (durationComboBox.SelectedIndex == 2)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                }

                if (durationComboBox.SelectedIndex == 3)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

                if (durationComboBox.SelectedIndex == 4)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

                if (durationComboBox.SelectedIndex == 5)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

            }
            if (durationComboBox.SelectedIndex == 0)
            {
                totalAmountTextBox.Clear();
            }
        }

        private void durationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(childTextBox.Text) && !string.IsNullOrEmpty(adultTextBox.Text) && durationComboBox.SelectedIndex != 0)
            {
                if (durationComboBox.SelectedIndex == 1)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 400 + Convert.ToInt32(adultTextBox.Text) * 550) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                }

                if (durationComboBox.SelectedIndex == 2)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 700 + Convert.ToInt32(adultTextBox.Text) * 1000) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                }

                if (durationComboBox.SelectedIndex == 3)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1050 + Convert.ToInt32(adultTextBox.Text) * 1500) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

                if (durationComboBox.SelectedIndex == 4)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 1450 + Convert.ToInt32(adultTextBox.Text) * 2100) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

                if (durationComboBox.SelectedIndex == 5)
                {
                    if (discountTextBox.Text == "0%")
                    {
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700));
                    }
                    if (discountTextBox.Text == "10%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 10;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "15%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 15;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "20%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 20;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }

                    if (discountTextBox.Text == "25%")
                    {
                        int disAMt = (Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) * 25;
                        int disAmt2 = disAMt / 100;
                        totalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(childTextBox.Text) * 2200 + Convert.ToInt32(adultTextBox.Text) * 2700) - disAmt2);
                        //totalAmountTextBox.Text = Convert.ToString(disAmt2);
                    }
                }

            }
            if (durationComboBox.SelectedIndex == 0)
            {
                totalAmountTextBox.Clear();
            }
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            this.Hide();
            loginPage.Show();
        }

        public void clear()
        {
            ticketNumTextBox.Clear();
            visitorNameTextBox.Clear();
            childTextBox.Clear();
            adultTextBox.Clear();
            totalVisitorsTextBox.Clear();
            durationComboBox.SelectedIndex = 0;
            discountTextBox.Clear();
            totalAmountTextBox.Clear();
        }

        private void ticketClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void exportDetailsBtn_Click(object sender, EventArgs e)
        {
            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;

            //Add the Header row for CSV file.
            foreach (DataGridViewColumn column in visitorDataGridView.Columns)
            {
                csv += column.HeaderText + ',';
            }

            //Add new line.
            csv += "\r\n";

            //Adding the Rows
            foreach (DataGridViewRow row in visitorDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                csv += "\r\n";
            }

            //Exporting to CSV.
            string folderPath = "C:/Users/Dipendra/source/repos/RecreationManagementSystem/";
            File.WriteAllText(folderPath + "VisitorDetails.csv", csv);
            MessageBox.Show("Data has been exported into CSV file", "Manage Visitor's Details");
        }

        private void importDetailsBtn_Click(object sender, EventArgs e)
        {
            ImportCSVForm csvObj = new ImportCSVForm();
            csvObj.Show();
        }

        private void viewChartBtn_Click(object sender, EventArgs e)
        {
            ChartForm chartFormObj = new ChartForm();
            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/VisitorDetails.xml", FileMode.Open, FileAccess.Read);
            visitors = (List<ManageVisitorDetails>)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();

            chartFormObj.LoadData(visitors);
            chartFormObj.Show();
        }

        private void viewWeeklyReportBtn_Click(object sender, EventArgs e)
        {
            WeeklyReport weekRptObj = new WeeklyReport();
            weekRptObj.ShowData(visitors);
            weekRptObj.Show();
            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/VisitorDetails.xml", FileMode.Open, FileAccess.Read);
            visitors = (List<ManageVisitorDetails>)xmlSerializer.Deserialize(fileStream);
            weekRptObj.ShowData(visitors);
            fileStream.Close();
        }

        private void viewDailyReportBtn_Click(object sender, EventArgs e)
        {
            DailyReport dailyRptObj = new DailyReport();
            dailyRptObj.ShowDailyData(visitors);
            dailyRptObj.Show();
            FileStream fileStream = new FileStream("C:/Users/Dipendra/source/repos/RecreationManagementSystem/RecreationManagementSystem/VisitorDetails.xml", FileMode.Open, FileAccess.Read);
            visitors = (List<ManageVisitorDetails>)xmlSerializer.Deserialize(fileStream);
            dailyRptObj.ShowDailyData(visitors);
            fileStream.Close();
        }
    }
}
