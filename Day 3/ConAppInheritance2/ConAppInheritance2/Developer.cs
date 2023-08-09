using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritance2
{
    public class Developer:Employee
    {
        string project;
        string domain;

        public Developer(int id, string name, double salary, DateTime doj, 
            string project, string domain):base(id, name, salary, doj)
        {
            this.project = project;
            this.domain = domain;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Project:\t{project} \n Domain:\t{domain}");
        }

    }
}
