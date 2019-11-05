using SBMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class ProductRepository
    {
        Connection connection;
        SqlCommand sqlCommand;
        SqlDataReader reader;

        public bool InsertProduct(Product product)
        {
            connection = new Connection();
            string query = @"INSERT INTO Products(Code,Name,ReorderLevel,Description,CategoryID) VALUES ('" + product.Code + "','" + product.Name + "','" + product.ReorderLevel + "','" + product.Description + "','" + product.CategoryID + "') ";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;

        }
        public bool UpdateProduct(Product product)
        {
            connection = new Connection();
            string query = @"Update Products Set Code='" + product.Code + "', Name='" + product.Name + "', ReorderLevel='"+product.ReorderLevel+ "',Description='" + product.Description + "',CategoryID='" + product.CategoryID + "' where ID='"+product.Id+"' ";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;
        }
        public List<Product> ShowProduct()
        {
            List<Product> products = new List<Product>();
            connection = new Connection();
            string query = @"SELECT * FROM ProductsView order by Code;";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = (int)(reader["Id"]);
                product.Code = reader["Code"].ToString();
                product.Name = reader["Name"].ToString();
                product.ReorderLevel =Convert.ToInt32(reader["ReorderLevel"]) ;
                product.Description = reader["Description"].ToString();
                product.CategoryID = Convert.ToInt32(reader["CategoryID"]) ;
                product.CategoryName = reader["CategoryName"].ToString();

                products.Add(product);

            }
            connection.GetClose();
            return products;
        }
        public List<Product> ShowProductById(int id)
        {
            List<Product> products = new List<Product>();
            connection = new Connection();
            string query = @"SELECT * FROM ProductsView where CategoryID='" + id+"';";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = (int)(reader["Id"]);
                product.Code = reader["Code"].ToString();
                product.Name = reader["Name"].ToString();
                product.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);
                product.Description = reader["Description"].ToString();
                product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                product.CategoryName = reader["CategoryName"].ToString();

                products.Add(product);

            }
            connection.GetClose();
            return products;
        }
        public List<Product> SearchProduct(Product aProduct)
        {
            List<Product> products = new List<Product>();
            connection = new Connection();
            string query = @"Select * From ProductsView where Name='" + aProduct.Name + "' or Code='" + aProduct.Code + "' or CategoryName='" + aProduct.CategoryName + "'";
            //string query = @"Select * From ProductsView where CategoryName='" + aProduct.CategoryName + "'";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = (int)(reader["Id"]);
                product.Code = reader["Code"].ToString();
                product.Name = reader["Name"].ToString();
                product.CategoryName = reader["CategoryName"].ToString();
                product.ReorderLevel =Convert.ToInt32(reader["ReorderLevel"]);
                product.Description = reader["Description"].ToString();
                products.Add(product);
            }
            connection.GetClose();
            return products;
        }
        public int IsProductExist(Product product)
        {
            int status = 0;
            connection = new Connection();
            string query = "Select * From Products Where Name='" + product.Name + "' OR Code='" + product.Code + "'";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            string productCode = product.Code.ToLower();
            string productName = product.Name.ToLower();
            while (reader.Read())
            {
                Product aProduct = new Product();
                aProduct.Id = (int)reader["Id"];
                aProduct.Name = reader["Name"].ToString().ToLower();
                aProduct.Code = reader["Code"].ToString().ToLower();
                if (product.ActionType == "Update")
                {
                    if (aProduct != null)
                    {
                        if (aProduct.Name == productName)
                        {
                            if (aProduct.Id == product.Id)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 2;
                                break;
                            }
                        }
                        else if (aProduct.Code == productCode)
                        {
                            if (aProduct.Id == product.Id)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 1;
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
                if (product.ActionType == "Insert")
                {
                    if (aProduct != null)
                    {
                        if (aProduct.Name == productName)
                        {

                            status = 2;
                            break;

                        }
                        else if (aProduct.Code == productCode)
                        {

                            status = 1;
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
        public Product SearchById(int id)
        {
           
            connection = new Connection();
            string query = "Select * From Products where ID='"+id+"'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            Product product = new Product();
            while (reader.Read())
            {
                product.Id = Convert.ToInt32(reader["Id"]);
                product.Code = reader["Code"].ToString();
                product.Name = reader["Name"].ToString();
                product.ReorderLevel = Convert.ToInt32( reader["ReorderLevel"]);
            }
            
            connection.GetClose();
            return product;
        }
    }
}
