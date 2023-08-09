using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMultiCastDelegate
{
    public delegate void Calcdel(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = 12.50;
            double number2 = 6.25;

            OurCalc ourCalc = new OurCalc();
            Calcdel del = new Calcdel(ourCalc.Add);
            Console.WriteLine("Invocation of Delegate First:");
            del(number1, number2);
            del += new Calcdel(ourCalc.Multi);
            Console.WriteLine("Two Methods!!!");
            del(number1, number2);

            del += new Calcdel(ourCalc.Div);
            del += new Calcdel(ourCalc.Add);
            del += new Calcdel(ourCalc.Sub);

            Console.WriteLine("After Adding 5 Methods");
            del(number1, number2);

            del -= new Calcdel(ourCalc.Div);

            Console.WriteLine("After Removing one method");
            del(number1, number2);
            del -= new Calcdel(ourCalc.Add);
            Console.WriteLine("After Removing one Add Method");
            del(number1, number2);

            del -= new Calcdel(ourCalc.Add);
            Console.WriteLine("After Removing two Add Method");
            del(number1, number2);
            Console.ReadKey();
        }
    }
}
