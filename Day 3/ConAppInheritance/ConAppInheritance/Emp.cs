using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritance
{
    public class Emp
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Qal { get; set; }
        //public DateTime Doj { get; set; }

        int id;
        string name;

        public Emp()
        {
            Console.WriteLine("Employee Constructor!!");
            id = -1;
            name = "Not Given!!";
        }

        public virtual void Display()
        {
            Console.WriteLine("ID: "+ id);
            Console.WriteLine("Name: "+ name);
        }

        public virtual void Register()
        {
            Console.WriteLine("Enter Id to regiter: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name to register: ");
            name = Console.ReadLine();
        }
    }
}
