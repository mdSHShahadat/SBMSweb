using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SBMS.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string InvoiceNo { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public double TotalPrice { get; set; }


    }
}
