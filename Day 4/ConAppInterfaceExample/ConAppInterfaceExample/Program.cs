using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
            Console.WriteLine(obj.Welcome("Welcome to Interface!"));
            Console.ReadKey();
        }
    }
}
