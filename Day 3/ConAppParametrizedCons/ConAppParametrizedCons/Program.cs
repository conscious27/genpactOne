using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppParametrizedCons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Player p1 = new Player(7, "MSD", "CSK");
            //p1.Display();
            //Player p2 = new Player(18, "VK", "RCB");
            //p2.Display();
            //Console.ReadKey();

            Player p1 = new Player();
            p1.Display();
            Player p2 = new Player();
            p2.Display();
            Console.ReadKey();
        }
    }
}
