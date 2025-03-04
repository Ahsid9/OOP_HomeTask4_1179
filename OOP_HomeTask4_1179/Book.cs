using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HomeTask4_1179
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;


        public void DisplayInfo()
        {
            Console.WriteLine("\t________________");
            Console.WriteLine("\t| Book Details |");
            Console.WriteLine("\t----------------");
            Console.WriteLine("\n Title of the Book: {0}", Title);
            Console.WriteLine(" Author of the Book: {0}", Author);
            Console.WriteLine(" ISBN of the Book: {0}", ISBN);
            Console.WriteLine(" Price of the Book: {0}Rs", Price);
            Console.WriteLine("\n ----------------------------------------------------");
        }
        public void ApplyDiscount(double Percentage)
        {
            double store = Percentage;
           Percentage = Percentage / 100;
            Console.WriteLine("Price of the Book After {0}% discount is: {1}", store, Price - (Percentage * Price));
        }
    }
}
