using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExampleTwo
{
    public delegate double OurCalcDel(double x, double y);

    public class MyClass
    {
        public static double Add(double num1 , double num2)
        {
            return num1 + num2;
        }

        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OurCalcDel del = new OurCalcDel(MyClass.Add);
            Console.WriteLine("Result after adding 12 and 15 is:"+del(12,15));
            MyClass obj = new MyClass();
            OurCalcDel del1 = new OurCalcDel(obj.Div);
            Console.WriteLine("Result after dividing 16 by 4 is: "+del1(16,4));
            Console.ReadKey();
        }
    }
}
