using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            //OurClass<int> obji = new OurClass<int>(12);
            //OurClass<string> objs = new OurClass<string>("Sameer");
            //OurClass<float> objf = new OurClass<float>(12.5F);
            //OurClass<double> objd = new OurClass<double>(12.56);

            //obji.Display();
            //objs.Display();
            //objf.Display();
            //objd.Display();

            // Example-2
            OurClass<int, String> objis = new OurClass<int, String>();
            objis.SetInfo(12, "Chaitanya");
            objis.ShowInfo();

            OurClass<int, int>objii = new OurClass<int, int>();
            objii.SetInfo(13, 14);
            objii.ShowInfo();

            OurClass<double, char> objdc = new OurClass<double, char>();
            objdc.SetInfo(13.50, 'A');
            objdc.ShowInfo();

            Console.ReadKey();
        }
    }
}
