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
    public partial class Song : Form
    {
        public Song()
        {
            InitializeComponent();
        }
        void loadCombosinger()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from singer", DB.con);
            sda.Fill(ds, "singer");

            comboBoxSinger.DataSource = ds.Tables["singer"];
            comboBoxSinger.DisplayMember = "singerName";
            comboBoxSinger.ValueMember = "singerID";

        }
        void loadComboalbum(int id)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from album where signerID = "+id, DB.con);
            sda.Fill(ds, "album");

            comboBoxAlbum.DataSource = ds.Tables["album"];
            comboBoxAlbum.DisplayMember = "albumName";
            comboBoxAlbum.ValueMember = "albumID";

        }
        void cleardata()
        {
            textBoxAddSong.Clear();
        }
        void loadGridView()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from song", DB.con);
            sda.Fill(ds, "song");
            dataGridViewSong.DataSource = ds.Tables["song"];
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

        private void Song_Load(object sender, EventArgs e)
        {
            loadCombosinger();
            loadGridView();
        }

        private void comboBoxSinger_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            string songName = textBoxAddSong.Text;
            if (textBoxAddSong.Text == "")
            {
                textBoxAddSong.BackColor = Color.Pink;
                MessageBox.Show("Song Name is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddSong.Focus();
            }
            else
            {
                try
                {
                    DB.con.Open();
                    string query = "insert into song(albumID,songName) values('" + int.Parse(comboBoxAlbum.SelectedValue.ToString()) + "','" + songName + "')";
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
        int songID = 0;
        private void dataGridViewSong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridViewSong.Rows[e.RowIndex];
                songID = int.Parse(r.Cells["songID"].Value.ToString());
                textBoxAddSong.Text = r.Cells["songName"].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string songName = textBoxAddSong.Text;

            try
            {
                DB.con.Open();
                string query = "update song set albumID = '" + int.Parse(comboBoxAlbum.SelectedValue.ToString()) + "',songName = '" + songName + "'";
                SqlCommand cmd = new SqlCommand(query, DB.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has Been Updated......!");
                loadGridView();
                cleardata();
                DB.con.Close();
                textBoxAddSong.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void comboBoxSinger_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show("singer id is " + int.Parse(comboBoxSinger.SelectedValue.ToString()));
            loadComboalbum(int.Parse(comboBoxSinger.SelectedValue.ToString())); 
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
                string query = "delete from song where songID = '" + songID + "'";
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
            Form3 obj = new Form3();
            obj.Show();
        }

        private void dataGridViewSong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonADD.Hide();
        }

        private void buttonADD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAddSong_TextChanged(object sender, EventArgs e)
        {
            textBoxAddSong.BackColor = Color.White;
            buttonADD.Show();
        }
    }
}
