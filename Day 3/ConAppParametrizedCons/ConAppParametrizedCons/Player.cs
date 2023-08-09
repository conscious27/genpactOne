using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppParametrizedCons
{
    public class Player
    {
        int pid;
        string pname;
        string pteam;

        //public Player(int pid, string pname, string pteam)
        //{
        //    this.pid = pid;
        //    this.pname = pname;
        //    this.pteam = pteam;
        //}

        public void Display()
        {
            Console.WriteLine("Player Details: ");
            Console.WriteLine("ID:\t"+pid+"\tName:\t"+pname+"\tTeam:\t"+pteam);
        }
    }
}
