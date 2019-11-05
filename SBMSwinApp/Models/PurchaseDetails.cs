using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Models
{
   public class PurchaseDetails
    {
        public int Id { get; set; }
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; }
        public string Remark { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }
        //for view
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public double TotalPrice { get; set; }

    }
}
