using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public double UnitPrice { get; set; }
        public string AuthorName { get; set; }
        public int GenreID { get; set; }
        public bool IsDeleted { get; set; }

        public double DiscountAmount
        {
            get
            {
                return Math.Round((UnitPrice * Genre.Discount.DiscountPercentage) / 100, 2);
            }
        }
        public double UnitPriceAfterDiscount
        {
            get
            {
                return Math.Round((UnitPrice - (UnitPrice * Genre.Discount.DiscountPercentage) / 100), 2);
            }
        }

        public Genre Genre { get; set; }
    }
}
