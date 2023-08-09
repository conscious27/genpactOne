using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDestructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(07, "MSD");
            Console.WriteLine("Number of Players are: "+Player.Count);
            Player player2 = new Player(18, "VK");
            Console.WriteLine("Number of Players ar: "+Player.Count);
            player1 = null;
            player2 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadKey();
        }
    }
}
