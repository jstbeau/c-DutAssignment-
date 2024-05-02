using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRI_GROUP_D
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Making panel1,2,3 invisible
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

       private void Form2_Load(object sender, EventArgs e)
        {

        }

        //Declaring strings to be used
        public static string plan, interior, exterior, covid;
        public static string dateTime, timeDate;
        public static string monday, tuesday, wednesday, thursday, friday, saturday, sunday;
        public static string time1, time2, time3, time4, time5, time6, time7;

        //Recurring Service Plan
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                interior = "Covid 19 Sanitizing/Cleaning";
                checkBox5.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                interior = "Exterior Cleaning";
                checkBox6.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                interior = "Interior Spring/Deep Cleaning";
                checkBox6.Checked = false;
                checkBox7.Checked = false;
            }
        }

        //Single Service Cleaning Plans
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                interior = "Covid 19 Sanitizing/Cleaning";
                checkBox10.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                interior = "Exterior Cleaning";
                checkBox10.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                interior = "Interior Spring/Deep Cleaning";
                checkBox9.Checked = false;
                checkBox8.Checked = false;
            }
        }

        //When previous button is clicked Form1 will be opened
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //Declaring strings to be used
        public static string service;
        public static int    rooms, area, sum1;

        //Displays when Single Service is selected, else Recurring Service is displayed
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = "Single Service";
            string b = comboBox1.SelectedItem.ToString();
            bool Sservice = a == b;

            if (Sservice)
            {
                panel1.Visible = true;
                panel3.Visible = true;
                panel2.Visible = false;
                plan = "Single Service";
            }
            else
            {
                panel1.Visible = false;
                panel3.Visible = true;
                panel2.Visible = true;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                plan = "Recurring Service";
            }
        }

        //Daily Service
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox6.Visible = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                if (checkBox1.Checked){
                    groupBox7.Visible = false;
                    groupBox6.Visible = false;
                    groupBox8.Visible = true;
                }else{
                    groupBox8.Visible = false;
                }
            }
        }

        //Weekly Service
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                if (checkBox2.Checked)
                {
                    groupBox6.Visible = false;
                    groupBox8.Visible = false;
                    groupBox7.Visible = true;
                }
                else
                {
                    groupBox7.Visible = false;
                }
            }
        }

        //Bi-Weekly Service
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                if (checkBox3.Checked)
                {
                    groupBox6.Visible = false;
                    groupBox8.Visible = false;
                    groupBox7.Visible = true;
                }
                else
                {
                    groupBox7.Visible = false;
                }
            }
                
        }

        //Monthly Service
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                if (checkBox4.Checked)
                {
                    groupBox7.Visible = false;
                    groupBox8.Visible = false;
                    groupBox6.Visible = true;
                }
                else
                {
                    groupBox6.Visible = false;
                }               
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Date and Time 
            string a = "Single Service";
            string b = comboBox1.SelectedItem.ToString();
            bool Sservice = a == b;

            if (Sservice)
            {
                dateTime = dateTimePicker1.Text;
                timeDate = comboBox11.Text;
            }
            else
            {
                //Daily Date and Time
                if (checkBox1.Checked)
                {
                    timeDate = comboBox10.Text;
                    service = "Daily";
                }

                //Weekly Date and Time
                if (checkBox2.Checked)
                {
                    service = "Weekly";
                    if (checkBox11.Checked)
                    {
                        monday = "Monday";
                        time1 = comboBox3.Text;
                    }
                    if (checkBox12.Checked)
                    {
                        tuesday = "Tuesday";
                        time2 = comboBox4.Text;
                    }
                    if (checkBox13.Checked)
                    {
                        wednesday = "Wednesday";
                        time3 = comboBox5.Text;
                    }
                    if (checkBox14.Checked)
                    {
                        thursday = "Thursday";
                        time4 = comboBox6.Text;
                    }
                    if (checkBox15.Checked)
                    {
                        friday = "Friday";
                        time5 = comboBox7.Text;
                    }
                    if (checkBox16.Checked)
                    {
                        saturday = "Saturday";
                        time6 = comboBox8.Text;
                    }
                    if (checkBox17.Checked)
                    {
                        sunday = "Sunday";
                        time7 = comboBox9.Text;
                    }
                    dateTime = dateTimePicker3.Text;
                }

                //Bi-Weekly Date and Time
                if (checkBox3.Checked)
                {
                    service = "Bi-Weekly";
                    if (checkBox11.Checked)
                    {
                        monday = "Monday";
                        time1 = comboBox3.Text;
                    }
                    if (checkBox12.Checked)
                    {
                        tuesday = "Tuesday";
                        time2 = comboBox4.Text;
                    }
                    if (checkBox13.Checked)
                    {
                        wednesday = "Wednesday";
                        time3 = comboBox5.Text;
                    }
                    if (checkBox14.Checked)
                    {
                        thursday = "Thursday";
                        time4 = comboBox6.Text;
                    }
                    if (checkBox15.Checked)
                    {
                        friday = "Friday";
                        time5 = comboBox7.Text;
                    }
                    if (checkBox16.Checked)
                    {
                        saturday = "Saturday";
                        time6 = comboBox8.Text;
                    }
                    if (checkBox17.Checked)
                    {
                        sunday = "Sunday";
                        time7 = comboBox9.Text;
                    }
                    dateTime = dateTimePicker3.Text;
                }

                //Monthly Date and Time
                if (checkBox4.Checked)
                {
                    dateTime = dateTimePicker2.Text;
                    timeDate = comboBox2.Text;
                    service = "Monthly";
                }
            }
            //Cost Price
            if (checkBox7.Checked)  //Covid-Recurring
            {
                string g = "Business";
                string f = Form1.business.ToString();
                bool Pearls = f == g;
                if (Pearls)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);

                    if (5 <= rooms && 25 <= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 32;
                    }

                    if (5 <= rooms && 25 >= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 30;
                    }

                    if (5 >= rooms && 25 <= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 28;
                    }

                    if (5 >= rooms && 25 >= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 26;
                    }
                }
                else
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);

                    if (5 <= rooms && 25 <= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 22;
                    }

                    if (5 <= rooms && 25 >= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 20;
                    }

                    if (5 >= rooms && 25 <= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 18;
                    }

                    if (5 >= rooms && 25 >= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 16;
                    }
                }
            }

            if (checkBox6.Checked)  //Exterior-Recurring
            {
                string k = "Business";
                string l = Form1.business.ToString();
                bool Ragz = k == l;
                if (Ragz)
                {
                    panel3.Visible = false;
                    sum1 = 2000;
                }
                else
                {
                    panel3.Visible = false;
                    sum1 = 1000;
                }
            }

            if (checkBox5.Checked)  //Interior-Recurring
            {
                rooms = int.Parse(textBox1.Text);
                area = int.Parse(textBox2.Text);

                if (5 <= rooms && 25 <= area)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);
                    sum1 = rooms * area * 22;
                }

                if (5 <= rooms && 25 >= area)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);
                    sum1 = rooms * area * 20;
                }

                if (5 >= rooms && 25 <= area)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);
                    sum1 = rooms * area * 18;
                }

                if (5 >= rooms && 25 >= area)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);
                    sum1 = rooms * area * 16;
                }
            }

            if (checkBox8.Checked)  //Covid-Single
            {
                string g = "Business";
                string f = Form1.business.ToString();
                bool Pearls = f == g;
                if (Pearls)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);

                    if (5 <= rooms && 25 <= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 32;
                    }

                    if (5 <= rooms && 25 >= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 30;
                    }

                    if (5 >= rooms && 25 <= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 28;
                    }

                    if (5 >= rooms && 25 >= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 26;
                    }
                }
                else
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);

                    if (5 <= rooms && 25 <= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 22;
                    }

                    if (5 <= rooms && 25 >= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 20;
                    }

                    if (5 >= rooms && 25 <= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 18;
                    }

                    if (5 >= rooms && 25 >= area)
                    {
                        rooms = int.Parse(textBox1.Text);
                        area = int.Parse(textBox2.Text);
                        sum1 = rooms * area * 16;
                    }
                }
            }

            if (checkBox9.Checked)  //Exterior-Single
            {
                string k = "Business";
                string l = Form1.business.ToString();
                bool Ragz = k == l;
                if (Ragz)
                {
                    panel3.Visible = false;
                    sum1 = 2000;
                }
                else
                {
                    panel3.Visible = false;
                    sum1 = 1000;
                }
            }

            if (checkBox10.Checked) //Interior-Single
            {
                rooms = int.Parse(textBox1.Text);
                area = int.Parse(textBox2.Text);

                if (5 <= rooms && 25 <= area)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);
                    sum1 = rooms * area * 22;
                }

                if (5 <= rooms && 25 >= area)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);
                    sum1 = rooms * area * 20;
                }

                if (5 >= rooms && 25 <= area)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);
                    sum1 = rooms * area * 18;
                }

                if (5 >= rooms && 25 >= area)
                {
                    rooms = int.Parse(textBox1.Text);
                    area = int.Parse(textBox2.Text);
                    sum1 = rooms * area * 16;
                }
            }

            //Continues to Form4 when button is clicked
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        //Closes Form2 when cancel button is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }
