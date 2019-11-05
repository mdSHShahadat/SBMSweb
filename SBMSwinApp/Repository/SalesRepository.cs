using SBMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class SalesRepository
    {
        Connection connection;
        SqlCommand sqlCommand;
        SqlDataReader reader;

        public bool InsertSales(Sales sales)
        {
            connection = new Connection();
            string querySales = @"INSERT INTO Sales(Code,Date,CustomerID,PaidAmount) VALUES ('" + sales.Code + "','" + sales.Date + "','" + sales.CustomerID + "','" + sales.PaidAmount + "')";
            sqlCommand = new SqlCommand(querySales, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;


        }
        public Sales GetIdbyCustomerID(Sales sales)
        {
            var aSales = new Sales();
            connection = new Connection();
            string query = @"Select * from Sales where CustomerID='" + sales.CustomerID + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                aSales = new Sales();
                aSales.Id = Convert.ToInt32(reader["ID"]);
            }
            return aSales;

        }
        public bool InsertPurchaseDetails(Sales sales, SalesDetails salesDetails)
        {
            connection = new Connection();
            string querySalesDetails = @"INSERT INTO SalesDetails(SalesID, ProductID,Quantity,MRP) VALUES ('" + sales.Id + "','" + salesDetails.ProductID + "','" + salesDetails.Quantity + "','" + salesDetails.MRP + "')";
            sqlCommand = new SqlCommand(querySalesDetails, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;

        }
        public int GetAvailableQuantity(int productId)
        {
            int availableQuantity = 0;
            connection = new Connection();
            string query = @"Select * from AvailableQty where ProductId='" + productId + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                availableQuantity = Convert.ToInt32(reader["AvlQty"]);
            }
            return availableQuantity;
        }
        public string GetGeneratedSalesCode()
        {
            string formatedCode = "";
            var currentYear = DateTime.Now.Year;
            connection = new Connection();
            string query = "Select Count(Code) from Sales";
            sqlCommand = new SqlCommand(query, connection.GetConnection());

            int row = Convert.ToInt32(sqlCommand.ExecuteScalar()) + 1;
            connection.GetClose();
            if (row > 0 && row < 10)
                formatedCode = currentYear.ToString() + "-" + "000" + row;
            if (row > 10 && row < 100)
                formatedCode = currentYear.ToString() + "-" + "00" + row;
            if (row > 100 && row < 1000)
                formatedCode = currentYear.ToString() + "-" + "0" + row;

            return formatedCode;
        }
        public List<Sales> SalesShortRecord()
        {
            List<Sales> sales = new List<Sales>();
            connection = new Connection();
            string query = @"Select * From SalesShortRecord order by SalesCode";
            sqlCommand = new SqlCommand(query, connection.GetConnection());


            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Sales sale = new Sales();
                sale.Id = (int)(reader["SalesID"]);
                sale.Code = reader["SalesCode"].ToString();
                sale.Date = Convert.ToDateTime(reader["SalesDate"].ToString());
                sale.CustomerName = reader["CustomerName"].ToString();
                sale.PaidAmount = Convert.ToDouble(reader["PaidAmount"]);
                sales.Add(sale);

            }
            connection.GetClose();
            return sales;
        }
        public List<SalesDetails> PurchasesDetailsRecord(int salesId)
        {
            List<SalesDetails> salesDetails = new List<SalesDetails>();
            connection = new Connection();
            string query = @"Select * From SalesDetailsRecord  where SalesID='" + salesId + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());


            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                SalesDetails salesDetail = new SalesDetails();
                //purchaseDetail.PurchaseID = Convert.ToInt32(reader["ID"]);
                salesDetail.ProductName = reader["ProductName"].ToString();
                salesDetail.CategoryName = reader["Category"].ToString();
                salesDetail.Quantity = Convert.ToDouble(reader["Quantity"]);
                salesDetail.MRP = Convert.ToDouble(reader["MRP"]);
                salesDetail.TotalMRP = Convert.ToDouble(reader["TotalMRP"]);
               
                salesDetails.Add(salesDetail);

            }
            connection.GetClose();
            return salesDetails;
        }
    }
}
