using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAbstractExample
{
    public class OurDrv:OurAbClass
    {
        public override void Display(string msg)
        {
            Console.WriteLine("Hi Here are message for you: \t"+msg);
        }
    }
}
