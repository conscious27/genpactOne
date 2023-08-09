using System;

namespace CalcLib
{
    internal class Calc
    {
        internal int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        internal int Div(int num1, int num2)
        {
            int result;
            if(num2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                result = num1 / num2;
            }
            return result;
        }

        internal string Welcome()
        {
            string welcome = "Welcome to CalcLib";
            return welcome;
        }
    }
}