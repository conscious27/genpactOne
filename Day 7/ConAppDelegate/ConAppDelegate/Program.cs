using System;

namespace ConAppDelegate
{
    public delegate void OurDel(string param);
    public class OurClass
    {
        public void Display(string name)
        {
            Console.WriteLine("Welcome to Delegates!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass ourClass = new OurClass();
            OurDel objDel = new OurDel(ourClass.Display);
            Console.WriteLine("Delegate Invocation");
            objDel("Sandeep Kumar");
            Console.ReadKey();
        }
    }
}
