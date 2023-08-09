using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CalcLib
{
    public class OurCustomEx : Exception
    {
        public OurCustomEx(string msg) : base(msg) { }
    }
    public class CalcUtil
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b) { return a - b; }
        public double Multiply(double a, double b) { return a * b; }
        public double Divide(double a, double b)
        {
            double result;
            try
            {
                if(b == 0)
                {
                    throw new Exception("Divide by Zero");
                }
              result = a / b;
                
            }
            catch(OurCustomEx ex)
            {
                result = -1;
                Console.WriteLine("Divided by Zero");
            }
            return result;
        }

        public bool isPrime(int num)
        {
            if(num<=1) return false;

            for(int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

    }
}
