using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingTwoInterfaceWithSameMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            IInterfaceOne obj1 = obj;
            obj1.Display();

            IInterfaceTwo obj2 = obj;
            obj2.Display();

            Console.ReadKey();
        }
    }
}
