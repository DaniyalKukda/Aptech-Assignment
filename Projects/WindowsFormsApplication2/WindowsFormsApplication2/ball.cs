using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    class ball
    {
        public void insertData(bean beanobj)
        {
            try
            {
                login.sqlcon.Open();
                string q = "insert into signup(fullname,email,pass,contact,gender,adres)values('" + beanobj.fullname + "','" + beanobj.emailgs + "','" + beanobj.passwordgs + "','" + beanobj.contactgs + "','" + beanobj.gendergs + "','" + beanobj.contactgs + "')";
                SqlCommand cmd = new SqlCommand(q,login.sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data Has inserted");
                login obj = new login();
                obj.Show();
                login.sqlcon.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
