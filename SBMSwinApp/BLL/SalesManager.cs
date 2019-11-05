using SBMS.Models;
using SBMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.BLL
{
    public class SalesManager
    {
        SalesRepository salesRepository = new SalesRepository();
        public bool InsertSales(Sales sales)
        {
            return salesRepository.InsertSales(sales);
        }
        public Sales GetIdbyCustomerID(Sales sales)
        {

            return salesRepository.GetIdbyCustomerID(sales);

        }
        public bool InsertPurchaseDetails(Sales sales, SalesDetails salesDetails)
        {
            
            return salesRepository.InsertPurchaseDetails(sales,salesDetails);

        }
        public int GetAvailableQuantity(int productId)
        {

            return salesRepository.GetAvailableQuantity(productId);
        }
        public string GetGeneratedSalesCode()
        {

            return salesRepository.GetGeneratedSalesCode();
        }
        public List<Sales> SalesShortRecord()
        {
            
            return salesRepository.SalesShortRecord();
        }
        public List<SalesDetails> PurchasesDetailsRecord(int salesId)
        {
           
            return salesRepository.PurchasesDetailsRecord(salesId);
        }
        //public Product GetProductByID(int id)
        //{
        //    //return salesRepository.GetProductByID(id);
        //}

    }
}
