using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppClasses
{
    public class Emp
    {
        int id;
        string name;

        public Emp()
        {
            Console.WriteLine("Constructor of Emp Class");
            id = -1;
            name = "not given";
        }

        public void Register()
        {
            Console.WriteLine("Enter Employee id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("ID: \t" + id);
            Console.WriteLine("Name: \t" + name);
        }
    }
}
