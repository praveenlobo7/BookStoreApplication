using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public double OrderAmount { get; set; }
        public double GST { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
    }
}
