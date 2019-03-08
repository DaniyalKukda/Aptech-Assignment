using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class bean
    {
        private string fname;
        private string email;
        private string password;
        private string contact;
        private string gender;
        private string address;

        public bean(string fname, string email, string password, string contact, string gender, string address)
        {
            this.fname = fname;
            this.email = email;
            this.password = password;
            this.contact = contact;
            this.gender = gender;
            this.address = address;

        }

       
            public string fullname
            {
                get { return fname; }
                set{fname = value;}
            }
            public string emailgs
            {
                get { return email; }
                set { email = value; }
            }
            public string passwordgs
            {
                get { return password; }
                set { password = value; }
            }
            public string contactgs
            {
                get { return contact; }
                set { contact = value; }
            }
            public string gendergs
            {
                get { return gender; }
                set { gender = value; }
            }
            public string addressgs
            {
                get { return address; }
                set { address = value; }
            }

        
    }
}
