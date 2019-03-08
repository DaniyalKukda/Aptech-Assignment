using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Services_dbo;User ID=sa;Password=123");

        public string insertData(Student obj)
        {
                string msg = "";
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into student_info values s_name = '" + obj.sname + "', s_father = '" + obj.sfather + "' , s_roll = " + obj.sroll + " , s_course = '" + obj.scourse + "' , s_age = " + obj.age + " ");
                int k = cmd.ExecuteNonQuery();
                if (k > 0)
                {
                    msg = obj.sname + "Your data has been inserted.....";
                }
                con.Close();
                return msg;
        }

        public List<Student> GetData()
        {
            List<Student> li = new List<Student>();

            SqlCommand select = new SqlCommand("select * from student_info", con);
            con.Open();
            SqlDataReader dr = select.ExecuteReader();
            while (dr.Read())
            {
                Student std = new Student();

                std.id = Convert.ToInt32(dr[0]);
                std.sname = dr[1].ToString();
                std.sfather = dr[2].ToString();
                std.sroll = Convert.ToInt32(dr[3]);
                std.scourse = dr[4].ToString();
                std.age = Convert.ToInt32(dr[5]);

                li.Add(std);
            }
            con.Close();
            return li;
        }
        
    }
}
