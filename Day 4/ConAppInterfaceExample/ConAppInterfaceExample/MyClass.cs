using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterfaceExample
{
    public class MyClass : IMyInterface
    {
        int myField;
        public int MyProp { get => myField; set => myField = value; }

        public void Display()
        {
            Console.WriteLine("Display of MyClass!");
        }

        public string Welcome(string message)
        {
            return "Message for you is: " + message;
        }
    }
}
