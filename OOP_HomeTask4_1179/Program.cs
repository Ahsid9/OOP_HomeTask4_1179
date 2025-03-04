using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HomeTask4_1179
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Thousand Suplendid Suns";
            book1.Author = "Khaled Hossieni";
            book1.ISBN = "KS 100791";
            book1.Price = 475;

            book1.DisplayInfo();
            Console.WriteLine("");
            book1.ApplyDiscount(20);
        }
    }
}
