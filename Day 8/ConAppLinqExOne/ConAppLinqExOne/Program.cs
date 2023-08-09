using System;
using System.Collections.Generic;
using System.Linq;


namespace ConAppLinqExOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> nameList = new List<string>()
            //{
            //    "Amit", "Vijay", "Nitin", "Gourav", "Zoya"
            //};

            //string[] nameArray = new string[]
            //{
            //    "Amit", "Vijay", "Nitin", "Gourav", "Zoya"
            //};

            //var query  = from ourName in nameList where ourName.Length >=5 select ourName;

            //Console.WriteLine("Result from List as Follows: ");
            //foreach ( var name in query )
            //{
            //    Console.WriteLine(name);
            //}

            //var qu1 = from ourName in nameArray where ourName.Length >= 5 select ourName;
            //Console.WriteLine("Result from Array as Follows: ");
            //foreach ( var name in qu1 )
            //{
            //    Console.WriteLine(name);
            //}

            // Example of Methods

            List<string> listCourses = new List<string>()
            {
                "ASP.net", "JSP", ".net core", "Java", "Html-5", "CSS-3", "JavaScript", "Azure", "C# .net",
                "F# .net"
            };
            Console.WriteLine("Write Courses to search:");
            string sCourse = Console.ReadLine();
            var query = from sResult in listCourses where sResult.Contains(sCourse) select sResult;
            foreach(var c in query)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();

        }
    }
}
