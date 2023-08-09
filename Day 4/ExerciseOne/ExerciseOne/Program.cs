using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Enter the Product Info---");
            Product product = new Product();
            product.Register();
            

            Console.WriteLine("\n---Enter the Herbal Product Info---");
            HerbalProduct herbal = new HerbalProduct();
            herbal.Register();

            Console.WriteLine("*******Product Info*******");
            product.Display();

            Console.WriteLine("\n*******Herbal Product Info*******");
            herbal.Display();

            Console.ReadKey();
        }
    }
}
