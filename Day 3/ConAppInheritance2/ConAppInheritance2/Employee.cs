using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritance2
{
    public class Employee
    {
        int id;
        string name;
        double salary;
        DateTime doj;

        public Employee(int id, string name, double salary, DateTime doj)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.doj = doj;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID:\t{id} \n Name:\t{name} \n Salary:\t{salary} \n DOJ:\t{doj}");
        }
    }
}
