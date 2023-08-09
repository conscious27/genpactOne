using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDisposableEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileHandler fileHandler = new FileHandler("Sam1.txt");
            //fileHandler.GetDetails();

            //fileHandler.Dispose();

            //FileHandler fileHandler2 = new FileHandler("History.txt");
            //fileHandler2.GetDetails();

            ////fileHandler2.Dispose();

            //FileHandler fileHandler3 = new FileHandler("Social.txt");
            //fileHandler3.GetDetails();

            ////fileHandler3.Dispose();
            ///
            using (FileHandler obj = new FileHandler("FileOne"))
            {
                obj.GetDetails();
            }
            using (FileHandler obj2 = new FileHandler("FileTwo"))
            {
                obj2.GetDetails();
            }
            Console.ReadKey();
        }
    }
}
