using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicCompany
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public void clearData()
        {
            textBoxEmail.Clear();
            textBoxName.Clear();
            textBoxPassword.Clear();
            comboBoxType.Text = " ";
            maskedTextBoxContact.Clear();
            richTextBoxAddress.Clear();

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            this.Hide();
            obj.Show();
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.DodgerBlue;
            buttonBack.ForeColor = Color.White;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.White;
            buttonBack.ForeColor = Color.Black;
        }

        private void buttonSignUp_MouseEnter(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = Color.DodgerBlue;
            buttonSignUp.ForeColor = Color.White;
        }

        private void buttonSignUp_MouseLeave(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = Color.White;
            buttonSignUp.ForeColor = Color.Black;
        }
        

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string type = comboBoxType.Text;
            string fullName = textBoxName.Text;
            string Email = textBoxEmail.Text;
            string Pass = textBoxPassword.Text;
            string Contact = maskedTextBoxContact.Text;
            string Gender = "";
            if (radiobuttonMale.Checked)
            {
                Gender = "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                Gender = "Female";
            }
            string address = richTextBoxAddress.Text;

            if (comboBoxType.Text == "")
            {
                ValidationMessage(comboBoxType, "Select Type is Required....!");
                return;
            }
            if (textBoxName.Text == "")
            {
                ValidationMessage(textBoxName, "Full Name is Required....!");
                return;
            }
            if (textBoxEmail.Text == "")
            {
                ValidationMessage(textBoxEmail, "Email is Required....!");
                return;
            }
            if (textBoxPassword.Text == "")
            {
                ValidationMessage(textBoxPassword, "Password is Required....!");
                return;
            }
            if (maskedTextBoxContact.Text == "")
            {
                ValidationMessage(maskedTextBoxContact, "Contact is Required....!");
                return;
            }
            if (Gender == "" )
            {
                ValidationMessage(radiobuttonMale, "Gender is Required....!");
                return;
            }
            if (richTextBoxAddress.Text == "")
            {
                ValidationMessage(richTextBoxAddress, "Address is Required....!");
                return;
            }
           
                try
            {
                DB.con.Open();
                string query = "insert into signup(adminType,fullName,Email,Pass,Contact,Gender,Addres) values ('"+type+"','"+fullName+"','"+Email+"','"+Pass+"','"+Contact+"','"+Gender+"','" + address + "')";
                SqlCommand cmd = new SqlCommand(query, DB.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You Have Been SignUp Now Login and Continue.......!");
                clearData();
                this.Hide();
                LoginForm obj = new LoginForm();
                this.Hide();
                obj.Show();
                DB.con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }
        private void ValidationMessage(Control ctrl, string ValidationMessage)
        {
            ctrl.BackColor = Color.Pink;
            MessageBox.Show(ValidationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrl.Focus();
        }

        private void ctrl_TextChange(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }  

    }
}
