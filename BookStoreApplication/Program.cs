using BookStoreApplication.Data;
using BookStoreApplication.Models;
using ConsoleTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication
{
    class Program
    {
        // Set the constant values
        public const double DeliveryFees = 5.95;
        public const double DeliveryFeeLimit = 20;
        public const double GstPercentage = 10;

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int MAXIMIZE = 3;

        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            DataContext dataContext = new DataContext();

            //Load the order details to calcualte the Total amount
            List<OrderDetail> orderDetails = dataContext.FillOrderDetails();

            double orderAmount = 0, orderAmountAfterDiscount = 0;

            var table = new Table();

            table.SetHeaders("Book Store", "", "", "", "", "", "");
            table.AddRow("", "", "", "", "", "", "");

            table.AddRow("Title", "Author", "Genre", "Unit Price", "Quantity", "Discount", "Amount");

            foreach (OrderDetail orderDetail in orderDetails)
            {
                //Convert.ToString(orderDetail.BookDiscountPrice)

                table.AddRow(orderDetail.Book.BookName, orderDetail.Book.AuthorName, orderDetail.Book.Genre.GenreName, string.Format("{0:0.00}", orderDetail.Book.UnitPrice),
                     Convert.ToString(orderDetail.Quantity), string.Format("{0}%", orderDetail.Book.Genre.Discount.DiscountPercentage),
                     string.Format("{0:0.00}", orderDetail.BookPriceAterDiscount));

                orderAmount += orderDetail.BookPrice;
                orderAmountAfterDiscount += orderDetail.BookPriceAterDiscount;
            }

            //GST amount 
            double gstAmount = orderAmountAfterDiscount * GstPercentage / 100;

            //Total amount
            double totalAmount = orderAmountAfterDiscount + gstAmount;

            table.AddRow("", "", "", "", "", "Subtotal", Convert.ToString(Math.Round(orderAmountAfterDiscount, 2)));
            table.AddRow("", "", "", "", "", "GST(10%)", Convert.ToString(Math.Round(gstAmount, 2)));

            //Check if the total amount is less than delivery fee limit
            //If less then add the delivery fees to toatl amount.
            if (totalAmount < DeliveryFeeLimit)
            {
                totalAmount = totalAmount + DeliveryFees;
                table.AddRow("", "", "", "", "", "Delivery fee", Convert.ToString(Math.Round(DeliveryFees, 2)));
            }

            table.AddRow("", "", "", "", "", "Total", Convert.ToString(Math.Round(totalAmount, 2)));

            Console.WriteLine(table.ToString());
            Console.ReadLine();
        }
    }
}
