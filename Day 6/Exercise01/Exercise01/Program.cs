using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Program
    {
        static SortedList<int, Customer> customerList = new SortedList<int, Customer>()
            {
                {101, new Customer(){ CName = "Chaitanya", CCity = "CKP", ODLimit=1000.50} },
                {102, new Customer(){ CName = "Abhijeet", CCity = "Ranchi", ODLimit=5000.50} },
                {103, new Customer(){ CName = "Amit", CCity = "Deoghar", ODLimit=3000.00} },
                {104, new Customer(){ CName = "Ujjawal", CCity = "Beugsarai", ODLimit=10000.70} },
                {105, new Customer(){ CName = "Rahul", CCity = "Arwal", ODLimit=1000.00} }
          };
        static void Main(string[] args)
        {
            PrintAll();
            Console.WriteLine("Enter the Account you want to remove:");
            int delAcc = int.Parse(Console.ReadLine());
            RemoveList(delAcc);
            Console.WriteLine("After Deleting {delAcc} Account:");
            PrintAll();


            Console.WriteLine("Enter the Account you want to update: ");
            int updAcc = int.Parse(Console.ReadLine());
            UpdateList(updAcc);
            Console.WriteLine("After Updating {delAcc} Account:");
            PrintAll();

            AddList();
            PrintAll();

            Console.ReadKey();
        }

        public static void AddList()
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter the Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            if(customerList.ContainsKey(accNo))
            {
                Console.WriteLine("Account Already Exist!!!!");
                return;
            }
            Console.WriteLine("Enter the Customer's Name: ");
            customer.CName = Console.ReadLine();
            Console.WriteLine("Enter the Customer's City: ");
            customer.CCity = Console.ReadLine();
            Console.WriteLine("Enter Customer's OD Limit: ");
            customer.ODLimit = int.Parse(Console.ReadLine());

            customerList.Add(accNo, customer);
        }

        public static void RemoveList(int delAcc)
        {
            if (customerList.ContainsKey(delAcc))
            {
                customerList.Remove(delAcc);
            }
            else
            {
                Console.WriteLine($"No Such Account {delAcc} exist!!!!!");
            }
        }

        public static void UpdateList(int updAcc)
        {
            if (customerList.ContainsKey(updAcc))
            {
                Console.WriteLine("Enter Customer Name: ");
                customerList[updAcc].CName = Console.ReadLine();
                Console.WriteLine("Enter Customer City: ");
                customerList[updAcc].CCity = Console.ReadLine();
                Console.WriteLine("Enter OD Limit: ");
                customerList[updAcc].ODLimit = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($"No Such {updAcc} exist!!!!!");
            }
        }

        public static void PrintAll()
        {
            Console.WriteLine("Customer List as Follows:");
            Console.WriteLine("CustomerAccountNo \t Customer Name \t Customer City \t OD Limit");
            foreach (KeyValuePair<int, Customer> cmr in customerList)
            {
                Console.WriteLine(cmr.Key + "\t\t\t" + cmr.Value.CName + "\t\t" + cmr.Value.CCity + "\t\t"
                    + cmr.Value.ODLimit);
            }
        }
    }
}
