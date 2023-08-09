using System;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp= new Emp();
            Console.WriteLine("Enter Employee Id: ");
            emp.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Employee Details as follows: ");
            Console.WriteLine($"Id:\t{emp.Id} \n Name:\t{emp.Name} \n Salary:\t{emp.Salary} \n " +
                $"No.of Employee:{Emp.No_of_emp}");

            //Emp emp2 = new Emp();
            //Console.WriteLine("Enter Employee2 Id: ");
            //emp2.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Employee2 Name: ");
            //emp2.Name = Console.ReadLine();
            //Console.WriteLine("Enter Employee2 Salary: ");
            //emp2.Salary = double.Parse(Console.ReadLine());

            //Console.WriteLine("Employee2 Details as follows: ");
            //Console.WriteLine($"Id:\t{emp2.Id} \n Name:\t{emp2.Name} \n Salary:\t{emp2.Salary} \n " +
            //    $"No.of Employee:{Emp.No_of_emp}");
            //Console.ReadKey();


        }
    }
}
