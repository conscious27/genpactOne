using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppFileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string path = "C:\\DotNet Training\\Day 9";
            //    Console.WriteLine("Enter Folder Name: ");
            //    string folderName = Console.ReadLine();
            //    string fpath = path + folderName;
            //DirectoryInfo di = new DirectoryInfo(fpath);
            //    if (di.Exists)
            //    {
            //        Console.WriteLine("This Directory Already Exists");
            //    }
            //    else
            //    {
            //        di.Create();
            //        Console.WriteLine("Folder Creation Success");
            //    }
            //} catch (Exception ex)
            //{
            //    Console.WriteLine("Error! "+ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("End of Program!");
            //    Console.ReadKey();
            //}

            try
            {
                string path;
                Console.WriteLine("Enter Directory Path");
                path = Console.ReadLine();
                DirectoryInfo di = new DirectoryInfo(path);
                if (di.Exists)
                {
                    FileInfo[] files = di.GetFiles();
                    Console.WriteLine($"{path} contains following files");
                    foreach(FileInfo file in files)
                    {
                        Console.WriteLine("Name: "+file.Name);
                        Console.WriteLine("\t Full Name: "+file.FullName);
                        Console.WriteLine("\t Length: "+file.Length);
                        Console.WriteLine("\n");
                    }
                }
                else
                {
                    Console.WriteLine($"No such {path} Directory exists!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program!");
                Console.ReadKey();
            }
        }
    }
}
