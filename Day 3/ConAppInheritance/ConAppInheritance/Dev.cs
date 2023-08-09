using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritance
{
   public class Dev:Emp
    {
        //public string Project { get; set; }
        //public string Domain { get; set; }

        string project;
        string domain;

        public Dev()
        {
            Console.WriteLine("Developer Class");
            project = "not assign";
            domain = "not assign";
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Project: "+project);
            Console.WriteLine("Domain: "+domain);
        }

        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Project to be register: ");
            project = Console.ReadLine();
            Console.WriteLine("Enter Domain to be register: ");
            domain = Console.ReadLine();
        }
    }
}
