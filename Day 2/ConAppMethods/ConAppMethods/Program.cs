using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethods
{
    public class OurClass
    {
        // [Acess Specifier] [Modifier] returntype Methodname () {}
        public void Display()
        {
            Console.WriteLine("WELCOME TO METHOD");
        }

        public string Welcome(string fname, string lname)
        {
            return "WELCOME  Mr.\\Ms. " + fname + lname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Classname objectname = new Classname();
            // Objectname.methodname();
            OurClass obj = new OurClass();
            obj.Display();

            string msg = obj.Welcome("Chaitanya", "Pradhan");
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
