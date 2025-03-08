using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class MealCard
    {
        public string Student_Name;
        public int balance;

        public MealCard(string name, int bal=0)
        {
            Student_Name = name;
            if(bal != 0) balance = bal;
            else balance = 100;
        }
        public void AddPoints(int amount)
        {
            Console.WriteLine("After Adding Points to Your Balance: {0}",amount + balance);
        }
        public void PurchaseFood(int cost)
        {
            if (balance > cost) 
            {
                balance = balance - cost;
                Console.WriteLine("Purchased Successful!");
                Console.WriteLine("Updated Balance: {0}",balance);
            }
            else
            {
                Console.WriteLine("InSuffecient Balance!");
                Console.WriteLine("Purchased Unsuccessful!");
            }
        }
        public void Display()
        {
            Console.WriteLine("Your Balance is: {0}",balance);
        }
    }
}
