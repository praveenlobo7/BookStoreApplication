using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public bool IsDeleted { get; set; }
        public int DiscountID { get; set; }
        public ICollection<Book> Books { get; set; }
        public Discount Discount { get; set; }
    }
}
