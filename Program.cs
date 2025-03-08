using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] book = new Book[2];
            for (int i = 0; i < book.Length; i++)
            {
                book[i] = new Book();

                book[i].Input();
                Console.WriteLine("");
            }
            Console.Clear();
            Console.WriteLine("");
            for (int i = 0; i < book.Length; i++)
            {
                book[i].Display();
                Console.WriteLine("");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.Write("Enter The Title of The Book You Want to Search: ");
            string Titlebook = Console.ReadLine();
            for (int i = 0; i < book.Length; i++)
            {
                book[i].Search(Titlebook);
            }
        }
    }
}
