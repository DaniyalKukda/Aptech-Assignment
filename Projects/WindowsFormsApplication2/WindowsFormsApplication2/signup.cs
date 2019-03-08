using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string fullname = textBoxfname.Text;
            string email = textBoxemail.Text;
            string pass = textBoxpassword.Text;
            string contact = maskedTextBoxcontact.Text;
            string gender = "";
            if(radioButton1.Checked){
                gender = "Male";
            }
            string address = richTextBoxaddress.Text;
            bean beanobj = new bean(fullname,email,pass,contact,gender,address);
        }
    }
}
