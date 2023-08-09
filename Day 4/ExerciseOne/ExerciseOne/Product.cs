
using System;

namespace ExerciseOne
{
    public class Product
    {
        int pid;
        string pname;
        double pprice;

        public virtual void Register()
        {
            Console.WriteLine("Enter the Product ID: ");
            pid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Product Name: ");
            pname = Console.ReadLine();

            Console.WriteLine("Enter the Product Price: ");
            pprice = double.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Product ID:\t"+pid+"\nProduct Name:\t"+pname+"\nProduct Price:\t"+pprice);
        }
    }
}
