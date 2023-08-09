//using System;
//using System.Collections;


//namespace ArrayListExample
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//ArrayList arrayList = new ArrayList();
//Console.WriteLine("Capacity: "+arrayList.Capacity);

//Emp emp = new Emp() { Id = 1, Name = "Sam", Description = "Manager",  DOJ = DateTime.Now};
//arrayList.Add(emp);
//Emp emp1 = new Emp() { Id = 2, Name = "Ravi", Description = "Developer", 
//    DOJ = new DateTime(day:12, month:12, year:2014) };
//arrayList.Add(emp1);
//Emp emp2 = new Emp()
//{
//    Id = 3,
//    Name = "Amit",
//    Description = "",
//    DOJ = new DateTime(day: 12, month: 12, year: 2014)
//};
//arrayList.Add(emp2 );

//foreach(Emp a in arrayList)
//{
//    Console.WriteLine(a.Id);
//    Console.WriteLine(a.Name);
//    Console.WriteLine(a.Description);
//    Console.WriteLine(a.DOJ);
//    Console.WriteLine("*****************************");
//}

//ArrayList arrayList = new ArrayList()
//{
//    new Emp {Id = 1, Name="Sam", Description="Manager", DOJ=new DateTime(day:12, month:12, year:2020)},
//    new Emp {Id = 2, Name="Ravi", Description="Tester", DOJ=new DateTime(day:02, month:06, year:2021)},
//    new Emp {Id = 3, Name="Amit", Description="Tester", DOJ=new DateTime(day:25, month:09, year:2022)},
//    new Emp {Id = 4, Name="Vipin", Description="Developer", DOJ=new DateTime(day:30, month:11, year:2021)},
//    new Emp {Id = 5, Name="Noor", Description="Developer", DOJ=new DateTime(day:12, month:12, year:2022)}
//};

//Console.WriteLine("Number of Employees are:\t"+arrayList.Count);
//Console.WriteLine("Employees Details are as Follows:");
//foreach( Emp emp in arrayList )
//{
//    Console.Write("ID : \t"+emp.Id);
//    Console.Write("\t Name : \t" + emp.Name);
//    Console.Write("\t Designation : \t" + emp.Description);
//    Console.Write("\t Date of Joining : \t" + emp.DOJ);
//    Console.WriteLine("\n");
//}

//Hashtable ht = new Hashtable()
//{
//    {1, "Sam" }, {2, "ravi"}, {3, "Sameer"}
//};
//Console.WriteLine("Keys");
//foreach (var k in ht.Keys)
//{
//    Console.WriteLine(k);
//}

//Console.WriteLine("Values");
//foreach(var v in ht.Values)
//{
//    Console.WriteLine(v);
//}

//Console.WriteLine("keys \t Values");
//foreach (var k in ht.Keys)
//{
//    Console.WriteLine(k + "\t" + ht[k]);
//}

//Console.ReadKey();
//        }
//    }
//}

using System;
using System.Collections;

namespace ExampleArrayList
{
    public class MyClass
    {
        static ArrayList hardwareList;

        public static void Main()
        {
            hardwareList = new ArrayList() { "CD", "Printer", "DVD", "Keyboard", "Mouse"};
            Console.WriteLine("*** Initial List ***");
            PrintList();
            //string newHardware;
            //Console.WriteLine("Enter New Hardware");
            //newHardware = Console.ReadLine();
            //hardwareList.Add(newHardware);
            //Console.WriteLine("After Adding New Hardware!!");
            //PrintList();

            //string searchHardware;
            //Console.WriteLine("Enter Hardware to find and Update");
            //searchHardware = Console.ReadLine();
            //int index = hardwareList.IndexOf(searchHardware);
            //if(index == -1)
            //{
            //    Console.WriteLine($"No such hardware {searchHardware} exit in Hardware!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Enter Updated Values:");
            //    string updatedItem = Console.ReadLine();
            //    hardwareList[index] = updatedItem;
            //    Console.WriteLine("Updated Hardware List");
            //    PrintList();
            //}

            Console.WriteLine("Enter Hardware to be Deleted: ");
            string searchHardware = Console.ReadLine();
            int index = hardwareList.IndexOf(searchHardware);
            if(index == -1)
            {
                Console.WriteLine($"No such hardware {searchHardware} exist in Hardware!!");
            }
            else
            {
                hardwareList.Remove(searchHardware);
                Console.WriteLine("List After Deleting Items: ");
                PrintList();
            }
            Console.ReadKey();
        }

        public static void PrintList()
        {
            foreach (var hardware in hardwareList)
            {
                Console.WriteLine(hardware);
            }
        }
    }
}