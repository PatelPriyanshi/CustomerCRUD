using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Customer_WCFService;

namespace Customer_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerService_Test.CustomerServiceClient Client = new CustomerService_Test.CustomerServiceClient();
            Console.WriteLine("Client calling the service...");
            Console.WriteLine("Enter the number for the service you want to use....");
            Console.WriteLine("1. AddCustomerRecord");
            Console.WriteLine("2. GetCustomerRecord");
            Console.WriteLine("3. UpdateCustomerRecord");
            Console.WriteLine("4. DeleteCustomerRecord");

            ChooseService(Client);
            
        }

        public static void ChooseService(CustomerService_Test.CustomerServiceClient Client)
        {
            string number = Console.ReadLine();
            int serviceNumber = Convert.ToInt32(number);

            switch (serviceNumber)
            {
                case 1:
                    AddCustomerRecord(Client);
                    break;
                case 2:
                    GetCustomerRecord(Client);
                    break;
                case 3:
                    UpdateCustomerRecord(Client);
                    break;
                case 4:
                    DeleteCustomerRecord(Client);
                    break;
                default:
                    Console.WriteLine("You choose nothing");
                    break;
            }
        }

        public static void AddCustomerRecord(CustomerService_Test.CustomerServiceClient Client)
        {
            Customer customer = new Customer();
            Console.WriteLine("Add new customer...");
            Console.WriteLine("Enter Customer Id :");
            customer.ID = Console.ReadLine();
            Console.WriteLine("Enter Customer Name :");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Email :");
            customer.Email = Console.ReadLine();
            Console.WriteLine("Enter Customer City :");
            customer.City = Console.ReadLine();
            string result = Client.AddCustomerRecord(customer);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void GetCustomerRecord(CustomerService_Test.CustomerServiceClient Client)
        {
            Customer customer = new Customer();
            //GetCustomerRecords method
            Console.WriteLine("Get customer details by Id:");
            Console.WriteLine("Enter Customer Id :");
            string customerID = Console.ReadLine();
            int ID = Convert.ToInt32(customerID);
            Console.WriteLine("calling GetCustomerRecords....");
            var ds = Client.GetCustomerRecords(ID);
            if (ds.Tables != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var records = ds.Tables[0].Rows[i].ItemArray;
                    customer.ID = records[0].ToString();
                    customer.Name = records[1].ToString();
                    customer.Email = records[2].ToString();
                    customer.City = records[3].ToString();
                }
            }
            Console.WriteLine("Customer ID is: " + customer.ID);
            Console.WriteLine("Customer Name is: " + customer.Name);
            Console.WriteLine("Customer Email is: " + customer.Email);
            Console.WriteLine("Customer City is: " + customer.City);
            Console.ReadLine();
        }

       
        public static void UpdateCustomerRecord(CustomerService_Test.CustomerServiceClient Client)
        {
            Customer customer = new Customer();
            Console.WriteLine("Update Customer...");
            Console.WriteLine("Enter Customer Id :");
            customer.ID = Console.ReadLine();
            Console.WriteLine("Enter Customer Name :");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Email :");
            customer.Email = Console.ReadLine();
            Console.WriteLine("Enter Customer City :");
            customer.City = Console.ReadLine();
            string result = Client.UpdateCustomerRecord(customer);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void DeleteCustomerRecord(CustomerService_Test.CustomerServiceClient Client)
        {
            Customer customer = new Customer();
            Console.WriteLine("Delete Customer...");
            Console.WriteLine("Enter Customer's Id that you want to delete:");
            customer.ID = Console.ReadLine();
            string result = Client.DeleteCustomerRecord(customer);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public class customer
        {
            string _customerID = "";
            string _name = "";
            string _email = "";
            string _city = "";

            public string ID
            {
                get { return _customerID; }
                set { _customerID = value; }
            }


            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }


            public string Email
            {
                get { return _email; }
                set { _email = value; }
            }


            public string City
            {
                get { return _city; }
                set { _city = value; }
            }
        }
    }
}
