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
    public partial class Unit : Form
    {
        public Unit()
        {
            InitializeComponent();
        }
        private void Display()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from units", Connection1.Con);
            sda.Fill(ds, "units");
            bunifuCustomDataGrid1.DataSource = ds.Tables["units"];
         }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
            try
            {
                string unit = bunifuTextBoxunit.Text;
                Connection1.Con.Open();
                  
                      string query = "insert into units values('" + unit + "')";
                      SqlCommand cmd = new SqlCommand(query, Connection1.Con);
                      cmd.ExecuteNonQuery();
                      MessageBox.Show("unit Has Been Added");
                      Display();
                      bunifuTextBoxunit.Text = "";
               

                Connection1.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        int id = 0;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Connection1.Con.Open();
              
            
            string query = "delete from units where unitID = "+ id;
            SqlCommand cmd = new SqlCommand(query, Connection1.Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("unit Has Been Deleted");
            Display();
            Connection1.Con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = bunifuCustomDataGrid1.Rows[e.RowIndex];
                id = int.Parse(r.Cells["unitID"].Value.ToString());
            }
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
