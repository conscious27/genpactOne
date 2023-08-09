using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace OurFirstTestingApp
{
    public class OurFirstTestingApp
    {
        [TestFixture]
        public class UserLoginTest
        {
            [Test]
            public void SimpleEqualTest()
            {
                int num1 = 50;
                int num2 = 50;
                Assert.AreEqual(num1, num2);
            }

            [Test]
            public void LoginTest()
            {
                string nullResult = "Please enter username and password first";
                string failedResult = "Login Failed, Invalid Credential";
                string passResult = "Login Success";
                Assert.AreEqual(nullResult, UserLogin.Login(null, null));
                Assert.AreEqual(failedResult, UserLogin.Login("chaitanya", "123"));
                Assert.AreEqual(passResult, UserLogin.Login("sam126", "sam@126@126"));
            }
        }
    }
}
