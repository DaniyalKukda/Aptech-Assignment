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
    public partial class Dealer : Form
    {
        public Dealer()
        {
            InitializeComponent();
        }
        //loadgridview function
        void loadGridView()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dealer_info", Connection1.Con);
            sda.Fill(ds, "dealer_info");
            bunifuCustomDataGridDealer.DataSource = ds.Tables["dealer_info"];
        }
        //clear text feild functon
        void clearData()
        {
            bunifuTextBoxName.Clear();
            bunifuTextBoxCompany.Clear();
            bunifuTextBoxContact.Clear();
            richTextBoxAdddrss.Clear();
        }
        //to minimized the window
        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //to close the window
        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextBoxContact_TextChange(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
        //to add dealer info
        private void add_Click(object sender, EventArgs e)
        {
            string name = bunifuTextBoxName.Text;
            string company = bunifuTextBoxCompany.Text;
            string contact = bunifuTextBoxContact.Text;
            string city = bunifuDropdownCity.Text;
            string address = richTextBoxAdddrss.Text;
            try
            {
                Connection1.Con.Open();
                string query = "insert into dealer_info values('"+name+"','"+company+"','"+contact+"','"+city+"','"+address+"')";
                SqlCommand cmd = new SqlCommand(query,Connection1.Con);
                cmd.ExecuteNonQuery();
                loadGridView();
                clearData();
                MessageBox.Show("Dealer Info is Inserted......!");
                Connection1.Con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }
        int DealerID = 0;
        // to select data from grid view
        private void bunifuCustomDataGridDealer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = bunifuCustomDataGridDealer.Rows[e.RowIndex];
                DealerID = int.Parse(r.Cells["dealerID"].Value.ToString());
               bunifuTextBoxName.Text = r.Cells["dealerName"].Value.ToString();
               bunifuTextBoxCompany.Text = r.Cells["companyName"].Value.ToString();
               bunifuTextBoxContact.Text = r.Cells["Contact"].Value.ToString();
               bunifuDropdownCity.Text = r.Cells["City"].Value.ToString();
               richTextBoxAdddrss.Text = r.Cells["Addres"].Value.ToString();
            }
            Update.Visible = true;
            Delete.Visible = true;
            add.Visible = false;
            linkLabel1.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dealer_Load(object sender, EventArgs e)
        {
            loadGridView();
            
        }
        //to delete dealer info
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection1.Con.Open();
                string query = "delete from dealer_info where dealerID = "+DealerID;
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                cmd.ExecuteNonQuery();
                loadGridView();
                clearData();
                MessageBox.Show("Dealer Has Been Removed......!");
                Connection1.Con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }
        //to update dealer info
        private void Update_Click(object sender, EventArgs e)
        {
            string name = bunifuTextBoxName.Text;
            string company = bunifuTextBoxCompany.Text;
            string contact = bunifuTextBoxContact.Text;
            string city = bunifuDropdownCity.Text;
            string address = richTextBoxAdddrss.Text;
            try
            {
                Connection1.Con.Open();
                string query = "update dealer_info set dealerName = '"+name+"', companyName = '"+company+"', Contact = '"+contact+"', City = '"+city+"', Addres = '"+address+"' where dealerID = "+DealerID;
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                cmd.ExecuteNonQuery();
                loadGridView();
                clearData();
                MessageBox.Show("Dealer Info is Updated......!");
                Connection1.Con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add.Visible = true;
            Update.Visible = false;
            Delete.Visible = false;
            linkLabel1.Visible = false;
        }
    }
}
