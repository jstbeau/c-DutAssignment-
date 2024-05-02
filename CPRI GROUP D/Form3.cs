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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //Make panel1 invisible
            panel1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Displays panel1 when EFT option is selected
            string c = "EFT";
            string d = comboBox1.SelectedItem.ToString();
            bool Payment = c == d;

            if (Payment)
            {
                panel1.Visible = true;
                label9.Text = "Your Option has been saved.";
            }
            else
            {
                label9.Text = "Your Option has been saved.";
                panel1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Displays quoted text and closes the Form3
            MessageBox.Show("Thank you for doing business with Ever Clean Maintenance!!");
            this.Close();
        }
    }
}
