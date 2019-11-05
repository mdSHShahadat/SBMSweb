using SBMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class CustomerRepository
    {
        Connection connection;
        SqlCommand sqlCommand;
        SqlDataReader reader;

        public bool InsertCustomer(Customer customer)
        {
            connection = new Connection();
            string query = @"INSERT INTO Customers(Code,Name,Address,Email,Contact,LoyaltyPoint) VALUES ('" + customer.Code + "','" + customer.Name + "','" + customer.Address + "','" + customer.Email + "','" + customer.Contact + "','" + customer.LoyaltyPoint + "') ";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;

        }
        public bool UpdateCustomer(Customer customer)
        {
            connection = new Connection();
            string query = @"Update Customers Set Code='" + customer.Code + "', Name='" + customer.Name + "', Address='" + customer.Address + "', Email='" + customer.Email + "', Contact='" + customer.Contact + "', LoyaltyPoint='" + customer.LoyaltyPoint + "' where ID='"+customer.Id+"'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;
        }
        public List<Customer> ShowCustomer()
        {
            List<Customer> customers = new List<Customer>();
            connection = new Connection();
            string query = @"Select * From Customers order by Code";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = (int)(reader["Id"]);
                customer.Code = reader["Code"].ToString();
                customer.Name = reader["Name"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.Email = reader["Email"].ToString();
                customer.Contact = reader["Contact"].ToString();
                customer.LoyaltyPoint =Convert.ToInt32(reader["LoyaltyPoint"]);

                customers.Add(customer);

            }
            connection.GetClose();
            return customers;
        }
        public List<Customer> SearchCustomer(Customer aCustomer)
        {
            List<Customer> customers = new List<Customer>();
            connection = new Connection();
            string query = @"Select * From Customers where Name='" + aCustomer.Name + "' or Contact='" + aCustomer.Contact + "' or Email='" + aCustomer.Email + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = (int)(reader["Id"]);
                customer.Code = reader["Code"].ToString();
                customer.Name = reader["Name"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.Email = reader["Email"].ToString();
                customer.Contact = reader["Contact"].ToString();
                customer.LoyaltyPoint =Convert.ToInt32( reader["LoyaltyPoint"]);


                customers.Add(customer);

            }
            connection.GetClose();
            return customers;
        }
        public Customer GetCustomerById(int id)
        {
            connection = new Connection();
            string query = "Select * From Customers where ID='" + id + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            Customer customer= new Customer();
            while (reader.Read())
            {
                customer.Id = Convert.ToInt32(reader["Id"]);
                customer.Code = reader["Code"].ToString();
                customer.Name = reader["Name"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.Contact = reader["Contact"].ToString();
                customer.Email = reader["Email"].ToString();
                customer.LoyaltyPoint = Convert.ToInt32(reader["LoyaltyPoint"]);
            }




            connection.GetClose();
            return customer;
        }
        public int IsCustomerExist(Customer customer)
        {
            int status = 0;
            connection = new Connection();
            string query = "Select * From Customers Where Code='" + customer.Code + "' OR Contact='" + customer.Contact + "'OR Email='" + customer.Email + "'";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            string customerCode = customer.Code.ToLower();
            string custoemrContact = customer.Contact.ToLower();
            string customerEmail = customer.Email.ToLower();
            while (reader.Read())
            {
                
                Customer aCustomer = new Customer();
                aCustomer.Id = (int)reader["Id"];
                aCustomer.Code = reader["Code"].ToString().ToLower();
                aCustomer.Contact = reader["Contact"].ToString().ToLower();
                aCustomer.Email = reader["Email"].ToString().ToLower();
                if (customer.ActionType == "Update")
                {
                    if (aCustomer != null)
                    {
                        if (aCustomer.Code == customerCode)
                        {
                            if (aCustomer.Id == customer.Id)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 1;
                                break;
                            }
                        }
                        else if (aCustomer.Contact == custoemrContact)
                        {
                            if (aCustomer.Id == customer.Id)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 2;
                                break;
                            }
                        }
                        else if (aCustomer.Email == customerEmail)
                        {
                            if (aCustomer.Id == customer.Id)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 3;
                                break;
                            }
                        }
                        else
                        {
                            status = 0;
                        }
                    }
                    else
                    {
                        status = 0;
                    }
                }
                if (customer.ActionType == "Insert")
                {
                    if (aCustomer != null)
                    {
                        if (aCustomer.Code == customerCode)
                        {

                            status = 1;
                            break;

                        }
                        else if (aCustomer.Contact == custoemrContact)
                        {

                            status = 2;
                            break;

                        }else if (aCustomer.Email == customerEmail)
                        {

                            status = 3;
                            break;

                        }
                        else
                        {
                            status = 0;
                        }
                    }
                    else
                    {
                        status = 0;
                    }
                }

            }
            connection.GetClose();

            return status;
        }
        public bool UpdateCustomerLoyaltyPoint(Customer customer)
        {
            connection = new Connection();
            string query = @"Update Customers Set LoyaltyPoint='" + customer.LoyaltyPoint + "' where ID='" + customer.Id + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;
        }
    }
}
