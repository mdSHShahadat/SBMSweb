using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Models
{
    public class SalesDetails
    {
        public int Id { get; set; }
       public int SalesID { get; set; }
        public int ProductID { get; set; }       
        public double Quantity { get; set; }
        public double MRP { get; set; }
        
        //for view
        public int CustomerID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public double LoyaltyPoint { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public double TotalMRP { get; set; }
    }
}
