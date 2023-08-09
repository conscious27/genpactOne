using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Program
    {
        public class Emp
        {
            public void Salary(double wh, int nWDays, int projectHandles=1, int extras = 0)
            {
                double salary = wh * nWDays * 100 + projectHandles * 3000 + extras * 2000;
                Console.WriteLine("Total Salary of Employee is: " + salary);
            }
        }
        static void Main(string[] args)
        {
            double wh;
            int nWDays;
            int projectHandles;
            int extras;
            Console.WriteLine("Choose Employee type by id:");
            Console.WriteLine("1. hr for HR");
            Console.WriteLine("2. ad for Admin");
            Console.WriteLine("3. sd for Software Developer");

            string choice;
            
            Console.WriteLine("Enter the employee id:");
            choice = Console.ReadLine();

            Emp emp = new Emp();
            switch(choice)
            {
                case "hr":
                    {
                        Console.WriteLine("Enter Working Hour:");
                        wh =double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter No. of Working Days:");
                        nWDays = int.Parse(Console.ReadLine());

                        emp.Salary(wh, nWDays);
                        
                        break;
                    }
                case "ad":
                    {
                        Console.WriteLine("Enter Working Hour:");
                        wh = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter No. of Working Days:");
                        nWDays = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Project Handles:");
                        projectHandles = int.Parse(Console.ReadLine());

                        emp.Salary(wh, nWDays, projectHandles);
                        break;
                    }
                case "sd":
                    {
                        Console.WriteLine("Enter Working Hour:");
                        wh = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter No. of Working Days:");
                        nWDays = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Project Handles:");
                        projectHandles = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Extras:");
                        extras = int.Parse(Console.ReadLine());

                        emp.Salary(wh, nWDays, projectHandles, extras);
                        break;
                    }
                default:
                    { 
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
