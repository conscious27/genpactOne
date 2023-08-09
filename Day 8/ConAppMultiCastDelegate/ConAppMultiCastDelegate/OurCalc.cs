using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMultiCastDelegate
{
    public class OurCalc
    {
        public void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine($"Result after adding {num1} and {num2} = \t{result}");
        }
        public void Sub(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine($"Result after {num1} - {num2} = \t{result}");
        }
        public void Multi(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine($"Result after multiplying {num1} and {num2} = \t{result}");
        }
        public void Div(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine($"Result after dividing {num1} by {num2} = \t{result}");
        }
    }
}
