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
    public partial class addSinger : Form
    {
        public addSinger()
        {
            InitializeComponent();
        }
        void cleardata(){
            textBoxAddSinger.Clear();
        }
        void loadGridView(){
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from singer",DB.con);
            sda.Fill(ds,"singer");
            dataGridViewSinger.DataSource = ds.Tables["singer"];
        }
        


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string singerName = textBoxAddSinger.Text;

            try
            {
                DB.con.Open();
                string query = "update singer set singerName = '"+singerName+"' where singerID = '"+singerID+"'";
                SqlCommand cmd = new SqlCommand(query, DB.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has Been Updated......!");
                loadGridView();
                cleardata();
                DB.con.Close();
                textBoxAddSinger.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void addSinger_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void textBoxAddSinger_TextChanged(object sender, EventArgs e)
        {
           textBoxAddSinger.BackColor = Color.White;
           buttonADD.Show();
        }
        
        private void buttonADD_Click(object sender, EventArgs e)
        {
            string singerName = textBoxAddSinger.Text;
            if (textBoxAddSinger.Text == "")
            {
                textBoxAddSinger.BackColor = Color.Pink;
                MessageBox.Show("Singer Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddSinger.Focus();
            }
            else
            {
                try
                {
                    DB.con.Open();
                    string query = "insert into singer(singerName) values('" + singerName + "')";
                    SqlCommand cmd = new SqlCommand(query, DB.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has Been Inserted......!");
                    loadGridView();
                    cleardata();
                    DB.con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DB.con.Open();
                string query = "delete from singer where singerID = '"+singerID+"'";
                SqlCommand cmd = new SqlCommand(query, DB.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has Been Deleted......!");
                loadGridView();
                cleardata();
                DB.con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            SingerRPT obj = new SingerRPT();
            
            obj.Show();
        }

        private void dataGridViewSinger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonADD.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            this.Hide();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Home obj = new Home();
            this.Hide();
            obj.Show();
        }
        int singerID = 0;
        private void dataGridViewSinger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridViewSinger.Rows[e.RowIndex];
                singerID = int.Parse(r.Cells["singerID"].Value.ToString());
                textBoxAddSinger.Text = r.Cells["singerName"].Value.ToString();
            }
        }
    }
}
