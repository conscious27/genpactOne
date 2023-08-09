using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            End:
            LargeDataCollection largeData = new LargeDataCollection();
            
            do
            {
                Console.WriteLine("Enter the Operations: ");
                Console.WriteLine("1. Add Player \n 2. Remove Player \n 3. Search Player \n " +
                    " 4.Show All Player \n" + "5. Dispose All Players Data" + "\n 6. Exit");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the name of player want to Add: ");
                            string name = Console.ReadLine();

                            largeData.Add(name);

                            Console.WriteLine("\n total number of players: " +largeData.PlayerCount) ;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the name of player want to Remove: ");
                            string name = Console.ReadLine();

                            largeData.Remove(name);

                            Console.WriteLine("\n total number of players: " + largeData.PlayerCount);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the name of player want to Search: ");
                            string name = Console.ReadLine();

                            largeData.Search(name);

                            Console.WriteLine("\n total number of players: " + largeData.PlayerCount);

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n total number of players: " + largeData.PlayerCount);

                            largeData.DisplayAll();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Want to Remove all Data (press yes):");
                            string option = Console.ReadLine();

                            if(option == "yes")
                            {
                                largeData.Dispose();
                                goto End;
                            }
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input!");
                            break;
                        }
                }
                Console.WriteLine("Want to go again (Press y):");
                choice = Console.ReadLine().ToLower();
            }while (choice == "y") ;


            largeData.Dispose();
            Console.WriteLine("End of Program!");
            Console.ReadKey();
            
        }
    }
}
