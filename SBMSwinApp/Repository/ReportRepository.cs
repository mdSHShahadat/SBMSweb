using SBMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class ReportRepository
    {
        Connection connection;
        SqlCommand sqlCommand;
        SqlDataReader reader;

        public List<Report> GetAllReport()
        {
            List<Report> reports = new List<Report>();
            connection = new Connection();
            string query = @"Select * From ReportView ";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Report report  = new Report();
                report.ProductID = Convert.ToInt32(reader["ProductID"]);
                report.ProductCode = reader["ProductCode"].ToString();
                report.ProductName = reader["Product"].ToString();
                report.CategoryName = reader["Category"].ToString();
                report.PurchaseQuantity = Convert.ToInt32(reader["PurchasedQty"]);
                report.SoldQuantity = Convert.ToInt32(reader["SoldQty"]);
                report.AvailableQuantity= Convert.ToInt32(reader["AvailableQty"]);
                report.UnitPrice= Convert.ToDouble(reader["UnitPrice"]);
                report.MRP= Convert.ToDouble(reader["MRP"]);
                report.CostPrice = Convert.ToDouble(reader["CostPrice"]);
                report.SoldPrice= Convert.ToDouble(reader["SoldPrice"]);
                report.ProfitOnSales= Convert.ToDouble(reader["ProfitOnSales"]);
                report.ProfitOnPurchase= Convert.ToDouble(reader["ProfitOnPurchase"]);
                reports.Add(report);

            }
            connection.GetClose();
            return reports;
        }
        public List<Report> GetReportByDateForSales(Report qReport)
        {
            List<Report> reports = new List<Report>();
            connection = new Connection();
            string query = @"Select Code, Product, Category, SUM(IsNull(SoldQty,0)) as SoldQty, SUM(ISNULL(CostPrice,0)) as CP, SUM(ISNULL(PaidAmount,0)) as SalesPrice, SUM(ISNull(ProfitOnSales,0)) as Profit From ReportViewByDate Where PurchaseDate between '"+qReport.ToDate+ "' and '" + qReport.FromDate + "' or SalesDate between '" + qReport.ToDate + "' and '" + qReport.FromDate + "' Group By Code, Product, Category";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Report report = new Report();
                
                report.ProductCode = reader["Code"].ToString();
                report.ProductName = reader["Product"].ToString();
                report.CategoryName = reader["Category"].ToString();
                report.SoldQuantity = Convert.ToInt32(reader["SoldQty"]);
                report.CostPrice = Convert.ToDouble(reader["CP"]);
                report.SoldPrice = Convert.ToDouble(reader["SalesPrice"]);
                report.ProfitOnSales = Convert.ToDouble(reader["Profit"]);
                reports.Add(report);

            }
            connection.GetClose();
            return reports;
        }
        public List<Report> GetReportByDateForPurchase(Report qReport)
        {
            List<Report> reports = new List<Report>();
            connection = new Connection();
            //string query = @"Select Code, Product, Category, AvailableQty, SUM(CostPrice) as CP, MRP, SUM(ProfitOnPurchase) as ProfitOnPurchase 
	           //                 From TestReportViewByDate
	           //                 Where PurchaseDate between '" + qReport.ToDate + "' and '" + qReport.FromDate + "' or SalesDate between '" + qReport.ToDate + "' and '" + qReport.FromDate + "' Group By Code, Product, Category, MRP,AvailableQty ";

            string query = @"Select Code, Product, Category, AvailableQty, SUM(CostPrice) as CP, MRP, SUM(ProfitOnPurchase) as ProfitOnPurchase 
	                            From TestReportViewByDate
	                            Where PurchaseDate between '" + qReport.ToDate + "' and '" + qReport.FromDate + "'  Group By Code, Product, Category, MRP,AvailableQty ";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Report report = new Report();
                report.ProductCode = reader["Code"].ToString();
                report.ProductName = reader["Product"].ToString();
                report.CategoryName = reader["Category"].ToString();
                report.AvailableQuantity = Convert.ToInt32(reader["AvailableQty"]);
                report.MRP = Convert.ToDouble(reader["MRP"]);
                report.CostPrice = Convert.ToDouble(reader["CP"]);
                report.ProfitOnPurchase = Convert.ToDouble(reader["ProfitOnPurchase"]);
                reports.Add(report);

            }
            connection.GetClose();
            return reports;
        }
    }
}
