using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int PurchaseQuantity { get; set; }
        public int SoldQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public double UnitPrice{ get; set; }
        public double MRP{ get; set; }
        public double CostPrice{ get; set; }
        public double SoldPrice{ get; set; }
        public double ProfitOnSales{ get; set; }
        public double ProfitOnPurchase{ get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }

    }
}
