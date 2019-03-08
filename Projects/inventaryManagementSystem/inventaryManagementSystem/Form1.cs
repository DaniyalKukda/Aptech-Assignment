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

namespace inventaryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Home hom = new Home();

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string Email = textBoxEmail.Text;
            string pass = textBoxPassword.Text;

            if (textBoxEmail.Text == "")
            {
                logics.ValidationMessage(textBoxEmail, "Email is Required....!");
                return;
            }
            if (textBoxEmail.Text == " ")
            {
                logics.ValidationMessage(textBoxEmail, "Email is Required....!");
                return;
            }
            if (textBoxPassword.Text == "")
            {
                logics.ValidationMessage(textBoxPassword, "Password is Required....!");
                return;
            }
            if (textBoxPassword.Text == " ")
            {
                logics.ValidationMessage(textBoxPassword, "Password is Required....!");
                return;
            }
            try
            {
                Connection1.Con.Open();
                string query = "select Email,Pasword from signup where Email = '" + Email + "' and pasword = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                SqlDataReader check = cmd.ExecuteReader();
                if (check.Read())
                {
                    MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK);
                    this.Hide();
                    hom.Show();
                }
                else
                {
                    textBoxEmail.Clear();
                    textBoxPassword.Clear();
                    pass = "";
                    MessageBox.Show("Invalid UserName or Password", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                Connection1.Con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuTextBox3_TextChange(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logics.checkCon();
            
        }
    }
}
