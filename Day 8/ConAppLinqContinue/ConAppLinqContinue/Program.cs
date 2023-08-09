using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppLinqContinue
{
    internal class Program
    {
        static List<Emp> list = new List<Emp>()
        {
           new Emp { Id = 1, Fname = "Raj", Lname = "Garg", Salary = 55000.50, DOJ = new DateTime(day: 23, month: 11, year: 2018) },
           new Emp { Id = 2, Fname = "Vihan", Lname = "Sharma", Salary = 66000.50, DOJ = new DateTime(day: 23, month: 12, year: 2020) },
           new Emp { Id = 3, Fname = "Sam", Lname = "Discota", Salary = 98000.50, DOJ = new DateTime(day: 26, month: 09, year: 2012) },
           new Emp { Id = 4, Fname = "Sohan", Lname = "Garg", Salary = 76000.50, DOJ = new DateTime(day: 23, month: 11, year: 2015) },
           new Emp { Id = 5, Fname = "Raj", Lname = "Sharma", Salary = 45000.50, DOJ = new DateTime(day: 02, month: 11, year: 2012) },
           new Emp { Id = 10, Fname = "Sam", Lname = "Johan", Salary = 99000.50, DOJ = new DateTime(day: 15, month: 07, year: 2017) },
           new Emp { Id = 11, Fname = "Vinay", Lname = "Kapoor", Salary = 56000.50, DOJ = new DateTime(day: 23, month: 06, year: 2012) },
           new Emp { Id = 12, Fname = "Meena", Lname = "Dixit", Salary = 65000.50, DOJ = new DateTime(day: 20, month: 10, year: 2019) }

        };
        static void Main(string[] args)
        {
            var query = from topSalEmp in list where topSalEmp.Salary>=70000 select topSalEmp;
            Console.WriteLine("Top Salaried Employees are");
            Print(query.ToList());
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
            var searchList = (from lEmp in list where lEmp.Lname.Equals(lname) select lEmp).ToList();
            Console.WriteLine("Total Number of Employees with given last name are: "+searchList.Count);
            Print(searchList);
            Console.ReadKey();
        }

        public static void Print(List<Emp> list)
        {
            foreach (Emp emp in list)
            {
                Console.WriteLine(emp.Id + "\t" + emp.Fname + "\t" + emp.Lname + "\t" + emp.Salary + "\t"
                    + emp.DOJ);
            }
        }
    }
}
