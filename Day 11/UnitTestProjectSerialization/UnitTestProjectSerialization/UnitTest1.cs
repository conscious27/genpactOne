using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace UnitTestProjectSerialization
{
    [TestClass]
    public class UnitTest1
    {
        Customer customer;
        [TestInitialize]
       
        public void Setup()
        {
            customer = new Customer() { Id = 12, Name = "Rao Ranjan R." };
        }

        [TestMethod]
        public void TestSerialization()
        {
            IFormatter formatter = new BinaryFormatter();
            string filepath = "C:\\DotNet Training\\Day 11\\Customer\\Customer.txt";
            using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(fs, customer);
            }
            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                Customer desCustomer = (Customer)formatter.Deserialize(fs);
                Assert.AreEqual(customer.Id, desCustomer.Id);
                Assert.AreEqual(customer.Name, desCustomer.Name);
            }
            File.Delete(filepath);
        }
    }
}
