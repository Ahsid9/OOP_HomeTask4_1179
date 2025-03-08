using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Book
    {
        private string ISBN;
        private string Title;
        private int Price;
        private string Major_Area;
        private string Sub_Area;
        private int No_of_pages;

        public void Display()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine("|       BOOK        |");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.WriteLine("1-|Title        : {0}", Title);
            Console.WriteLine("2-|ISBN         : {0}", ISBN);
            Console.WriteLine("3-|Major Area   : {0}", Major_Area);
            Console.WriteLine("4-|Sub Area     : {0}", Sub_Area);
            Console.WriteLine("5-|Price        : {0}$", Price);
            Console.WriteLine("6-|No. Of Pages : {0}", No_of_pages);
        }
        public void Input()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine("|       Input       |");
            Console.WriteLine("---------------------");
            Console.Write("\nEnter The Title Of The BOOK: ");
            Title = Console.ReadLine();
            Console.Write("\nEnter The ISBN Of The BOOK: ");
            ISBN = Console.ReadLine();
            Console.Write("\nEnter The Price Of The BOOK: ");
            Price = int.Parse(Console.ReadLine());
            Console.Write("\nEnter The Major Area Of The BOOK: ");
            Major_Area = Console.ReadLine();
            Console.Write("\nEnter The Sub Area Of The BOOK: ");
            Sub_Area = Console.ReadLine();
            Console.Write("\nEnter The No. Of Pages Of The BOOK: ");
            No_of_pages = int.Parse(Console.ReadLine());
        }
        public void Search(string titlebook)
        {
            if (titlebook == Title)
            {
                Display();
            }
        }
    }
}
