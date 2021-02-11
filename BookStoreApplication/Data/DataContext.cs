using BookStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Data
{
    public class DataContext
    {
        public List<Genre> FillGenre()
        {
            List<Genre> genres = new List<Genre>();
            List<Discount> discounts = FillDiscount();
            Genre genreCrime = new Genre
            {
                GenreID = 1,
                GenreName = "Crime",
                IsDeleted = false,
                DiscountID = 2,
                Discount = discounts.Where(d => d.DiscountID == 2).FirstOrDefault()
            };

            Genre genreFantasy = new Genre
            {
                GenreID = 2,
                GenreName = "Fantasy",
                IsDeleted = false,
                DiscountID = 1,
                Discount = discounts.Where(d => d.DiscountID == 1).FirstOrDefault()
            };

            Genre genreRomance = new Genre
            {
                GenreID = 3,
                GenreName = "Romance",
                IsDeleted = false,
                DiscountID = 1,
                Discount = discounts.Where(d => d.DiscountID == 1).FirstOrDefault()
            };

            genres.Add(genreCrime);
            genres.Add(genreFantasy);
            genres.Add(genreRomance);

            return genres;
        }

        public List<Author> FillAuthor()
        {
            List<Author> authors = new List<Author>();
            Author author1 = new Author
            {
                AuthorID = 1,
                AuthorName = "Emily G. Thompson, Amber Hunt",
                IsDeleted = false
            };

            Author author2 = new Author
            {
                AuthorID = 2,
                AuthorName = "Lewis Carroll",
                IsDeleted = false
            };

            Author author3 = new Author
            {
                AuthorID = 3,
                AuthorName = "Roland Merullo",
                IsDeleted = false
            };

            Author author4 = new Author
            {
                AuthorID = 4,
                AuthorName = "S J Parris",
                IsDeleted = false
            };

            Author author5 = new Author
            {
                AuthorID = 5,
                AuthorName = "Michael Ende",
                IsDeleted = false
            };

            Author author6 = new Author
            {
                AuthorID = 6,
                AuthorName = "Philip Sugden",
                IsDeleted = false
            };

            Author author7 = new Author
            {
                AuthorID = 7,
                AuthorName = "Greg Hildebrandt",
                IsDeleted = false
            };

            authors.Add(author1);
            authors.Add(author2);
            authors.Add(author3);
            authors.Add(author4);
            authors.Add(author5);
            authors.Add(author6);
            authors.Add(author7);

            return authors;
        }

        public List<Discount> FillDiscount()
        {
            List<Discount> discounts = new List<Discount>();

            Discount discount1 = new Discount
            {
                DiscountID = 1,
                DiscountPercentage = 0,
                IsDeleted = false
            };

            Discount discount2 = new Discount
            {
                DiscountID = 2,
                DiscountPercentage = 5,
                IsDeleted = false
            };

            discounts.Add(discount1);
            discounts.Add(discount2);
            return discounts;
        }

        public List<Book> FillBooks()
        {
            List<Book> books = new List<Book>();
            List<Genre> genres = FillGenre();

            Book book1 = new Book
            {
                BookID = 1,
                BookName = "Unsolved murders",
                AuthorName = "Emily G. Thompson, Amber Hunt",
                GenreID = 1,
                UnitPrice = 10.99,
                Genre = genres.Where(g => g.GenreID == 1).FirstOrDefault()
            };

            Book book2 = new Book
            {
                BookID = 2,
                BookName = "Alice in Wonderland",
                AuthorName = "Lewis Carroll",
                GenreID = 2,
                UnitPrice = 5.99,
                Genre = genres.Where(g => g.GenreID == 2).FirstOrDefault()
            };

            Book book3 = new Book
            {
                BookID = 3,
                BookName = "A Little Love Story",
                AuthorName = "Roland Merullo",
                GenreID = 3,
                UnitPrice = 2.40,
                Genre = genres.Where(g => g.GenreID == 3).FirstOrDefault()
            };

            Book book4 = new Book
            {
                BookID = 4,
                BookName = "Heresy",
                AuthorName = "S J Parris",
                GenreID = 2,
                UnitPrice = 6.80,
                Genre = genres.Where(g => g.GenreID == 2).FirstOrDefault()
            };

            Book book5 = new Book
            {
                BookID = 5,
                BookName = "The Neverending Story",
                AuthorName = "Michael Ende",
                GenreID = 2,
                UnitPrice = 7.99,
                Genre = genres.Where(g => g.GenreID == 2).FirstOrDefault()
            };

            Book book6 = new Book
            {
                BookID = 6,
                BookName = "Jack the Ripper",
                AuthorName = "Philip Sugden",
                GenreID = 1,
                UnitPrice = 16,
                Genre = genres.Where(g => g.GenreID == 1).FirstOrDefault()
            };

            Book book7 = new Book
            {
                BookID = 7,
                BookName = "The Tolkien Years",
                AuthorName = "Greg Hildebrandt",
                GenreID = 2,
                UnitPrice = 22.90,
                Genre = genres.Where(g => g.GenreID == 2).FirstOrDefault()
            };


            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);
            books.Add(book6);
            books.Add(book7);
            return books;

        }

        public List<OrderDetail> FillOrderDetails()
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            List<Book> books = FillBooks();

            OrderDetail orderDetail1 = new OrderDetail
            {
                OrderDetailsID = 1,
                BookID = 1,
                Quantity = 1,
                Book = books.Where(b => b.BookID == 1).FirstOrDefault()
            };

            OrderDetail orderDetail2 = new OrderDetail
            {
                OrderDetailsID = 2,
                BookID = 3,
                Quantity = 1,
                Book = books.Where(b => b.BookID == 3).FirstOrDefault()
            };

            OrderDetail orderDetail3 = new OrderDetail
            {
                OrderDetailsID = 3,
                BookID = 4,
                Quantity = 1,
                Book = books.Where(b => b.BookID == 4).FirstOrDefault()
            };

            OrderDetail orderDetail4 = new OrderDetail
            {
                OrderDetailsID = 4,
                BookID = 6,
                Quantity = 1,
                Book = books.Where(b => b.BookID == 6).FirstOrDefault()
            };

            OrderDetail orderDetail5 = new OrderDetail
            {
                OrderDetailsID = 5,
                BookID = 7,
                Quantity = 1,
                Book = books.Where(b => b.BookID == 7).FirstOrDefault()
            };

            orderDetails.Add(orderDetail1);
            orderDetails.Add(orderDetail2);
            orderDetails.Add(orderDetail3);
            orderDetails.Add(orderDetail4);
            orderDetails.Add(orderDetail5);

            return orderDetails;
        }
    }
}
