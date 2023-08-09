using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string path = "C:\\DotNet Training\\Day 11\\OurFolder\\OurFile.txt";
            //    Console.WriteLine("Serialization Example!");
            //    Person person = new Person();
            //    Console.WriteLine("Enter Person ID");
            //    person.PId = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Person Name:");
            //    person.Name = Console.ReadLine();
            //    Console.WriteLine("Enter Person City: ");
            //    person.PCity = Console.ReadLine();

            //    IFormatter formatter = new BinaryFormatter();

            //    Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            //    formatter.Serialize(stream, person);
            //    Console.WriteLine("Written Inside File");
            //    stream.Close();
            //} catch (Exception ex)
            //{
            //    Console.WriteLine("Error! " + ex.Message);
            //} finally { Console.ReadKey(); }

            string path = "C:\\DotNet Training\\Day 11\\OurFolder\\OurFile.txt";
            try
            {
                Console.WriteLine("***Deerialization Example!***");

                IFormatter formatter = new BinaryFormatter();

                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                Person myPerson = (Person)formatter.Deserialize(stream);
                Console.WriteLine("Person ID: "+myPerson.PId);
                Console.WriteLine("Person Name: "+myPerson.Name);
                Console.WriteLine("Person City: "+myPerson.PCity);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
            finally 
            {
                Console.WriteLine("End of Program!");
                Console.ReadKey(); }
        }
    }
}
