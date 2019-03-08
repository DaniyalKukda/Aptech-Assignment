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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void cleardata()
        {
            textBoxPassword.Clear();
            textBoxEmail.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = comboBoxType.Text;
            string email = textBoxEmail.Text;
            string pass = textBoxPassword.Text;

            if (comboBoxType.Text == "")
            {
                ValidationMessage(comboBoxType, "Select Type is Required....!");
                return;
            }
            if (textBoxEmail.Text == "")
            {
                ValidationMessage(textBoxEmail, "Email is Required....!");
                return;
            }
            if (textBoxPassword.Text == "")
            {
                ValidationMessage(textBoxPassword,"Password is Required....!");
                return;
            }
            
            try
            {
                DB.con.Open();
                string query = "select adminType,Email,Pass from signup where adminType = '" + type + "' and Email = '" + email + "' and Pass = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, DB.con);
                SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        MessageBox.Show("Login Succseecfully.......!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Home obj = new Home();
                        this.Hide();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName OR Password.....!","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                
                    cleardata();
                    DB.con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);

            }
        }

        private void ValidationMessage(Control ctrl , string ValidationMessage)
        {
            ctrl.BackColor = Color.Wheat;
            MessageBox.Show( ValidationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrl.Focus();
        }  
        
        
        

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp obj = new SignUp();
            this.Hide();
            obj.Show();
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.Black;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.Gray;
        }

        private void buttonSignUp_MouseEnter(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = Color.Black;
        }

        private void buttonSignUp_MouseLeave(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = Color.Gray;
        }

        private void textBoxEmail_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ctrl_TextChange(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }
    }
}
