using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAbstractExample
{
    public abstract class OurAbClass
    {
        int ourField;
        public OurAbClass()
        {
            Console.WriteLine("Abstract Class COnstructor");
            ourField = 1;
        }

        public int OurProp { get { return ourField; }  set { ourField = value;  } }
        public abstract void Display(string msg);
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
