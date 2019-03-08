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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        //function to load product in combo box
        void loadCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Product", Connection1.Con);
            sda.Fill(ds, "Product");

            bunifuDropdownProduct.DataSource = ds.Tables["Product"];
            bunifuDropdownProduct.DisplayMember = "productName";
            bunifuDropdownProduct.ValueMember = "productUnit";
            
        }
        //function to load Dealer in combo box
        void loadComboDealer()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dealer_info", Connection1.Con);
            sda.Fill(ds, "dealer_info");

            bunifuDropdownDN.DataSource = ds.Tables["dealer_info"];
            bunifuDropdownDN.DisplayMember = "dealerName";
            bunifuDropdownDN.ValueMember = "dealerName";

        }
       

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            loadCombo();
            loadComboDealer();
            bunifuLabel8.Text = "Unit";
            
        }

        private void bunifuDropdownProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asign unit in label8
            bunifuLabel8.Text = bunifuDropdownProduct.SelectedValue.ToString();
        }

        private void bunifuTextBoxPrice_TextChange(object sender, EventArgs e)
        {
        }

        private void bunifuTextBoxPrice_Leave(object sender, EventArgs e)
        {
            //Assign total price of product by multiply price and quantity 
            bunifuTextBoxTotal.Text = Convert.ToString(Convert.ToInt32(bunifuTextBoxQty.Text) * Convert.ToInt32(bunifuTextBoxPrice.Text))+"  PKR";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string productName = bunifuDropdownProduct.Text;
            string qty = bunifuTextBoxQty.Text;
            string price = bunifuTextBoxPrice.Text;
            string total = bunifuTextBoxTotal.Text;
            string PD = bunifuDatePickerPD.Text;
            string DN = bunifuDropdownDN.Text;
            string PT = bunifuDropdownPT.Text;
            string ED = bunifuDatePickerED.Text;
            string profit = bunifuTextBoxProfit.Text;
            string unit = bunifuLabel8.Text;

            try
            {
                Connection1.Con.Open();
                int i = 0;
                //check and insert product in stock
                SqlCommand cmdt = Connection1.Con.CreateCommand();
                cmdt.CommandType = CommandType.Text;
                cmdt.CommandText = "select * from stock where product_Name = '" + productName + "'";
                cmdt.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmdt);
                sda.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    
                    string query = "insert into Purchase values ('" + productName + "','" + qty + "','"+unit+"','" + price + "','" + total + "','" + PD + "','" + DN + "','" + PT + "','" + ED + "','" + profit + "')";
                    SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                    cmd.ExecuteNonQuery();


                    string query1 = "insert into stock values ('" + productName + "','" + qty + "','" + unit + "')";
                    SqlCommand cmd4 = new SqlCommand(query1, Connection1.Con);
                    cmd4.ExecuteNonQuery();

                }
                else
                {
                    string query3 = "insert into Purchase values ('" + productName + "','" + qty + "','" + unit + "','" + price + "','" + total + "','" + PD + "','" + DN + "','" + PT + "','" + ED + "','" + profit + "')";
                    SqlCommand cm3 = new SqlCommand(query3, Connection1.Con);
                    cm3.ExecuteNonQuery();

                    string query5 = "update stock set product_qty += "+int.Parse(qty)+" where product_Name = '"+productName+"' ";
                    SqlCommand cmd5 = new SqlCommand(query5, Connection1.Con);
                    cmd5.ExecuteNonQuery();

                }
                MessageBox.Show("Record Inserted Succsessfully");
                Connection1.Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex);
            }
        }
    }
}
