using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class Calculation
    {
        public double Add(double n1,  double n2)
        {
            double result = n1 + n2;
            return result;
        }
        public double Avg(double n1, double n2)
        {
            double result = (n1 + n2)/2;
            return result;
        }
        public double Diff(double n1, double n2)
        {
            double result = n1 - n2;
            return result;
        }
        public double Multi(double n1,  double n2)
        {
            double result = n1 * n2;
            return result;
        }
        public double Div(double n1, double n2)
        {
            double result = n1 / n2;
            return result;
        }
    }
}
