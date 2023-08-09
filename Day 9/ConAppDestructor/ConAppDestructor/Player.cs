using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDestructor
{
    public class Player
    {
        int id;
        string name;
        static int count;

        public Player(int id, string name) 
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Player Constructor Call ID: {0} and Name: {1}", id, name);
        }

        public static int Count { get { return count; } }

        ~Player() 
        {
            Console.WriteLine("Destructor Called ID: {0} and Name: {1}", id, name);
        }
    }
}
