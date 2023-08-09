using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConaAppSealedEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDev appDev = new AppDev(101, "Chaitanya", "Operating System", "Windows");
            appDev.Display();
            appDev.Welcome();

            Console.ReadKey();
        }
    }
}
