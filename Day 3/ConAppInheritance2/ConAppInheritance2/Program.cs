using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer objDev = new Developer(1, "Sameer", 50000.50, DateTime.Now, "e-aivideos", ".net");
            objDev.Display();
            Console.ReadKey();
        }
    }
}
