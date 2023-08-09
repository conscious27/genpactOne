using System;
using System.IO;

namespace FileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\DotNet Training\\";
            string filename;
            Console.WriteLine("Enter FIle Name: ");
            filename = Console.ReadLine();
            string fpath = path + filename;
            Console.WriteLine("Choose Operations: ");
            Console.WriteLine("1. Create File \n 2. Delete File \n 3. Read From File");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    {
                        File.Create(fpath).Close();
                        Console.WriteLine("File Created!!");
                        break;
                    }

                case 2:
                    {
                        if(File.Exists(fpath))
                        {
                            File.Delete (fpath);
                        }
                        else
                        {
                            Console.WriteLine("No such file {0} exist", fpath);
                        }
                        break;
                    }
                case 3:
                    {
                        string[] lines;
                        if (File.Exists(fpath))
                        {
                            lines = File.ReadAllLines (fpath);
                            foreach(var line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No such file" + fpath + "exists");
                        }
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Choice!");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
