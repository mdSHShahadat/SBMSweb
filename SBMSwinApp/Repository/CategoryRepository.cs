
using SBMS.Models;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class CategoryRepository
    {
        Connection connection;
        SqlCommand sqlCommand;
        SqlDataReader reader;
        
        public bool InsertCategory(Category category)
        {
            connection = new Connection();
            string query = @"INSERT INTO Categories(Code,Name) VALUES ('"+category.Code+ "','" + category.Name + "') ";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;
           
        }
        public bool UpdateCategory(Category category)
        {
            connection = new Connection();
            string query = @"Update Categories Set Code='" + category.Code + "', Name='" + category.Name + "' where ID='" + category.Id+"'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;
        }
        public List<Category> ShowCategory()
        {
            List<Category> categories= new List<Category>();
            connection = new Connection();
            string query = @"Select * From Categories order by Code";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            

            reader = sqlCommand.ExecuteReader();
            while (reader.Read()){
                Category category = new Category();
                category.Id = (int)(reader["Id"]);
                category.Code = reader["Code"].ToString();
                category.Name = reader["Name"].ToString();

                categories.Add(category);

            }
            connection.GetClose();
            return categories;
        }
        public List<Category> SearchCategory(Category aCategory)
        {
            List<Category> categories = new List<Category>();
            connection = new Connection();
            string query = @"Select * From Categories where (Code='"+aCategory.Code+ "' or Name='" + aCategory.Name + "')";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Category category = new Category();
                category.Id = (int)(reader["Id"]);
                category.Code = reader["Code"].ToString();
                category.Name = reader["Name"].ToString();

                categories.Add(category);

            }
            connection.GetClose();
            return categories;
        }
        public int IsCategoryExist(Category category)
        {
            int status = 0;
            connection = new Connection();
            string query = "Select * From Categories Where Name='" + category.Name + "' OR Code='" + category.Code + "'";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            string categoryCode = category.Code.ToLower();
            string categoryName = category.Name.ToLower();
            while (reader.Read())
            {
                Category aCategory = new Category();
                aCategory.Id = (int)reader["Id"];
                aCategory.Name = reader["Name"].ToString().ToLower();
                aCategory.Code = reader["Code"].ToString().ToLower();
                if (category.ActionType == "Update")
                {
                    if (aCategory != null)
                    {
                        if (aCategory.Name == categoryName)
                        {
                            if (aCategory.Id == category.Id)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 2;
                                break;
                            }
                        }
                        else if (aCategory.Code == categoryCode)
                        {
                            if (aCategory.Id == category.Id)
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
                if (category.ActionType == "Insert")
                {
                    if (aCategory != null)
                    {
                        if (aCategory.Name == categoryName)
                        {

                            status = 2;
                            break;

                        }
                        else if (aCategory.Code == categoryCode)
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



    }
}
