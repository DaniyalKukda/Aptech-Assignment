using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MusicCompany
{
    class DB
    {
      public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-AVJFDNF;Initial Catalog=musicCompany;User ID=sa;Password=123");


    }
}
