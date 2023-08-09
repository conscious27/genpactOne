using System;
using System.Collections.Generic;

namespace ConsoleAppSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, double> hardwareList = new SortedList<string, double>()
            {
                {"RAM", 500.00 },
                {"Keyboard", 1500.78 },
                {"Printer", 34000 },
                {"CD", 80 }
            };
            Console.WriteLine("*** Initial Hardware List ***");
            Console.WriteLine("Hardware \t Price");
            foreach(KeyValuePair<string, double> kvp in hardwareList)
            {
                Console.WriteLine(kvp.Key + "\t" + kvp.Value);
            }

            // Add
            //string newHardware;
            //double price;

            //Console.WriteLine("Enter new Hardware: ");
            //newHardware = Console.ReadLine();
            //Console.WriteLine("Enter Price: ");
            //price = int.Parse(Console.ReadLine());

            //hardwareList.Add(newHardware, price);

            //Console.WriteLine("*** Updated Hardware List ***");
            //Console.WriteLine("Hardware \t Price");
            //foreach (KeyValuePair<string, double> kvp in hardwareList)
            //{
            //    Console.WriteLine(kvp.Key + "\t" + kvp.Value);
            //}

            // Update
            Console.WriteLine("Enter Hardware to update:");
            string upHw = Console.ReadLine();
            if(hardwareList.ContainsKey(upHw))
            {
                Console.WriteLine($"Enter New Price for {upHw}");
                double price = double.Parse(Console.ReadLine());
                hardwareList[upHw] = price;
                Console.WriteLine($"List after updatimg {upHw}");
                foreach(KeyValuePair<string, double> kvp in hardwareList)
                {
                    Console.WriteLine(kvp.Key + ":->" + kvp.Value);
                }
            }
            else
            {
                Console.WriteLine($"No Such {upHw} hardware exist!!!");
            }

            //Remove
            Console.WriteLine("Enter Hardware to delete:");
            string searchHw = Console.ReadLine();
            if (hardwareList.ContainsKey(upHw))
            {
                hardwareList.Remove(searchHw);
                Console.WriteLine($"List after Removing {searchHw}");
                foreach (KeyValuePair<string, double> kvp in hardwareList)
                {
                    Console.WriteLine(kvp.Key + ":->" + kvp.Value);
                }
            }
            else
            {
                Console.WriteLine($"No Such {upHw} hardware exist!!!");
            }

            Console.ReadKey();
        }
    }
}
