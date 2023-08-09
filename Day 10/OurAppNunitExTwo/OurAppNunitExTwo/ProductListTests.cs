using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OurAppNunitExTwo
{
    [TestFixture]
    public class ProductListTests
    {
        private ProductList<string> prodList;

        [SetUp]

        public void Setup()
        {
            prodList = new ProductList<string>();
            prodList.AddProduct("Laptop");
            prodList.AddProduct("Mobile");
            prodList.AddProduct("Tablet");
        }

        [Test]
        public void CountTestOnAdd()
        {
            prodList.AddProduct("Camera");
            Assert.AreEqual(4, prodList.Count);
        }

        [Test]
        public void CountTestOnRemove()
        {
            prodList.RemoveProduct("Tablet");
            Assert.AreEqual(2, prodList.Count);
        }

        [Test]
        public void ContainsTestNotExist()
        {
            Assert.AreEqual(false, prodList.Contains("Projector"));
        }
        [Test]
        public void ContainsTestExist() 
        {
            Assert.AreEqual(true, prodList.Contains("Mobile"));
        }
    }
}
