using Samsung;
using System;
using Redmi;

namespace Retailer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.Display();
            //Redmi.Mobile mobR = new Redmi.Mobile();
            //Samsung.Mobile mobS = new Samsung.Mobile();
            //mobR.Display();
            //mobS.Display();

            Mobile mobile = new Mobile();
            mobile.Display();
            Console.ReadKey();
        }
    }
}

namespace Samsung
{
    public class Mobile
    {
        public void Display()
        {
            Console.WriteLine("Display of Samsung Mobile!");
        }
    }
}
