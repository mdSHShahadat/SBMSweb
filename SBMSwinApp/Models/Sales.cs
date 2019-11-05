using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int CustomerID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public double PaidAmount { get; set; }
        //view
        public string CustomerName { get; set; }

    }
}
