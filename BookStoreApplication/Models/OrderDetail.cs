using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class OrderDetail
    {
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public Book Book { get; set; }

        public double BookPrice
        {
            get
            {
                return Quantity * Book.UnitPrice;
            }
        }

        public double BookDiscountPrice
        {
            get
            {
                return Quantity * Book.DiscountAmount;
            }
        }

        public double BookPriceAterDiscount
        {
            get
            {
                return Quantity * Book.UnitPriceAfterDiscount;
            }
        }
    }
}
