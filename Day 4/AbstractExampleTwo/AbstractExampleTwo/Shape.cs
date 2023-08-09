using System;

namespace AbstractExampleTwo
{
    public abstract class Shape
    {
        public abstract double CalcArea();

        public void Display()
        {
            Console.WriteLine("Welcome to Shapes.");
        }

    }
}
