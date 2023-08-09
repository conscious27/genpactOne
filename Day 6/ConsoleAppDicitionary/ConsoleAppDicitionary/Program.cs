using System;
using System.Collections.Generic;


namespace ConsoleAppDicitionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> studentDictionary = new Dictionary<int, string>()
            //{
            //    {12, "Ravish" },
            //    {54, "Anita" },
            //    {15, "Joya" }
            //};

            //Console.WriteLine("Number of Students in List are:\t"+studentDictionary.Count);
            //Console.WriteLine("Roll No. \t Name");

            //foreach(var k in studentDictionary.Keys)
            //{
            //    Console.WriteLine(k + "\t" + studentDictionary[k]);
            //}

            //studentDictionary.Add(32, "Anamika");

            //Console.WriteLine("Updated Number of Students in List are:\t" + studentDictionary.Count);
            //Console.WriteLine("Roll No. \t Name");

            //foreach (var k in studentDictionary.Keys)
            //{
            //    Console.WriteLine(k + "\t" + studentDictionary[k]);
            //}

            // Sorted List Example
            // Find and Replace : CTRL + H, Comment: CTRL + K +C, UNCOMMENt : CTRL + K + U
            SortedList<int, string> studentSortedList = new SortedList<int, string>()
            {
                {12, "Ravish" },
                {54, "Anita" },
                {15, "Joya" }
            };

            Console.WriteLine("Number of Students in List are:\t" + studentSortedList.Count);
            Console.WriteLine("Roll No. \t Name");

            foreach (var k in studentSortedList.Keys)
            {
                Console.WriteLine(k + "\t" + studentSortedList[k]);
            }

            studentSortedList.Add(32, "Anamika");

            Console.WriteLine("Updated Number of Students in List are:\t" + studentSortedList.Count);
            Console.WriteLine("Roll No. \t Name");

            foreach (var k in studentSortedList.Keys)
            {
                Console.WriteLine(k + "\t" + studentSortedList[k]);
            }

            Console.ReadKey();
        }
    }
}
