using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public double DiscountPercentage { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
