using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string insertData(Student obj);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Student
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string sname { get; set; }

        [DataMember]
        public string sfather { get; set; }

        [DataMember]
        public int sroll { get; set; }

        [DataMember]
        public string scourse { get; set; }

        [DataMember]
        public int age { get; set; }

    }
}
