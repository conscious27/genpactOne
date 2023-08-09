using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Rectangle
    {

        public double FindArea(double length, double breadth)
        {
            return length * breadth;
        }

        public double FindLength(double Area, double breadth)
        {
            return Area / breadth;
        }

        public double FindBreadth(double Area, double length)
        {
            return Area / length;
        }
    }
}
