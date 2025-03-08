using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MealCard st1 = new MealCard("Ahsan");
            st1.Display();
            st1.PurchaseFood(40);
            st1.AddPoints(20);
            Console.WriteLine("");
            MealCard st2 = new MealCard("Ahsan", 50);
            st2.Display();
            st2.PurchaseFood(30);
            st2.AddPoints(10);
            Console.WriteLine("");
            MealCard st3 = new MealCard("Ahsan", 25);
            st3.Display();
            st3.PurchaseFood(40);
            st3.AddPoints(5);
        }
    }
}