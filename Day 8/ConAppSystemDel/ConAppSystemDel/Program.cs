using System;
using System.Collections.Generic;

namespace ConAppSystemDel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of System Delegates
            //1. Func<>;
            // Definition : Encapsulates a method that has one parameter and returns a value of the type
            // specified by the TResult parameter.

            //Delegate Method
            //Func<int, int> square = delegate (int num)
            //{
            //    return num * num;
            //};

            //Lambda Method
            //Func<int, int> square = num => { return num * num; }; 

            //Console.WriteLine("Square of 6 is: "+square(6));


            // 2. Action
            // Definition: Encapsulates a method that has two parameters and does not return a value.
            //Action<int, int> add = (n1, n2) =>
            //{
            //    int result = n1 + n2;
            //    Console.WriteLine("Result after adding {0} and {1} = {2}", n1, n2, result);
            //};
            //add(1, 2);

            //3. Predicate
            string username;
            Console.WriteLine("Enter Username: ");
            username = Console.ReadLine();  
            Predicate<string> chkMember = IsAMember;
            if (chkMember(username) == true)
            {
                Console.WriteLine("Welcome You are a member of our group");
            }
            else
            {
                Console.WriteLine("Welcome Guest");
            }
            Console.ReadKey();
        }
        private static bool IsAMember(string name)
        {
            List<string> member = new List<string>()
            {
                "sam", "ravi", "amit", "vijay", "anita", "gaurav"
            };

            foreach (string memberName in member)
            {
                if (memberName == name)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
