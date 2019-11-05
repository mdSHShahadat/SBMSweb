using SBMS.Models;
using SBMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.BLL
{
    public class StockManager
    {
        
        StockRepository stockRepository = new StockRepository();
        public int GetInBalance(Stock stock)
        {

            return stockRepository.GetInBalance(stock);
        }
        public int GetOutBalance(Stock stock)
        {

            return stockRepository.GetOutBalance(stock);
        }
        public int GetOpeningBalance(Stock stock)
        {

            return stockRepository.GetOpeningBalance(stock);
        }
        public int GetAvailableBalance(Stock stock)
        {
            
            return stockRepository.GetAvailableBalance(stock);
        }

        public List<Product> GetPurchasedProductNameList(string categoryName)
        {
            return stockRepository.GetPurchasedProductNameList(categoryName);
        }
    }
}
