using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_Q2
{
    internal class Employee
    {
        public int Employee_ID;
        public string Name;
        public string Department;
        public double Salaray;

        public Employee(int id, string name, string dep, double salary) //Constructor Intialization
        {
            Employee_ID = id;
            Name = name;
            Department = dep;
            Salaray = salary;

        }
        public void DisplayInfo()
        {
            Console.WriteLine("\t____________________");
            Console.WriteLine("\t| Employee Details |");
            Console.WriteLine("\t--------------------");
            Console.WriteLine("\n ID of the Employee: {0}", Employee_ID);
            Console.WriteLine(" ID of the Employee: {0}", Name);
            Console.WriteLine(" Department of the Employee: {0}", Department);
            Console.WriteLine(" Salary of the Employee: {0}Rs", Salaray);
            Console.WriteLine("\n ----------------------------------------------------");
        }
        public void IncreasedSalary(double Amount)
        {
            Console.WriteLine(" Salary of the Employee After {0} Amount Increase is: {1}", Amount,Amount + Salaray);
            Console.WriteLine("\n -----------------------------------------------------------------------");
        }
    }
}
