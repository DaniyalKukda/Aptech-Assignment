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
    public partial class Sale : Form
    {
        DataTable dt = new DataTable();
        int tot = 0;
        public Sale()
        {
            InitializeComponent();
        }
        void LOAD()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from TempData2", Connection1.Con);
            sda1.Fill(ds, "TempData2");
            bunifuCustomDataGridorder.DataSource = ds.Tables["TempData2"];
                    
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            logics.checkCon();
            LOAD();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuTextBoxProductName_KeyUp(object sender, KeyEventArgs e)
        {
            string product = bunifuTextBoxProductName.Text;
            Connection1.Con.Open();
            listBox1.Visible = true;
            listBox1.Items.Clear();

            SqlCommand cmd = Connection1.Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock where product_Name like('" + product + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["product_Name"].ToString());
            }
            Connection1.Con.Close();
        }

        private void bunifuTextBoxProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;

            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;
                }
                if (e.KeyCode == Keys.Up)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    bunifuTextBoxProductName.Text = listBox1.SelectedItem.ToString();
                    listBox1.Visible = false;
                    bunifuTextBoxPrice.Focus();
                }
            }
            catch (Exception x)
            {
                
                MessageBox.Show("Error"+x);
            }
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void bunifuTextBoxPrice_Enter(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            Connection1.Con.Open();
            SqlCommand cmd = Connection1.Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from Purchase where product_name = '" + bunifuTextBoxProductName.Text + "' order by id desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                bunifuTextBoxPrice.Text = dr["product_price"].ToString();
            }
            Connection1.Con.Close();
        }

        private void bunifuTextBoxQuantity_Leave(object sender, EventArgs e)
        {
            try
            {
                bunifuTextBoxTotal.Text = Convert.ToString(Convert.ToInt32(bunifuTextBoxPrice.Text) * Convert.ToInt32(bunifuTextBoxQuantity.Text));

            }
            catch (Exception r)
            {

                MessageBox.Show("error" + r);
            }
        }
        private void bunifuButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
            int stock = 0;
            Connection1.Con.Open();
            SqlCommand cmd = Connection1.Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock where product_Name = '" + bunifuTextBoxProductName.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["product_qty"].ToString());
            }
            if (Convert.ToInt32(bunifuTextBoxQuantity.Text) > stock)
            {
                MessageBox.Show("This Much Value is Not Available");

            }
            else
            {
                try
                {
                    
                    string query = "insert into TempData2 values ('" + bunifuTextBoxProductName.Text + "','" + bunifuTextBoxPrice.Text + "','" + bunifuTextBoxQuantity.Text + "','" + bunifuTextBoxTotal.Text + "')";
                    SqlCommand cmd5 = new SqlCommand(query, Connection1.Con);
                    cmd5.ExecuteNonQuery();
                    MessageBox.Show("Product is Added");
                    bunifuLabel13.Text = bunifuTextBoxTotal.Text;
                    LOAD();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);
                }

            }

            Connection1.Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuTextBoxProductName.Text = listBox1.Text;
        }

        private void bunifuTextBoxProductName_Leave(object sender, EventArgs e)
        {
            
        }
        string productd = "";

        

        private void bunifuCustomDataGridorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = bunifuCustomDataGridorder.Rows[e.RowIndex];
                tot = int.Parse(r.Cells["total"].Value.ToString());
                productd = r.Cells["id"].Value.ToString();
                bunifuLabel13.Text = tot.ToString();

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Connection1.Con.Open();
            string query = "delete from TempData2 where id = "+productd;
            SqlCommand cmd5 = new SqlCommand(query, Connection1.Con);
            cmd5.ExecuteNonQuery();
            MessageBox.Show("Product is Deleted from Sale");
            bunifuLabel13.Text = "0";
            LOAD();
            Connection1.Con.Close();
            
        }

  


        private void bunifuButton2_Click(object sender, EventArgs e)
        {
           string orderID = "";
           try
           {
               Connection1.Con.Open();
               string query = "insert into order_user1 values('" + bunifuTextBoxFName.Text + "','" + bunifuTextBoxLName.Text + "','" + bunifuDropdownBillType.Text + "','" + bunifuDatePickerBillDate.Text + "')";
               SqlCommand cmdou = new SqlCommand(query, Connection1.Con);
               cmdou.ExecuteNonQuery();

               SqlCommand cmd = Connection1.Con.CreateCommand();
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "select top 1 * from order_user1 order by orderID desc";
               cmd.ExecuteNonQuery();
               DataTable dt2 = new DataTable();
               SqlDataAdapter sda2 = new SqlDataAdapter(cmd);
               sda2.Fill(dt2);
               foreach (DataRow dr2 in dt2.Rows)
               {
                   orderID = dr2["orderID"].ToString();
               }
               for (int i = 0; i < bunifuCustomDataGridorder.Rows.Count; i++)
               {
                   string query2 = "insert into order_item1 values('" + orderID.ToString() + "','" + bunifuCustomDataGridorder.Rows[i].Cells[1].Value + "','" + bunifuCustomDataGridorder.Rows[i].Cells[2].Value + "','" + bunifuCustomDataGridorder.Rows[i].Cells[3].Value + "','" + bunifuCustomDataGridorder.Rows[i].Cells[4].Value + "')";
                   SqlCommand cmdit = new SqlCommand(query2, Connection1.Con);
                   cmdit.ExecuteNonQuery();

                   //int qty = Convert.ToInt32(bunifuCustomDataGridorder.Rows[i].Cells[3].Value.ToString());
                   //string pname = bunifuCustomDataGridorder.Rows[i].Cells[1].Value.ToString();

  
                   //SqlCommand scmd = Connection1.Con.CreateCommand();
                   //scmd.CommandType = CommandType.Text;
                   //scmd.CommandText = "update stock set product_qty = product_qty - " + qty + " where product_Name ='"+ pname.ToString()+"'";
                   //scmd.ExecuteNonQuery();

               }
               

                   MessageBox.Show("Product is Sold");
                   bill bil = new bill();
                   bil.Show();
             
             
               SqlCommand cmdT = new SqlCommand("truncate table TempData2", Connection1.Con);
               cmdT.ExecuteNonQuery();
               LOAD();

               Connection1.Con.Close();

           }
           catch (Exception ex)
           {

               MessageBox.Show("Error" + ex);
           }
        }

    }
}
