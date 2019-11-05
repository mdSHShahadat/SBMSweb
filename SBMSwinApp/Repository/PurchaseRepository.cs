using SBMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository
{
    public class PurchaseRepository
    {
        Connection connection;
        SqlCommand sqlCommand;
        SqlDataReader reader;

        public bool InsertPurchase(Purchase purchase)
        {
            connection = new Connection();
            string queryforPurchase = @"INSERT INTO Purchases(Code,Date,InvoiceNo,SupplierID) VALUES ('" + purchase.Code + "','" + purchase.Date + "','" + purchase.InvoiceNo + "','" + purchase.SupplierID + "')";
            sqlCommand = new SqlCommand(queryforPurchase, connection.GetConnection());
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                return true;
            }
            connection.GetClose();
            return false;


        }
        public Purchase GetIdbyInvoiceNo(Purchase purchase)
        {
            var aPurchase = new Purchase();
            connection = new Connection();
            string query = @"Select * from Purchases where InvoiceNo='" + purchase.InvoiceNo + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                aPurchase = new Purchase();
                aPurchase.Id = Convert.ToInt32(reader["ID"]);              
            }
            return aPurchase;

        }
        public bool InsertPurchaseDetails(Purchase purchase, PurchaseDetails purchaseDetails)
        {
            connection = new Connection();
            string queryforPurchaseDetais = @"INSERT INTO PurchaseDetails(PurchaseID, ProductID,ManufactureDate,ExpireDate,Quantity,UnitPrice,MRP,Remark) VALUES ('" + purchase.Id + "','" + purchaseDetails.ProductID + "','" + purchaseDetails.ManufactureDate + "','" + purchaseDetails.ExpireDate + "','" + purchaseDetails.Quantity + "','" + purchaseDetails.UnitPrice + "','" + purchaseDetails.MRP + "','" + purchaseDetails.Remark + "')";
            sqlCommand = new SqlCommand(queryforPurchaseDetais, connection.GetConnection());
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
            int availableQuantity =0;
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
        public double GetPreviousUnitPrice(int productId)
        {
            double previousUnitPrice = 0;
            connection = new Connection();
            string query = @"Select * from PurchaseDetails where ProductId='" + productId + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                previousUnitPrice = Convert.ToInt32(reader["UnitPrice"]);
            }
            return previousUnitPrice;
        }
        public double GetPreviousMRP(int productId)
        {
            double previousMRP = 0;
            connection = new Connection();
            string query = @"Select * from PurchaseDetails where ProductId='" + productId + "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                previousMRP = Convert.ToInt32(reader["MRP"]);
            }
            return previousMRP;
        }
        public string GetGeneratedPurchaseCode()
        {
            string formatedCode = "";
            var currentYear = DateTime.Now.Year;
            connection = new Connection();
            string query = "Select Count(Code) from Purchases";
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
        public List<Purchase> PurchasesShortRecord()
        {
            List<Purchase> purchases = new List<Purchase>();
            connection = new Connection();
            string query = @"Select * From PurchaseShortRecord order by PurchaseCode";
            sqlCommand = new SqlCommand(query, connection.GetConnection());


            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Purchase purchase = new Purchase();
                purchase.Id = (int)(reader["ID"]);
                purchase.Code = reader["PurchaseCode"].ToString();
                purchase.Date = Convert.ToDateTime(reader["PurchaseDate"].ToString());
                purchase.InvoiceNo = reader["InvoiceNo"].ToString();
                purchase.SupplierName = reader["SupplierName"].ToString();
                purchase.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                purchases.Add(purchase);

            }
            connection.GetClose();
            return purchases;
        }
        public List<PurchaseDetails> PurchasesDetailsRecord(int purchaseId)
        {
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>();
            connection = new Connection();
            string query = @"Select * From PurchaseDetailsRecord  where PurchaseID='" + purchaseId+ "'";
            sqlCommand = new SqlCommand(query, connection.GetConnection());


            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                PurchaseDetails purchaseDetail = new PurchaseDetails();
                //purchaseDetail.PurchaseID = Convert.ToInt32(reader["ID"]);
                purchaseDetail.ProductName = reader["Name"].ToString();
                purchaseDetail.ProductCode = reader["Code"].ToString();
                purchaseDetail.ManufactureDate = Convert.ToDateTime(reader["ManufactureDate"].ToString());
                purchaseDetail.ExpireDate = Convert.ToDateTime(reader["ExpireDate"].ToString());
                purchaseDetail.Quantity = Convert.ToDouble(reader["Quantity"]);
                purchaseDetail.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                purchaseDetail.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);
                purchaseDetail.MRP = Convert.ToDouble(reader["MRP"]);
                purchaseDetail.Remark = reader["Remark"].ToString();
                purchaseDetails.Add(purchaseDetail);

            }
            connection.GetClose();
            return purchaseDetails;
        }
        //public Purchase LoadLastPurchaseByPurchaseCode(string code)
        //{
        //    var purchase = new Purchase();
        //    connection = new Connection();
        //    string query = @"Select * from Purchases where Code='"+code+"'";
        //    sqlCommand = new SqlCommand(query, connection.GetConnection());
        //    reader = sqlCommand.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        purchase = new Purchase();
        //        //purchase.ManufactureDate = Convert.ToDateTime(reader["ManufacturedDate"]);
        //        //purchase.ExpireDate = Convert.ToDateTime(reader["ExpiredDate"]);
        //        purchase.Quantity =Convert.ToInt32(reader["Quantity"]);
        //        purchase.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
        //        purchase.MRP = Convert.ToInt32(reader["MRP"]);
        //        purchase.Remark = reader["Remark"].ToString();
        //    }
        //    return purchase;           
        //}      
        //public List<Purchase> SearchPurchase(Purchase aPurchase)
        //{
        //    List<Purchase> purchases = new List<Purchase>();
        //    connection = new Connection();
        //    string query = @"Select * From Purchases where ProductCode='" + aPurchase.ProductCode + "' or Date='"+aPurchase.Date+"'";
        //    sqlCommand = new SqlCommand(query, connection.GetConnection());
        //    reader = sqlCommand.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Purchase purchase = new Purchase();
        //        purchase.Id = (int)(reader["Id"]);
        //        purchase.Code = reader["Code"].ToString();
        //        purchase.Date =Convert.ToDateTime( reader["Date"]);
        //        purchase.InvoiceNo = reader["InvoiceNo"].ToString();
        //        purchase.SupplierID =Convert.ToInt32( reader["SupplierID"]);
        //        purchase.CategoryID =Convert.ToInt32( reader["CategoryID"]);
        //        purchase.ProductID =Convert.ToInt32( reader["ProductID"]);
        //        purchase.ProductCode = Convert.ToString(reader["ProductCode"]);
        //        purchase.ManufactureDate = reader.GetDateTime(8);
        //        purchase.ExpireDate = reader.GetDateTime(9);
        //        purchase.Remark= reader["Remark"].ToString();
        //        purchase.Quantity = Convert.ToDouble(reader["Quantity"]);
        //        purchase.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
        //        purchase.MRP= Convert.ToDouble(reader["MRP"]);
        //        purchase.TotalPrice= Convert.ToDouble(reader["TotalPrice"]);

        //        purchases.Add(purchase);

        //    }
        //    connection.GetClose();
        //    return purchases;
        //}
        //public List<Purchase> ShowPurchase()
        //{
        //    List<Purchase> purchases = new List<Purchase>();
        //    connection = new Connection();
        //    string query = @"Select * From Purchases ";
        //    sqlCommand = new SqlCommand(query, connection.GetConnection());
        //    reader = sqlCommand.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Purchase purchase = new Purchase();
        //        purchase.Id = (int)(reader["Id"]);
        //        purchase.Code = reader["Code"].ToString();
        //        purchase.Date = Convert.ToDateTime(reader["Date"]);
        //        purchase.InvoiceNo = reader["InvoiceNo"].ToString();
        //        purchase.SupplierID = Convert.ToInt32(reader["SupplierID"]);
        //        //purchase.CategoryID = Convert.ToInt32(reader["CategoryID"]);
        //        purchase.ProductID = Convert.ToInt32(reader["ProductID"]);
        //        purchase.ProductCode = Convert.ToString(reader["ProductCode"]);
        //        purchase.ManufactureDate = reader.GetDateTime(8);
        //        purchase.ExpireDate = reader.GetDateTime(9);
        //        purchase.Remark = reader["Remark"].ToString();
        //        purchase.Quantity = Convert.ToDouble(reader["Quantity"]);
        //        purchase.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
        //        purchase.MRP = Convert.ToDouble(reader["MRP"]);
        //        purchase.TotalPrice = Convert.ToDouble(reader["TotalPrice"]);

        //        purchases.Add(purchase);

        //    }
        //    connection.GetClose();
        //    return purchases;
        //}
        //public bool IsPurchaseExist(Purchase purchase)
        //{
        //    bool status = false;
        //    connection = new Connection();
        //    string query = "Select * From Purchases";
        //    sqlCommand = new SqlCommand(query, connection.GetConnection());
        //    reader = sqlCommand.ExecuteReader();
        //    string purchaseInvoiceNo = purchase.InvoiceNo.ToLower();
        //    while (reader.Read())
        //    {
        //        string readerInvoiceNo = reader["InvoiceNo"].ToString().ToLower();

        //        if (purchaseInvoiceNo == readerInvoiceNo)
        //        {
        //            status = true;
        //            break;
        //        }

        //    }
        //    connection.GetClose();
        //    return status;
        //}
        //public List<Purchase> GetAvailableQuantityandMRP(int categoryID, int productID)
        //{
        //    var purchase = new Purchase();
        //    var purchases = new List<Purchase>();

        //    connection = new Connection();
        //    string query = @"Select * From Purchases where CategoryID='" + categoryID+"' and ProductID='"+productID+"'";
        //    sqlCommand = new SqlCommand(query, connection.GetConnection());
        //    reader = sqlCommand.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        purchase = new Purchase();
        //        purchase.ProductID = Convert.ToInt32(reader["ProductID"]);
        //        purchase.Quantity = Convert.ToDouble(reader["Quantity"]);
        //        purchase.MRP = Convert.ToDouble(reader["MRP"]);

        //        purchases.Add(purchase);
        //    }
        //    return purchases;

        //}

    }
    }
