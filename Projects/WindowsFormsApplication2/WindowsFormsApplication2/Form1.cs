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
namespace WindowsFormsApplication2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        ball obj = new ball();

       public static SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-AVJFDNF;Initial Catalog=signup;User ID=sa;Password=123");


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            signup obj = new signup();
            this.Hide();
            obj.Show();
        }
    }
}
