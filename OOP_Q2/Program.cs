using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1179,"Ahsan","BSSE",150000);
            employee1.DisplayInfo();
            employee1.IncreasedSalary(25000);
            Employee employee2 = new Employee(1729, "Siddiqi", "BSCS", 115000);
            employee2.DisplayInfo();
            employee2.IncreasedSalary(12700);
        }
    }
}