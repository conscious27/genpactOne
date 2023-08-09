
using System;

namespace ImplementingInterfaceTwo
{
    public class MyClass: IMyInterfaceOne, IMyInterfaceTwo
    {
        public void Display()
        {
            Console.WriteLine("Reply from Interface One");
        }

        public void Welcome(string name)
        {
            Console.WriteLine("Welcome to Interface Two Mr./Mr's. "+name);
        }
    }
}
