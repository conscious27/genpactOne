using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter Name");
            //// Data Type Declaration
            //string firstname;
            //firstname = Console.ReadLine();
            //Console.WriteLine("Welocme "+firstname);
            //Console.ReadKey();

            //string name;
            //int age;
            //char grade;
            //double fee;

            //Console.WriteLine("Enter Name: ");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter age: ");
            //age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Grade: ");
            //grade = char.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Fee: ");
            //fee = double.Parse(Console.ReadLine());
            //Console.WriteLine("First Way");
            //Console.WriteLine("Name : " + name + "\n Age: " + age + "\n Grade : " + grade + "\n Fee " + fee);
            //Console.WriteLine("Second Way");
            //Console.WriteLine($"Name : {name}\n Age: {age} \n Grade : {grade} \n Fee {fee} ");
            //Console.WriteLine("Third Way");
            //Console.WriteLine("Welcome {0} \n Name : {0} \n Age : {1} \n Grade : {2} \n Fee : {3}", name, age, grade, fee);
            //Console.ReadKey();

            //    int id;
            //    string name;
            //    char gender;
            //    double salary;
            //    DateTime DOJ;

            //    Console.WriteLine("Enter id : ");
            //    id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Name : ");
            //    name = Console.ReadLine();
            //    Console.WriteLine("Enter Gender : ");
            //    gender = char.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Salary :");
            //    salary = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Date :");
            //    DOJ = DateTime.Parse(Console.ReadLine());

            //    Console.WriteLine("ID \t Employee Name \t Employee Gender \t Emplyee Salary \t DOJ \n");
            //    Console.WriteLine("---\t---------------\t-----------------\t----------------\t-----\n");
            //    Console.WriteLine(id + "\t" + name + "\t" + gender + "\t\t\t" + salary + "\t" + DOJ +"\n");

            //    if (salary > 90000)
            //    {
            //        Console.WriteLine("You Have to pay 30% tax");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You have to pay 15% tax");
            //    }
            //    Console.ReadKey();
            //}

            string cCode;
            string lang;
            string choice;
            do
            {
                Console.WriteLine("Enter the cCode : ");
                cCode = Console.ReadLine();

                switch (cCode)
                {
                    case "us":
                    case "uk":
                        {
                            lang = "English";
                            break;
                        }

                    case "in":
                        {
                            lang = "Hindi, Punjabi, English, Tamil, Telugu";
                            break;
                        }

                    case "af":
                        {
                            lang = "Pashto, Dari";
                            break;
                        }

                    case "uae":
                    case "ksa":
                    case "om":
                        {
                            lang = "Arabic";
                            break;
                        }

                    default:
                        {
                            lang = "Not Found";
                            break;
                        }
                }

                Console.WriteLine("cCode : " + cCode + " and language(s) :\t" + lang);
                Console.WriteLine("Do yoy Wanna execute it again!!! if yes press y \n To exit press any key");
                choice  = Console.ReadLine().ToLower();
            } while (choice == "y");
            Console.ReadKey();
        }
    }
}
