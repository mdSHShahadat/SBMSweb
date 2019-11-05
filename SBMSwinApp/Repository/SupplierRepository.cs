using SBMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class SupplierRepository
    {
        Connection connection;
        SqlCommand sqlCommand;
        SqlDataReader reader;

        public bool InsertSupplier(Supplier supplier)
        {
            connection = new Connection();
            string query = @"INSERT INTO Suppliers(Code,Name,Address,Email,Contact,ContactPerson) VALUES ('" + supplier.Code + "','" + supplier.Name + "','" + supplier.Address + "','" + supplier.Email+ "','" + supplier.Contact+ "','" + supplier.ContactPerson+ "') ";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;

        }
        public bool UpdateSupplier(Supplier supplier)
        {
            connection = new Connection();
            string query = @"Update Suppliers Set Code='" + supplier.Code + "', Name='" + supplier.Name+ "',Address='"+supplier.Address+"',Email='"+supplier.Email+"',Contact='"+supplier.Contact+"',ContactPerson='"+supplier.ContactPerson+ "' where ID='" + supplier.Id + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;
        }
        public List<Supplier> ShowSupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            connection = new Connection();
            string query = @"Select * From Suppliers";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Supplier supplier= new Supplier();
                supplier.Id = (int)(reader["Id"]);
                supplier.Code = reader["Code"].ToString();
                supplier.Name = reader["Name"].ToString();
                supplier.Address = reader["Address"].ToString();
                supplier.Email = reader["Email"].ToString();
                supplier.Contact = reader["Contact"].ToString();
                supplier.ContactPerson = reader["ContactPerson"].ToString();

                suppliers.Add(supplier);

            }
            connection.GetClose();
            return suppliers;
        }
        public List<Supplier> SearchSupplier(Supplier aSupplier)
        {
            List<Supplier> suppliers = new List<Supplier>();
            connection = new Connection();
            string query = @"Select * From Suppliers where Name='" + aSupplier.Name + "' or Contact='"+aSupplier.Contact+"' or Email='"+aSupplier.Email+"'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.Id = (int)(reader["Id"]);
                supplier.Code = reader["Code"].ToString();
                supplier.Name = reader["Name"].ToString();
                supplier.Address = reader["Address"].ToString();
                supplier.Email = reader["Email"].ToString();
                supplier.Contact = reader["Contact"].ToString();
                supplier.ContactPerson = reader["ContactPerson"].ToString();


                suppliers.Add(supplier);

            }
            connection.GetClose();
            return suppliers;
        }
        public int IsSupplierExist(Supplier supplier)
        {
            int status = 0;
            connection = new Connection();
            string query = "Select * From Suppliers Where Code='" + supplier.Code + "' OR Contact='" + supplier.Contact + "'OR Email='" + supplier.Email + "'";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            string supplierCode = supplier.Code.ToLower();
            string supplierContact = supplier.Contact.ToLower();
            string supplierEmail = supplier.Email.ToLower();
            while (reader.Read())
            {
                Supplier aSupplier = new Supplier();
                aSupplier.Id = (int)reader["Id"];
                aSupplier.Code = reader["Code"].ToString().ToLower();
                aSupplier.Contact = reader["Contact"].ToString().ToLower();
                aSupplier.Email = reader["Email"].ToString().ToLower();
                if (supplier.ActionType == "Update")
                {
                    if (aSupplier != null)
                    {
                        if (aSupplier.Code == supplierCode)
                        {
                            if (aSupplier.Id == supplier.Id)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 1;
                                break;
                            }
                        }
                        else if (aSupplier.Contact == supplierContact)
                        {
                            if (aSupplier.Id == supplier.Id)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 2;
                                break;
                            }
                        }
                        else if (aSupplier.Email == supplierEmail)
                        {
                            if (aSupplier.Id == supplier.Id)
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
                if (supplier.ActionType == "Insert")
                {
                    if (aSupplier != null)
                    {
                        if (aSupplier.Code == supplierCode)
                        {

                            status = 1;
                            break;

                        }
                        else if (aSupplier.Contact == supplierContact)
                        {

                            status = 2;
                            break;

                        }
                        else if (aSupplier.Email == supplierEmail)
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
    }
}
