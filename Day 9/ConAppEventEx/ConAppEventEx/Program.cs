using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEventEx
{
    public delegate string OurDel(string content);
    public class Program
    {
        public event OurDel Print;
        public static string Message(string content)
        {
            return "Our Program has a message for you![ " + content + "\r\n ]";
        }
        static void Main(string[] args)
        {
            Program program = new Program()
            {
                Print = new OurDel(Message)
            };
            Console.WriteLine("Event Invocation");
            Console.WriteLine(program.Print.Invoke("Welcome to Event"));
            Console.ReadKey();
        }
    }
}
