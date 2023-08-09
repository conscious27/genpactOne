using System;
using CalcLib;
namespace UsageExample
{
    public static class TopClass {
        public static string Compare(this Calculation obj, double num1, double num2)
        {
            string result;
            if (num1 == num2)
            {
                result = num1 + "and" + num2 + "both are equal";
            }
            else
            {
                result = num1 > num2 ? num1 + "is greater" : num2 + "is greater";
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            string choice;

            do
            {
                Calculation cal = new Calculation();
                Console.WriteLine("Enter First Number: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose Operations: \n 1.Add \n 2.Div \n 3.Multi \n 4.Diff \n 5.Avg \n 6.Compare");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            result = cal.Add(num1, num2);
                            Console.WriteLine("Result after adding {0} and {1} = \t {2}", num1, num2, result);
                            break;
                        }
                    case 2:
                        {
                            result = cal.Div(num1, num2);
                            Console.WriteLine("Result after dividing {0} and {1} = \t {2}", num1, num2, result);
                            break;
                        }
                    case 3:
                        {
                            result = cal.Multi(num1, num2);
                            Console.WriteLine("Result after multiplying {0} and {1} = \t {2}", num1, num2, result);
                            break;
                        }
                    case 4:
                        {
                            result = cal.Diff(num1, num2);
                            Console.WriteLine("Result after subtracting {1} from {0} = \t {2}", num1, num2, result);
                            break;
                        }
                    case 5:
                        {
                            result = cal.Avg(num1, num2);
                            Console.WriteLine("Result after averaging {1} and {0} = \t {2}", num1, num2, result);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine($"Result after Comparing {num1} and {num2} = \t" +cal.Compare(num1, num2));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong Operation!!");
                            return;
                        }
                }
                Console.WriteLine("Enter Choice for repeat(y): ");
                choice = Console.ReadLine();
            } while (choice == "y");
            Console.ReadKey();
        }
    }
}
