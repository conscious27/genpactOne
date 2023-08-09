using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LoginModule;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        //LoginTest using MSUnit
        //Write three test for all three types of cases e.g. login failed, login success and Provide Credential

        [TestMethod]
        public void LoginSuccess()
        {
            Assert.AreEqual("Login Success", Login.LoginIn("Sam", "Sam@123"));
        }
        [TestMethod]
        public void LoginFailed()
        {
            Assert.AreEqual("Login Failed", Login.LoginIn("Sa1m", "Sam@123"));
        }
        [TestMethod]
        public void NullLogin()
        {
            Assert.AreEqual("Provide Credential", Login.LoginIn(null, null));
        }
    }
}
