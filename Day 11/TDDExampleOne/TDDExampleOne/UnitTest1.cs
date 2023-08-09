using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDExampleOne
{
    [TestClass]
    public class UnitTest1
    {
        CalcLib.Calc objcal;
        [TestMethod]
        public void WelcomeTest()
        {
            string result = "Welcome to CalcLib";
            objcal = new CalcLib.Calc();
            string actualResult = objcal.Welcome();
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void AddTest() 
        { 
            int result, num1, num2;
            num2 = 2;
            num1 = 3;
            result = num1 + num2;
            objcal = new CalcLib.Calc();
            Assert.AreEqual(result, objcal.Add(num1, num2));
        }

        [TestMethod]
        public void DivTest()
        {
            int result, num1, num2;
            num2 = 2;
            num1 = 3;
            result = num1 / num2;
            objcal = new CalcLib.Calc();
            Assert.AreEqual(result, objcal.Div(num1, num2));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]

        public void DivByZeroTest()
        {
            int result, num1, num2;
            num2 = 0;
            num1 = 2;
            result = num1 / num2;
            objcal = new CalcLib.Calc();
            Assert.AreEqual(result, objcal.Div(num1, num2));
        }
    }
}
