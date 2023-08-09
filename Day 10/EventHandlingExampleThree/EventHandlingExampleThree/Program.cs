using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingExampleThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();

            string orderName, email, phone;
            Console.WriteLine("Enter Order: ");
            orderName = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            email = Console.ReadLine();
            Console.WriteLine("Enter Phone: ");
            phone = Console.ReadLine();

            order1.Created += Email.send;
            order1.Created += SMS.send;
            order1.Create(orderName, email, phone);

            Order order2 = new Order();
            order2.Created += Email.send;
            order2.Created += SMS.send;
            order2.Create("Fruit Salad", "sample@genpact.com", "8450122203");

            Console.ReadKey();
        }
    }
}
