
using System;

namespace ConaAppSealedEx
{
    public class Dev : Emp
    {
        string project;
        public Dev(int id, string name, string project) : base(id, name)
        {
            this.project = project;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Project:\t"+project);
        }

        public new void Welcome()
        {
            Console.WriteLine("Welcomw to Developer Management!");
        }
    }
}
