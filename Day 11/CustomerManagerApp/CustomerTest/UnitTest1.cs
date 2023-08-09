using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerLib;
namespace CustomerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]

        public void Setup()
        {
            DateTime dob = DateTime.Parse("27-06-2000");
            string filePath = "C:\\DotNet Training\\Day 11\\Customer\\Chaitanya_27-06-2000";
            Customer customer = new Customer("Chaitanya", dob);
            CustomerManager customerManager = new CustomerManager();
        }
        [TestMethod]
        public void TestRead()
        {
            CustomerManager.Write(customer, filePath);
        }
    }
}
