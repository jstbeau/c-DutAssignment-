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
    public partial class Form4 : Form
    {
        public static string service;
        public Form4()
        {
            InitializeComponent();
            panel1.Visible = false;
            //General Application Form
            label1.Text = "Name:                " + Form1.name;
            label2.Text = "Surname:             " + Form1.surname;
            label3.Text = "Phone:               " + Form1.phone;
            label4.Text = "Email:               " + Form1.email;
            label5.Text = "Property:            " + Form1.business;
            label6.Text = "Address Line:        " + Form1.address;
            label7.Text = "Town/City:           " + Form1.town;
            label8.Text = "Postal address:      " + Form1.postal;

            label9.Text = "Service Plan:                " + Form2.plan;
            label10.Text = "Cleaning Plan:      ";
            label11.Text = Form2.interior;

            //Single Service - Monthly Service
            label14.Text = "Date and Time of Services:          " + Form2.dateTime + " @ " + Form2.timeDate;
            label22.Text = "Service Period:             " + Form2.service;

            if (Form2.service == "Weekly")      //Displays the days picked and time selected on Weekly plan
            {
                panel1.Visible = true;
                label15.Text = Form2.monday + " " + Form2.time1;
                label16.Text = Form2.tuesday + " " + Form2.time2;
                label17.Text = Form2.wednesday + " " + Form2.time3;
                label18.Text = Form2.thursday + " " + Form2.time4;
                label19.Text = Form2.friday + " " + Form2.time5;
                label20.Text = Form2.saturday + " " + Form2.time6;
                label21.Text = Form2.sunday + " " + Form2.time7;
            }
            if (Form2.service == "Bi-Weekly")   //Displays the days picked and time selected on Bi-weekly plan
            {
                panel1.Visible = true;
                label15.Text = Form2.monday + " " + Form2.time1;
                label16.Text = Form2.tuesday + " " + Form2.time2;
                label17.Text = Form2.wednesday + " " + Form2.time3;
                label18.Text = Form2.thursday + " " + Form2.time4;
                label19.Text = Form2.friday + " " + Form2.time5;
                label20.Text = Form2.saturday + " " + Form2.time6;
                label21.Text = Form2.sunday + " " + Form2.time7;
            }
            //Displays information about costs of service
            label24.Text = "Number of rooms:            " + Form2.rooms;
            label25.Text = "Largest square meterage:    " + Form2.area + "m^(2)";
            label23.Text = "Cost of Service:            " + "R" + " " + Form2.sum1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Closes the form4 when the cancel button is pressed
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Continues to new form3
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Opens Form1 if an update is needed of the form
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
