using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Security.Cryptography;

namespace Customer_WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        public string AddCustomerRecord(Customer customer)
        {
            string result = "";
            try
            {

                SqlConnection con = new SqlConnection("Data Source=BRD-BKFJKM3-L;Initial Catalog=CustomerDb;User ID=tms;Password=password#1234;");
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO tblCustomer (ID,Name,Email,City)  
                                               Values(@ID,@Name,@Email,@City)";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ID", customer.ID);
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@City", customer.City);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }

            return result;
        }

        public DataSet GetCustomerRecords(int customerId)
        {
            DataSet ds = new DataSet();
            Customer customer = new Customer();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=BRD-BKFJKM3-L;Initial Catalog=CustomerDb;User ID=tms;Password=password#1234;");
                string Query = string.Format("SELECT * FROM tblCustomer Where ID='{0}'", customerId);

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }

        public string DeleteCustomerRecord(Customer customer)
        {
            string result = "";
            SqlConnection con = new SqlConnection("Data Source=BRD-BKFJKM3-L;Initial Catalog=CustomerDb;User ID=tms;Password=password#1234;");
            SqlCommand cmd = new SqlCommand();
            string Query = "DELETE FROM tblCustomer Where ID=@ID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ID", customer.ID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Record Deleted Successfully!";
            return result;
        }

        public string UpdateCustomerRecord(Customer customer)
        {
            string result = "";
            SqlConnection con = new SqlConnection("Data Source=BRD-BKFJKM3-L;Initial Catalog=CustomerDb;User ID=tms;Password=password#1234;");
            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE tblCustomer SET Name=@Name,Email=@Email,City=@City WHERE ID=@ID";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ID", customer.ID);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@City", customer.City);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                result = "Record Updated Successfully !";
            }
            catch (FaultException fex)
            {
                result = fex.Message;
            }           
            con.Close();

            return result;
        }
    }
}
