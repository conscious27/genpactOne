
using System;

namespace ImplementingTwoInterfaceWithSameMethod
{
    public class MyClass : IInterfaceOne, IInterfaceTwo
    {
        void IInterfaceOne.Display()
        {
            Console.WriteLine("Interface One Display Method!!");
        }

        void IInterfaceTwo.Display()
        {
            Console.WriteLine("Interface Two Display Method!!");
        }
    }
}
