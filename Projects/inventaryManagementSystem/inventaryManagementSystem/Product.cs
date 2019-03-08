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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            panel2.Visible = false;
        }
        //Load Combo Box and GridView Funtions
       private void loadCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from units",Connection1.Con);
            sda.Fill(ds, "units");

            bunifuDropdownUnit.DataSource = ds.Tables["units"];
            bunifuDropdownUnit.DisplayMember = "unit";
            bunifuDropdownUnit.ValueMember = "unit";

        }
       void loadGridView()
       {
           DataSet ds = new DataSet();
           SqlDataAdapter sda = new SqlDataAdapter("select * from Product", Connection1.Con);
           sda.Fill(ds, "Product");
           bunifuCustomDataGridProduct.DataSource = ds.Tables["Product"];
       }
        //to minimiezed the window
        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBoxunit_TextChange(object sender, EventArgs e)
        {

        }
        //to add product
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            string product = bunifuTextBoxProduct.Text;
            
            try
            {
                Connection1.Con.Open();
                string query = "insert into Product(productName,productUnit)values('" + product +"','" + bunifuDropdownUnit.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has Been Inserted......!");
                loadGridView();
                bunifuTextBoxProduct.Text = "";
                Connection1.Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }
        // load comboBox and GridView Function Call on Form Load
        private void Product_Load(object sender, EventArgs e)
        {
            loadCombo();
            loadGridView();

           
        }
        //to Close the window
        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Cell Click Funtion to get data from gridview
        int productId = 0;
        private void bunifuCustomDataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = bunifuCustomDataGridProduct.Rows[e.RowIndex];
                productId = int.Parse(r.Cells["productID"].Value.ToString());
                bunifuTextBoxUp.Text = r.Cells["productName"].Value.ToString();
                bunifuDropdownup.Text = r.Cells["productUnit"].Value.ToString();
            }
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from units", Connection1.Con);
            sda.Fill(ds, "units");

            bunifuDropdownup.DataSource = ds.Tables["units"];
            bunifuDropdownup.DisplayMember = "unit";
            bunifuDropdownup.ValueMember = "unit";

        }
        //to update products
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string productup = bunifuTextBoxUp.Text;
            string unitup = bunifuDropdownup.Text;

            try
            {
                Connection1.Con.Open();
                string query = "update Product set productName = '" + productup + "',productUnit = '" + unitup + "' where productID = '" + productId + "'";
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has Been Updated......!");
                loadGridView();
                Connection1.Con.Close();
                bunifuTextBoxUp.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void Product_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Visible = false;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Connection1.Con.Open();
                string query = "delete from Product where productID = "+productId;
                SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has Been Removed......!");
                loadGridView();
                Connection1.Con.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }
    }
}
