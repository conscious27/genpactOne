using System;
using nds = Delhi.North.Samsung;
using southsam = Delhi.South.Samsung;
namespace Vendor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nds.TV obj = new nds.TV();
            obj.PriceDetails();
            southsam.TV objs = new southsam.TV();
            objs.PriceDetails();
            Console.ReadKey();
        }
    }
}
