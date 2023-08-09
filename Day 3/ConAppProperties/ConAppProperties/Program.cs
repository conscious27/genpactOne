using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Emp obj = new Emp();
            //Console.WriteLine("Enter Id: ");
            //obj.ID = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name: ");
            //obj.Name = Console.ReadLine();

            //Console.WriteLine("ID:\t"+obj.ID+"\nName:\t"+obj.Name);
            //Console.ReadKey();

            EmpSalary obj1 = new EmpSalary(50000.50);
            EmpSalary obj2 = new EmpSalary(45000.50);
            EmpSalary.Tax = 12.5;

            Console.WriteLine("Salary of Employee One is: "+obj1.Salary);
            Console.WriteLine("Salary of Employee Two is: "+obj2.Salary);
            Console.WriteLine("Tax: "+EmpSalary.Tax);
            Console.ReadKey();

        }
    }
}
