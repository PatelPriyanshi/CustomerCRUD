using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Customer_WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        string AddCustomerRecord(Customer customer);

        [OperationContract]
        DataSet GetCustomerRecords(int customerId);

        [OperationContract]
        string DeleteCustomerRecord(Customer customer);

        [OperationContract]
        string UpdateCustomerRecord(Customer customer);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Customer
    {
        string _customerID = "";
        string _name = "";
        string _email = "";
        string _city = "";

        [DataMember]
        public string ID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
    }
}
