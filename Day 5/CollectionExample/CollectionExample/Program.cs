using System;
using System.Collections;

namespace CollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList() { "Sam", "Ravi", "Amit" };

            //Console.WriteLine("Number of itme in array list are: "+arrayList.Count);
            //Console.WriteLine("Capacity of array list is: "+arrayList.Capacity);
            //Console.WriteLine("Stored Values are: ");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.Add("Arsh");
            //arrayList.Add("Zoya");
            //Console.WriteLine("After Adding Two More Items:");
            //Console.WriteLine("Number of itme in array list are: " + arrayList.Count);
            //Console.WriteLine("Capacity of array list is: " + arrayList.Capacity);
            //Console.WriteLine("Stored Values are: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("After Adding 9 Items: ");
            //arrayList.Add("A");
            //arrayList.Add("B");
            //arrayList.Add("Sameer");
            //arrayList.Add("Deepa");
            //Console.WriteLine("Number of itme in array list are: " + arrayList.Count);
            //Console.WriteLine("Capacity of array list is: " + arrayList.Capacity);
            //Console.WriteLine("Stored Values are: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.RemoveAt(3);
            //arrayList.Remove("Sam");
            //arrayList.Remove("A");
            //Console.WriteLine("After Removing 3 Items:");
            //Console.WriteLine("Number of itme in array list are: " + arrayList.Count);
            //Console.WriteLine("Capacity of array list is: " + arrayList.Capacity);
            //Console.WriteLine("Stored Values are: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Example-2
            ArrayList arrayList = new ArrayList()
            {
                "Sam",
                "Deepa",
                "Ravi",
                "Amit",
                "A",
                "B",
                "Sameer"
            };

            Console.WriteLine("Number of items in array list are: " + arrayList.Count);
            Console.WriteLine("Capacity of array list is: " + arrayList.Capacity);
            Console.WriteLine("Stored Values are: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Sort();
            Console.WriteLine("After Sorting: ");
            Console.WriteLine("Number of items in array list are: " + arrayList.Count);
            Console.WriteLine("Capacity of array list is: " + arrayList.Capacity);
            Console.WriteLine("Stored Values are: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Reverse();
            Console.WriteLine("After Reverse the List: ");
            Console.WriteLine("Number of items in array list are: " + arrayList.Count);
            Console.WriteLine("Capacity of array list is: " + arrayList.Capacity);
            Console.WriteLine("Stored Values are: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Clear();
            Console.WriteLine("After Clear: ");
            Console.WriteLine("Number of items in array list are: " + arrayList.Count);
            Console.WriteLine("Capacity of array list is: " + arrayList.Capacity);
            Console.WriteLine("Stored Values are: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
