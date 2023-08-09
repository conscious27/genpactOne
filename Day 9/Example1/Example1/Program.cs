using System;
using System.IO;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "C:\\DotNet Training\\";
                string filename;
                Console.WriteLine("Enter Name: ");
                filename = Console.ReadLine();
                Console.WriteLine("Enter Date of Birth: ");
                string filedb = Console.ReadLine();
                string fpath = path + filename + "_" + filedb;

                // Creating the file
                if (File.Exists(fpath)) 
                {
                    Console.WriteLine("Filename Already exist");
                    return;
                }
                else
                {
                    File.Create(fpath).Close();
                    Console.WriteLine("File Created Successfully");
                }

                Console.WriteLine("Entering value in Files:");
                // Enter Values
                int id;
                DateTime dob = DateTime.Parse(filedb);
                string city;
                string address;

                Console.WriteLine("Enter Employee ID: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter City: ");
                city = Console.ReadLine();

                Console.WriteLine("Enter Address: ");
                address = Console.ReadLine();
                //string[] inputData = { "ID: " + id, "Name: "+filename, "Date of Birth: "+dob,
                //    "City: " + city, "Address: " + address };
                //File.WriteAllLines(fpath, inputData);

                using (StreamWriter sw = new StreamWriter(fpath))
                {
                    sw.WriteLine("ID: " + id);
                    sw.WriteLine("Name: " + filename);
                    sw.WriteLine("Date of Birth: " + dob);
                    sw.WriteLine("City: " + city);
                    sw.WriteLine("Address: " + address);
                }

                Console.WriteLine("Reading File:");
                // Read Values
                string[] lines;
                lines = File.ReadAllLines(fpath);
                foreach(var line in lines)
                {
                    Console.WriteLine(line);
                }
            } catch (Exception e)
            {
                Console.WriteLine("Error! "+e.Message);
            }
            finally
            {
                Console.WriteLine("END OF PROGRAM");
                Console.ReadKey();
            }
        }
    }
}
