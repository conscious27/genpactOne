using System;
using System.Collections.Generic;
using EmployeesLibrary;

namespace ConAppEmployeesMgmt
{
    public static class MyClass
    {
        public static void Welcome(this Employee emp)
        {
            Console.WriteLine("Welcome to Employee Management");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeHandler handler;
            Employee employee;

            string choice;

            do
            {
                employee = new Employee();
                employee.Welcome();
                Console.WriteLine("Enter ID: ");
                employee.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name: ");
                employee.Name = Console.ReadLine();

                Console.WriteLine("Enter Salary: ");
                employee.Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Date of Joining: ");
                employee.Doj = DateTime.Parse(Console.ReadLine());

                handler = new EmployeeHandler();
                handler.Add(employee);
                handler.Print();
                Console.WriteLine("Presss y to continue....");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");

            Console.ReadKey();
        }
    }
}
