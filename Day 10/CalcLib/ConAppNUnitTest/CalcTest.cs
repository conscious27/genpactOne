using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using CalcLib;
namespace ConAppNUnitTest
{
    [TestFixture]
    public class CalcTest
    {
        CalcUtil calc = new CalcUtil();
        [SetUp]
        public void Setup()
        {
            calc = new CalcUtil();
        }
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(20, calc.Add(10, 10));
        }
        [Test]
        public void TestSub()
        {
            Assert.AreEqual(10, calc.Subtract(20, 10));
        }
        [Test]
        public void TestMulti()
        {
            Assert.AreEqual(800, calc.Multiply(40, 20));
        }
        [Test]
        public void TestDividebyZero()
        {
            Assert.Throws<System.Exception>(() => calc.Divide(10, 0));
        }
        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(20, calc.Divide(200, 10));
        }
        [Test]
        public void TestPrime()
        {
            Assert.AreEqual(true, calc.isPrime(3));
        }
    }
}
