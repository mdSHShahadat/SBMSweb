using SBMS.Models;
using SBMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.BLL
{
    public class PurchaseManager
    {
        PurchaseRepository purchaseRepository = new PurchaseRepository();
        public bool InsertPurchase(Purchase purchase)
        {
            return purchaseRepository.InsertPurchase(purchase);
        }
        public Purchase GetIdbyInvoiceNo(Purchase purchase)
        {

            return purchaseRepository.GetIdbyInvoiceNo(purchase);

        }
        public bool InsertPurchaseDetails(Purchase purchase, PurchaseDetails purchaseDetails)
        {
            return purchaseRepository.InsertPurchaseDetails(purchase, purchaseDetails);

        }
        public int GetAvailableQuantity(int productId)
        {
            
            return purchaseRepository.GetAvailableQuantity(productId);
        }
        public double GetPreviousUnitPrice(int productId)
        {
            
            return purchaseRepository.GetPreviousUnitPrice(productId);
        }
        public double GetPreviousMRP(int productId)
        {

            return purchaseRepository.GetPreviousMRP(productId);
        }
        public string GetGeneratedPurchaseCode()
        {
            return purchaseRepository.GetGeneratedPurchaseCode();
        }
        public List<Purchase> PurchasesShortRecord()
        {
            
            return purchaseRepository.PurchasesShortRecord();
        }
        public List<PurchaseDetails> PurchasesDetailsRecord(int purchaseId)
        {

            return purchaseRepository.PurchasesDetailsRecord(purchaseId);
        }
        //public Purchase LoadLastPurchaseByPurchaseCode(string code)
        //{
        //    return purchaseRepository.LoadLastPurchaseByPurchaseCode(code);

        //}
        //public List<Purchase> SearchPurchase(Purchase aPurchase)
        //{
        //    return purchaseRepository.SearchPurchase(aPurchase);
        //}
        //public List<Purchase> ShowPurchase()
        //{
        //    return purchaseRepository.ShowPurchase();
        //}
        //public bool IsPurchaseExist(Purchase purchase)
        //{

        //    return purchaseRepository.IsPurchaseExist(purchase);
        //}
        //public List<Purchase> GetAvailableQuantityandMRP(int categoryID, int productID)
        //{
        //    return purchaseRepository.GetAvailableQuantityandMRP(categoryID, productID);

        //}
    }
}
