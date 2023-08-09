using System;


namespace ImplementingInterfaceTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
            obj.Welcome("SAM");
            Console.ReadKey();
        }
    }
}
