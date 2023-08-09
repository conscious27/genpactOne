using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmpRecordHandling
{
    internal class Program
    {

        public static void SerializeToFile<T>(string filepath, T data)
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filepath, FileMode.Create))
            {
                formatter.Serialize(fs, data);
            }
        }

        public static T DeSerializeFromFile<T>(string filepath)
        {
            IFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            {
               return (T)formatter.Deserialize(fs);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                List<Emp> listEmps = new List<Emp>()
                {
                    new Emp() { Id = 1, Name = "Chaitanya", Salary = 50000.00},
                    new Emp() { Id = 2, Name = "Rohit", Salary = 80000.80},
                    new Emp() { Id = 3, Name = "Gourav", Salary = 65000.60},
                    new Emp() { Id = 4, Name = "Amit", Salary = 75000.70}
                };

                string path = "";
                string filename = "Employees.txt";
                string fpath = filename + path;
                SerializeToFile(fpath, listEmps);

                List<Emp> desList = DeSerializeFromFile<List<Emp>>(fpath);

                foreach (Emp emp in desList)
                {
                    Console.Write("ID: \t" + emp.Id);
                    Console.Write("Name: \t" + emp.Name);
                    Console.Write("Salary: \t" + emp.Salary);
                    Console.WriteLine("\n");
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of File!");
                Console.ReadKey();
            }
        }
    }
}
