//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppMethod2
//{
//    public class Emp
//    {
//        public string FullName(string fname, string lname)
//        {
//            return fname + " " + lname;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Emp emp = new Emp();
//            Console.WriteLine(emp.FullName("Chaitanya", "Pradhan"));
//            Console.WriteLine(emp.FullName(lname: "Pradhan", fname: "Chaitanya"));
//            Console.WriteLine(emp.FullName(lname: "Kumar", fname: "Vivek"));
//            Console.ReadKey();
//        }
//    }
//}

//using System;

//namespace ConAppAMethod2
//{
//    public class Emp
//    {
//        public void Display(string name, int id , string city="Delhi")
//        {
//            Console.WriteLine("Details as Follows:");
//            Console.WriteLine($"ID: \t {id} \t Name: \t {name} \t City: \t {city}");
//        }

//        public void Add(int num1=10, int num2=20, int num3 = 30)
//        {
//            int result = num1 + num2 + num3;
//            Console.WriteLine($"Result After adding {num1}, {num2}, {num3} is = \t {result}");
//        }

//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                Emp emp = new Emp();
//                emp.Display("Chaitanya Pradhan", 101, "CKP");
//                emp.Display("Sameer Gupta", 102);

//                emp.Add();
//                emp.Add(1);
//                emp.Add(100, 200);
//                emp.Add(5, 10, 15);

//                Console.ReadKey();
//            }
//        }
//    }
//}

using System;

namespace ConAppAMethod2
{

        internal class Program
        {
            static void Main(string[] args)
            {
            //int num = 5;    //Value Type
            //object obj; // Reference Type
            //obj = num; //Boxing
            //Console.WriteLine("Boxed Value is: " + obj);
            //int num2;
            //num2 = (int)obj; //UnBoxing
            //Console.WriteLine("UnBoxed Value is: "+ num2);
            //Console.ReadKey();

            // DateTime
            //DateTime dt = new DateTime(day: 12, month: 07, year: 2023, hour: 11, minute: 30, second: 15);
            //Console.WriteLine("Default: "+dt );
            //Console.WriteLine("Short Date STring: \t"+dt.ToShortDateString());
            //Console.WriteLine("Long Date STring: \t" + dt.ToLongDateString());
            //Console.WriteLine("Short Time STring: \t" + dt.ToShortTimeString());
            //Console.WriteLine("Long Time STring: \t" + dt.ToLongTimeString());
            //Console.ReadKey();

            DateTime finalmatchDate = new DateTime(day: 15, month: 07, year: 2023, hour: 11, minute: 30, second: 15);
            DateTime current = DateTime.Now;
            TimeSpan timespan = finalmatchDate - current;
            Console.WriteLine("Days remains are: " +timespan.Days);
            Console.WriteLine("Hours remains are: " + timespan.Hours);
            Console.WriteLine("Total Hour Remains are: "+ timespan.TotalHours);
            Console.WriteLine("Total Days Remains are: "+ timespan.TotalDays);

            Console.ReadKey();
        }
        }
}
