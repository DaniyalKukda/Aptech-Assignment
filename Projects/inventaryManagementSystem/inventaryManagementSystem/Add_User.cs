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
using System.Text.RegularExpressions;

namespace inventaryManagementSystem
{
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadGridView()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from signup", Connection1.Con);
            sda.Fill(ds, "signup");
            DataGridView.DataSource = ds.Tables["signup"];
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            LoadGridView();
        }

        private void ButtonAdduser_Click(object sender, EventArgs e)
        {
            
        

        }

        private void ButtonAdduser_Click_1(object sender, EventArgs e)
        {
            
            try
            {
              
                string FullName = textBoxAddName.Text;
                string Email = textBoxEmail.Text;
                string Password = textBoxPassword.Text;
                string Contact = textBoxContact.Text;
                string Gender = "Male";
                if (bunifuRadioButton1.Checked)
                {
                    Gender = "Female";
                }
                string Address = richTextBox1.Text;
                Connection1.Con.Open();
                string query = "insert into signup(fullName,Email,Pasword,Contact,Gender,adrs)values('"+FullName+"','"+Email+"','"+Password+"','"+Contact+"','"+Gender+"','"+Address+"')";
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                cmd.ExecuteNonQuery();
                Connection1.Con.Close();
                if (Connection1.Con.State == ConnectionState.Open)
                {
                    Connection1.Con.Close();
                }
                MessageBox.Show("Admin Has Been Added");
                LoadGridView();
                clear();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAddName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
             
            try
            {

                string FullName = textBoxAddName.Text;
                string Email = textBoxEmail.Text;
                string Password = textBoxPassword.Text;
                string Contact = textBoxContact.Text;
                string Gender = "Male";
                if (bunifuRadioButton1.Checked)
                {
                    Gender = "Female";
                }
                string Address = richTextBox1.Text;
                Connection1.Con.Open();
                string query = "update signup set fullName = '"+FullName+"',Email = '"+Email+"',Pasword = '"+Password+"',Contact = '"+Contact+"' where id = "+userID;
;
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                cmd.ExecuteNonQuery();
                Connection1.Con.Close();
                if (Connection1.Con.State == ConnectionState.Open)
                {
                    Connection1.Con.Close();
                }
                MessageBox.Show("Admin info Has Been Updated");
                LoadGridView();
                clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }
        int userID = 0;
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = DataGridView.Rows[e.RowIndex];
                userID = int.Parse(r.Cells["id"].Value.ToString());
                textBoxAddName.Text = r.Cells["fullName"].Value.ToString();
                textBoxEmail.Text = r.Cells["Email"].Value.ToString();
                textBoxPassword.Text = r.Cells["Pasword"].Value.ToString();
                textBoxContact.Text = r.Cells["Contact"].Value.ToString();
            }
        }
        private void clear()
        {
             textBoxAddName.Text = "";
             textBoxEmail.Text = "";
             textBoxPassword.Text = "";
             textBoxContact.Text = "";
            richTextBox1.Text = "";
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            try
            {

                Connection1.Con.Open();
                string query = "delete from signup where id = "+userID;
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                cmd.ExecuteNonQuery();
                Connection1.Con.Close();
                if (Connection1.Con.State == ConnectionState.Open)
                {
                    Connection1.Con.Close();
                }
                MessageBox.Show("Admin Has Been Removed");
                LoadGridView();
                clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }
    }
}
