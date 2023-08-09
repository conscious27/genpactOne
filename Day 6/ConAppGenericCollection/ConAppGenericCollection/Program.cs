using System;
using System.Collections;
using System.Collections.Generic;

namespace ConAppGenericCollection
{
    internal class Program
    {
        static List<Emp> empList = new List<Emp>()
        {
            new Emp() {Id = 101, Name = "Chaitanya", Designation="Engineer", Salary=80000,
            Doj = new DateTime(day:12, month:06, year:2022)},
            new Emp() {Id = 102, Name = "Amit", Designation="Operations", Salary=90000,
            Doj = new DateTime(day:24, month:03, year:2023)}
        };
        static void Main(string[] args)
        {
            //Non-Generic Classes
            //ArrayList arrayList = new ArrayList();
            //Hashtable hashtable = new Hashtable();
            //SortedList sortedList = new SortedList();
            //Queue queue = new Queue();
            //Stack stack = new Stack();

            //ArrayList arrayList = new ArrayList()
            //{
            //    "Sam", 12, DateTime.Now, 'A', 12.5F, 12.00
            //};
            //Console.WriteLine("Item \t DataType");
            //foreach (var item in arrayList) 
            //{
            //    Console.WriteLine(item + "\t" + item.GetType());
            //}

            //ArrayList nameList = new ArrayList()
            //{
            //    "sam", "ravi", "Ajay"
            //};

            //Console.WriteLine("Name List");
            //foreach(var  name in nameList)
            //{
            //    Console.WriteLine(name);
            //}
            //nameList.Add(12);
            //nameList.Add(DateTime.Now);
            //Console.WriteLine("Name List After adding two more values");
            //foreach(var name in nameList)
            //{
            //    Console.WriteLine( name);
            //}

            // Generic Collection

            //List<string> nameList = new List<string>()
            //{
            //    "Sam", "Ravi", "Amit"
            //};
            //Console.WriteLine("Name List as follows:");
            //foreach (string name in nameList)
            //{
            //    Console.WriteLine(name);
            //}
            //nameList.Add("Kishan");
            ////Don't work here
            ////nameList.Add(12);
            //Console.WriteLine("Name List after addition as follows:");
            //foreach (string name in nameList)
            //{
            //    Console.WriteLine(name);
            //}
            string opt;
            do {
                opt = "n";
                int choice;
                Console.WriteLine("*** Choose the Operation ***");
                Console.WriteLine("1. Insert Employee Details");
                Console.WriteLine("2. Update Employee Details");
                Console.WriteLine("3. Delete Employee Detials");
                Console.WriteLine("4. Print Employee Details");
                Console.WriteLine("5. Print All Employee Details");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the Employee Detais: ");
                            Emp emp = new Emp();
                            InsertEmp(emp);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the Employee's ID: ");
                            int id = int.Parse(Console.ReadLine());
                            UpdateEmp(id);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the Employee's ID: ");
                            int id = int.Parse(Console.ReadLine());
                            DeleteEmp(id);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the Employee's ID: ");
                            int id = int.Parse(Console.ReadLine());
                            PrintEmpbyId(id);
                            break;
                        }
                    case 5:
                        {
                            PrintAll();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.WriteLine("Enter y top go again:");
                opt = Console.ReadLine().ToLower();
            } while (opt == "y");
            Console.ReadKey();
        }

        public static void InsertEmp(Emp emp)
        {
            bool idAvailable = false;
            do
            {
                Console.WriteLine("Enter ID: ");
                emp.Id = int.Parse(Console.ReadLine());
                if (FindEmp(emp.Id)!=null)
                {
                    Console.WriteLine("ID Already Chosen. Please choose different ID!");
                    idAvailable = true;
                }
            } while (idAvailable == true);
            Console.WriteLine("Enter Name: ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Designation: ");
            emp.Designation = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter DOJ:");
            emp.Doj = DateTime.Parse(Console.ReadLine());

            empList.Add(emp);
        }

        public static void PrintEmp(Emp emp)
        {
            int index = empList.IndexOf(emp);
            if (index != -1)
            {
                Console.WriteLine("ID: " + emp.Id);
                Console.WriteLine("Name: " + emp.Name);
                Console.WriteLine("Designation: " + emp.Designation);
                Console.WriteLine("Salary: " + emp.Salary);
                Console.WriteLine("Date of Joining: " + emp.Doj);
            }
            else
            {
                Console.WriteLine("Error! This Employee is not Registered!");
            }

        }

        public static void PrintEmpbyId(int id)
        {
            Emp emp = FindEmp(id);

            if(emp == null)
            {
                Console.WriteLine("ID don't Exist!!!!!!!!");
                return;
            }
                    Console.WriteLine("ID: " + emp.Id);
                    Console.WriteLine("Name: " + emp.Name);
                    Console.WriteLine("Designation: " + emp.Designation);
                    Console.WriteLine("Salary: " + emp.Salary);
                    Console.WriteLine("Date of Joining: " + emp.Doj);
        }

        public static void PrintAll()
        {
            Console.WriteLine("ID \t Name \t Designation \t Salary \t Date of Joining");
            foreach (Emp emp in empList)
            {
                Console.WriteLine($"{emp.Id} \t {emp.Name} \t {emp.Designation} \t {emp.Salary} \t {emp.Doj}");
            }
        }

        public static void UpdateEmp(int id)
        {

            Emp emp = FindEmp(id);

            if(emp == null)
            {
                Console.WriteLine("ID doesn't exist!!!!!");
            }

                    Console.WriteLine("Current Employee Record: ");
                    PrintEmp(emp);

                    Console.WriteLine("Enter What to Update:");
                    Console.WriteLine("1. ID");
                    Console.WriteLine("2. Name");
                    Console.WriteLine("3. Designation");
                    Console.WriteLine("4. Salary");
                    Console.WriteLine("5. Date of Joining");

                    int choice = int.Parse(Console.ReadLine());
                    
                    switch(choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter Updated ID: ");
                                emp.Id = int.Parse(Console.ReadLine());
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter Updated Name: ");
                                emp.Name = Console.ReadLine();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Enter Updated Designation: ");
                                emp.Designation = Console.ReadLine();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Enter Updated Salary: ");
                                emp.Salary = double.Parse(Console.ReadLine());
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Enter Updated ID: ");
                                emp.Doj = DateTime.Parse(Console.ReadLine());
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No Such Field Available");
                                break;
                            }
            }
            PrintEmp(emp);
        }

        public static void DeleteEmp(int id)
        {
            Emp employee = FindEmp(id);
            if(employee == null)
            {
                Console.WriteLine("Employee ID don't exist!!!!");
                return;
            }
            empList.Remove(employee);
            Console.WriteLine("Employee Data Sucessfully Removed!");      

        }

        public static Emp FindEmp(int id)
        {
            foreach(Emp emp in empList)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}
