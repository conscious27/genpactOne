using System;

namespace AbstractExampleTwo
{
    public class Square:Shape
    {
        readonly double length;

        public Square(double length)
        {
            this.length = length;
        }

        public override double CalcArea()
        {
            return length * length; 
        }
    }
}
