using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurDrv objd = new OurDrv();
            objd.Display("Welcome to Abstract Class");
            Console.WriteLine("Add Result: \t"+objd.Add(12, 12.65));
            Console.WriteLine(objd.OurProp);
            Console.ReadKey();
        }
    }
}
