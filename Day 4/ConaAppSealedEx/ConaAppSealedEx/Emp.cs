

using System;

namespace ConaAppSealedEx
{
    public class Emp
    {
        int id;
        string name;

        public Emp(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("ID:\t"+id+"\nName:\t"+name);
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Employee management!");
        }
    }
}
