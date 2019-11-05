using SBMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class StockRepository
    {
        private Connection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader reader;
        
        
        private DateTime GetLowestDateOnPurchase()
        {
            DateTime lowestDate = new DateTime();
            connection = new Connection();
            string query = @"Select min(PurchaseDate) as PurchaseDate from PurchaseStockView";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lowestDate = Convert.ToDateTime(reader["PurchaseDate"]);
            }
            return lowestDate;
        }
        private DateTime GetLowestDateOnSales()
        {
            DateTime lowestDate = new DateTime();
            connection = new Connection();
            string query = @"Select min(SalesDate) as SalesDate from SalesStockView";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lowestDate = Convert.ToDateTime(reader["SalesDate"]);
            }
            return lowestDate;
        }

       public List<Product> GetPurchasedProductNameList(string categoryName)
        {
            List<Product> products = new List<Product>();
            connection = new Connection();
            string query = @"SELECT ProductID, pv.Code as Code, pv.ReorderLevel as ReorderLevel, ProductName  FROM PurchaseStockView Left outer join ProductsView as pv on ProductID=pv.ID where PurchaseStockView.CategoryName ='"+categoryName+ "' Group by ProductID, pv.Code,pv.ReorderLevel, ProductName;";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = (int)(reader["ProductID"]);
                product.Code = reader["Code"].ToString();
                product.Name = reader["ProductName"].ToString();
                product.ReorderLevel =(int) reader["ReorderLevel"];

                products.Add(product);

            }
            connection.GetClose();
            return products;
        }

        public int GetInBalance(Stock stock)
        {
            int inBalance = 0;
            if (stock.StartDate == null)
            {
                stock.StartDate = GetLowestDateOnPurchase();
            }

            connection = new Connection();

            string query = @"Select COALESCE(SUM(PurchaseQty),0) as PurchaseQty from PurchaseStockView where (ProductName='" + stock.ProductName + "') and (PurchaseDate between '" + stock.StartDate + "'and'" + stock.EndDate + "')";
            //string query = @"Select COALESCE(SUM(PurchaseQty),0) as PurchaseQty from PurchaseStockView where (CategoryName='" + stock.CategoryName + "') and (PurchaseDate between '" + stock.StartDate + "'and'" + stock.EndDate + "')";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                inBalance = Convert.ToInt32(reader["PurchaseQty"]);
            }
            return inBalance;
        }
        public int GetOutBalance(Stock stock)
        {
            int outBalance = 0;
            if (stock.StartDate == null)
            {
                stock.StartDate = GetLowestDateOnSales();
            }

            connection = new Connection();
            string query = @"Select COALESCE(SUM(SalesQty),0) as SalesQty from SalesStockView where (ProductName='" + stock.ProductName + "') and (SalesDate between '" + stock.StartDate + "'and'" + stock.EndDate + "')";
            //string query = @"Select COALESCE(SUM(SalesQty),0) as SalesQty from SalesStockView where (CategoryName='" + stock.CategoryName + "') and (SalesDate between '" + stock.StartDate + "'and'" + stock.EndDate + "')";

            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                //if (reader["SalesQty"] == null)
                //{
                //    outBalance = 0;
                //}
                //else {
                outBalance = Convert.ToInt32(reader["SalesQty"]);
                //}



            }
            return outBalance;
        }
        public int GetOpeningBalance(Stock stock)
        {
            int availableBalance = 0;           
            var st = new Stock();
            st.StartDate = GetLowestDateOnPurchase();
            st.EndDate = stock.StartDate.AddDays(-1);
            st.ProductName = stock.ProductName;
            st.CategoryName = stock.CategoryName;
            availableBalance= availableBalance+( GetInBalance(st) - GetOutBalance(st));
            return availableBalance;
        }
        public int GetAvailableBalance(Stock stock)
        {
            int availableBalance = GetOpeningBalance(stock);
            int inBanlace = GetInBalance(stock);
            int outBalance = GetOutBalance(stock);
            return (availableBalance+inBanlace)-outBalance;
        }

    }
}
