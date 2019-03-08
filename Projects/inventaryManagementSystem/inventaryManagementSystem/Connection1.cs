using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace inventaryManagementSystem
{
    class Connection1
    {
    public static SqlConnection Con = new SqlConnection("Data Source=DESKTOP-AVJFDNF;Initial Catalog=IMS;User ID=sa;Password=123");
    }
    class logics
    {
        public static void checkCon()
        {
            if (Connection1.Con.State == ConnectionState.Open)
            {
                Connection1.Con.Close();
            }
            
        }
        
        public static void ValidationMessage(Control ctrl, string ValidationMessage)
        {
            MessageBox.Show(ValidationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrl.Focus();
        }

    }
}
