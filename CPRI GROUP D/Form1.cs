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
    public partial class Form1 : Form
    {
        //Declaring strings to be used
        public static string name, surname, phone, email, business, address, town, postal;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Closes Form1 when cancel button is pressed
            this.Close();                                       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Registration of personal details
            name = textBox1.Text;
            surname = textBox2.Text;
            phone = textBox3.Text;
            email = textBox4.Text;
            //Registration of the physical address
              if (radioButton1.Checked)
            {
                business = "Business";
            } else {
                business = "Residential";
            }
            address = textBox5.Text;
            town = textBox6.Text;
            postal = textBox7.Text;
            //Continue to Form2
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
