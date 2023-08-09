using Microsoft.SqlServer.Server;
using System;
using System.Collections;

namespace Exercise01
{
    public class Program
    {
        static ArrayList fruitList;
        static void Main(string[] args)
        {
            fruitList = new ArrayList();
            fruitList.Add("apple");
            fruitList.Add("banana");
            fruitList.Add("cherry");
            fruitList.Add("date");
            fruitList.Add("elderberry");
            string opt1;
            do
            {
                Console.WriteLine("Enter Function: ");
                Console.WriteLine("1. Search");
                Console.WriteLine("2. Add");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Print ALL");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the Fruit Name want to search: ");
                            string fruitName = Console.ReadLine();
                            int index = SearchItem(fruitName);

                            if (index == -1)
                            {
                                Console.WriteLine("Fruit is not at List");
                            }
                            else
                            {
                                index = index + 1;
                                Console.WriteLine("Fruit is at Index: " + index);
                            }
                            PrintList();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the Fruit you want to add");
                            string fruitName = Console.ReadLine();
                            Console.WriteLine("Enter the position :");
                            int pos = int.Parse(Console.ReadLine());
                            AddItem(fruitName, pos);
                            PrintList();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the Fruit you want to delete");
                            string fruitName = Console.ReadLine();
                            RemoveItem(fruitName);
                            PrintList();
                            break;

                        }
                    case 4:
                        {
                            PrintList();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("WRONG CHOICE!!");
                            break;
                        }
                }
                Console.WriteLine("Enter y to go again: ");
                opt1 = Console.ReadLine();
            } while (opt1 == "y");
            Console.ReadKey();
        }

        public static void PrintList()
        {
            Console.WriteLine("Fruit List as Follows: ");
            foreach (var fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }
        }

        public static int SearchItem(string fruitName)
        {
            return fruitList.IndexOf(fruitName);
        }
        public static void AddItem(string fruitName, int position)
        {
            if (SearchItem(fruitName) != -1)
            {
                Console.WriteLine("Item Already Existed");
            }
            else
            {
                if (position <= fruitList.Count+1)
                {
                    fruitList.Insert(position-1, fruitName);
                }
                else
                {
                    Console.WriteLine("Not Possible!");
                }
            }
        }

        public static void RemoveItem(string fruitName)
        {
            if(SearchItem(fruitName) == -1)
            {
                Console.WriteLine("Item Doesn't Exist");
            }
            else
            {
                fruitList.Remove(fruitName);
            }
        }
    }
}
