using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAnonymous
{
    internal class Program
    {
        //public delegate void WelcomeDel(string message);
        //static void Main(string[] args)
        //{
        //    WelcomeDel welcomeDel = delegate (string msg)
        //    {
        //        Console.WriteLine(msg);
        //    };

        //    Console.WriteLine("Invocation");
        //    welcomeDel("Welcome to the Anynomous Message!");
        //    Console.ReadKey();
        //}

        //public delegate double CalcDel(double num1, double num2);

        //static void Main(string[] args)
        //{
        //    CalcDel add = delegate (double num1, double num2)
        //    {
        //        return num1 + num2;
        //    };
        //    CalcDel multi = delegate (double num1, double num2)
        //    {
        //        return num1 * num2;
        //    };
        //    CalcDel div = delegate (double num1, double num2)
        //    {
        //        return num1 / num2;
        //    };
        //    Console.WriteLine("12.5 + 3.5 = " + add(12.5, 3.5));
        //    Console.WriteLine("12.5 * 3.5 = " + multi(12.5, 3.5));
        //    Console.WriteLine("12.5 / 3.5 = " + div(12.5, 3.5));
        //    Console.ReadKey();
        //}

        // Lambda Example
        public delegate double CalcDel(double num1, double num2);

        static void Main(string[] args)
        {
            CalcDel add = (x, y) => x + y;
            CalcDel multi = (x, y) => x * y;
            CalcDel div = (x, y) => x / y;
            Console.WriteLine("12.5 + 3.5 = " + add(12.5, 3.5));
            Console.WriteLine("12.5 * 3.5 = " + multi(12.5, 3.5));
            Console.WriteLine("12.5 / 3.5 = " + div(12.5, 3.5));
            Console.ReadKey();
        }
    }
}
