using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginModule
{
    public class Login
    {
        public static string LoginIn(string name, string password)
        {
            if (name == null || password == null)
            {
                return "Provide Credential";
            }
            else if (name == "Sam" && password == "Sam@123")
            {
                return "Login Success";
            }
            else
            {
                return "Login Failed";
            }
        }
    }
}
