using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double length;
            double breadth;
            double area;
            char option;
            do
            {
                Console.WriteLine("What you want to find: ");
                Console.WriteLine("1. For Finding Area");
                Console.WriteLine("2. For Finding Length");
                Console.WriteLine("3. For Finding Breadth");
                choice = int.Parse(Console.ReadLine());


                Rectangle rect = new Rectangle();

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the Length:");
                            length = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the breadth:");
                            breadth = double.Parse(Console.ReadLine());
                            area = rect.FindArea(length, breadth);

                            Console.WriteLine("Area of Rectangle is: " + area);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the Area:");
                            area = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the breadth:");
                            breadth = double.Parse(Console.ReadLine());
                            length = rect.FindLength(area, breadth);

                            Console.WriteLine("Length of Rectangle is: " + length);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the Area:");
                            area = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the length:");
                            length = double.Parse(Console.ReadLine());
                            breadth = rect.FindBreadth(area, length);

                            Console.WriteLine("Breadth of Rectangle is: " + breadth);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong Choice!");
                            break;
                        }
                }
                Console.WriteLine("Want to do it again press y:");
                option = char.Parse(Console.ReadLine());
            } while (option == 'y');
            Console.ReadKey();
        }
    }
}
