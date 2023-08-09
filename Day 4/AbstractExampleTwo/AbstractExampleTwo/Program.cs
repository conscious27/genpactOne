using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(3.2);
            Console.WriteLine("Area of Square is:  \t"+square.CalcArea());
            Console.ReadKey();
        }
    }
}
