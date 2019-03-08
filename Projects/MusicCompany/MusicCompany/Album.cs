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
    public partial class Album : Form
    {
        public Album()
        {
            InitializeComponent();
        }
        void loadCombo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from singer",DB.con);
            sda.Fill(ds, "singer");

            comboBoxSinger.DataSource = ds.Tables["singer"];
            comboBoxSinger.DisplayMember = "singerName";
            comboBoxSinger.ValueMember = "singerID";

        }
        void cleardata()
        {
             textBoxAddAlbum.Clear();
        }
        void loadGridView()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from album", DB.con);
            sda.Fill(ds, "album");
            dataGridViewAlbum.DataSource = ds.Tables["album"];
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignout_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            this.Hide();
            obj.Show();
        }

        private void Album_Load(object sender, EventArgs e)
        {
            loadCombo();
            loadGridView();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            string albumName = textBoxAddAlbum.Text;
            if (textBoxAddAlbum.Text == "")
            {
                textBoxAddAlbum.BackColor = Color.Pink;
                MessageBox.Show("Album Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddAlbum.Focus();
            }
            else
            {
                try
                {
                    DB.con.Open();
                    string query = "insert into album(signerID,albumName) values('" + int.Parse(comboBoxSinger.SelectedValue.ToString()) + "','" + albumName + "')";
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
        int albumID = 0;
        private void dataGridViewAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridViewAlbum.Rows[e.RowIndex];
                albumID = int.Parse(r.Cells["albumID"].Value.ToString());
                textBoxAddAlbum.Text = r.Cells["albumName"].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string albumName = textBoxAddAlbum.Text;

            try
            {
                DB.con.Open();
                string query = "update album set signerID = '" + int.Parse(comboBoxSinger.SelectedValue.ToString()) + "',albumName = '" + albumName + "' where albumID = '" + albumID + "'";
                SqlCommand cmd = new SqlCommand(query, DB.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has Been Updated......!");
                loadGridView();
                cleardata();
                DB.con.Close();
                textBoxAddAlbum.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DB.con.Open();
                string query = "delete from album where albumID = '" + albumID + "'";
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
            Form2 obj = new Form2();
            obj.Show();
        }

        private void dataGridViewAlbum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonADD.Hide();
        }

        private void textBoxAddAlbum_TextChanged(object sender, EventArgs e)
        {
            textBoxAddAlbum.BackColor = Color.White;
            buttonADD.Show();
        }
    }
}
