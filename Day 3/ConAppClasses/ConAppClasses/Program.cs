using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppClasses
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Emp emp2 = new Emp();
            Console.WriteLine("ENTER EMPLOYEE 1 DETAILS: ");
            emp.Register();

            Console.WriteLine("ENTER EMPLOYEE 2 DETAILS: ");
            emp2.Register();

            Console.WriteLine("EMPLOYEE DETAILS AS FOLLOWS: ");
            Console.WriteLine("*********EMPLOYEE 1************");
            emp.Display();
            Console.WriteLine("*********EMPLOYEE 2************");
            emp2.Display();
            Console.ReadKey();
        }
    }
}
