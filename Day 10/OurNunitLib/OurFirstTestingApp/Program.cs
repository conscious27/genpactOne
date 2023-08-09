using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstTestingApp
{
    public class UserLogin
    {
        public static string Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Please enter username and password first";
            }
            else
            {
                if((username == "sam126") || (password == "sam@126@126"))
                {
                    return "Login Success";
                }
                else
                {
                    return "Login Failed, Invalid Credential";
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
