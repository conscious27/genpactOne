﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class ValidationException : Exception
    {
        public ValidationException(string msg):base(msg) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Register();
            Console.ReadKey();
        }


    }
}
