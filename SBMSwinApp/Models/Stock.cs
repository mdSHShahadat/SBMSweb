using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }              
        public int CategoryId { get; set; }       
        public DateTime LowestDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //forView
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int Reorderlevel { get; set; }
        
        public int OpeningBalance{ get; set; }
        public int In{ get; set; }
        public int Out{ get; set; }
        public int ClosingBalance{ get; set; }

    }
}
