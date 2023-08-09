using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLib;
namespace CustomerManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Customer Date of Birth: ");
            string date = Console.ReadLine();
            DateTime dob = DateTime.Parse(date);
            
            string filePath = $"C:\\DotNet Training\\Day 11\\Customer\\{name}_{date}";

            FileStream fileStream = File.Create(filePath);
            fileStream.Close();

            Customer customer = new Customer(name, dob);
            CustomerManager customerManager = new CustomerManager();

            customerManager.Write(customer, filePath);
            customerManager.Read(filePath);

            Console.ReadKey();
        }
    }
}
