using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public  class CustomerManager
    {
        public void Write(Customer customer, string filePath)
        {
            Console.WriteLine("FilePath: " + filePath);
            try
            {
                Console.WriteLine("Enter Cutomer Id: ");
                customer.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Customer City: ");
                customer.City = Console.ReadLine();

                Console.WriteLine("Enter Customer Address: ");
                customer.Address = Console.ReadLine();

                //if (customer.Address == null || customer.City == null || customer.Name == null
                //    || customer.Dob == null) { return "Provide Details"; }

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filePath,FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, customer);
                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
        }

        public void Read(string filePath)
        {
            try
            {
                Console.WriteLine("*** Display Details ***");

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                Customer customer = (Customer)formatter.Deserialize(stream);
                Console.WriteLine("Customer ID: " + customer.Id);
                Console.WriteLine("Customer Name: " + customer.Name);
                Console.WriteLine("Customer Date of Birth: " + customer.Dob);
                Console.WriteLine("Customer City: " + customer.City);
                Console.WriteLine("Customer Address: " + customer.Address);
            } catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program!");
            }
        }
    }
}
