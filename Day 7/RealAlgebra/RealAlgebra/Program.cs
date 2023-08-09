using System;
using ShapeAreaLib;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
                string choice;
            do
            {
                Console.WriteLine("Choose Shape:");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Triangle");

                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        {
                            Rectangle rec = new Rectangle();
                            Console.WriteLine("Enter Lenght:");
                            double lenght = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Breadth: ");
                            double breadth = double.Parse(Console.ReadLine());

                            double result = rec.Area(lenght, breadth);
                            Console.WriteLine("Result: " + result);

                            break;
                        }
                    case 2:
                        {
                            Square sq = new Square();
                            Console.WriteLine("Enter Lenght:");
                            double lenght = double.Parse(Console.ReadLine());

                            double result = sq.Area(lenght);
                            Console.WriteLine("Result: " + result);
                            break;
                        }
                    case 3:
                        {
                            Circle circ = new Circle();
                            Console.WriteLine("Enter Radius:");

                            double radius = double.Parse(Console.ReadLine());

                            double result = circ.Area(radius);
                            Console.WriteLine("Result: " + result);
                            break;
                        }
                    case 4:
                        {
                            Triangle tr = new Triangle();
                            Console.WriteLine("Enter Height:");
                            double height = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Breadth: ");
                            double breadth = double.Parse(Console.ReadLine());

                            double result = tr.Area(breadth, height);
                            Console.WriteLine("Result: "+result);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong Choice!");
                            return;
                        }

                }
                Console.WriteLine("Enter y to continue again:");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
            Console.ReadKey();
        }
    }
}
