using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVarEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var myVar1 = 25;
            //var myVar2 = "Sam";
            //var myVar3 = DateTime.Now;

            //Console.WriteLine("Value Stored: \t" + myVar1 + "\t DataType:\t" + myVar1.GetType());
            //Console.WriteLine("Value Stored: \t" + myVar2 + "\t DataType:\t" + myVar2.GetType());
            //Console.WriteLine("Value Stored: \t" + myVar3 + "\t DataType:\t" + myVar3.GetType());

            //Console.ReadKey();

            string username;
        Again:
            Console.WriteLine("Enter Username");
            username = Console.ReadLine();
            if(username.Length>=6)
            {
                Console.WriteLine("Welcome Mr.\\Ms." + username);
            }
            else
            {
                Console.WriteLine("Username must have 6 Characters");
                goto Again;
            }
            Console.ReadKey();
        }
    }
}
