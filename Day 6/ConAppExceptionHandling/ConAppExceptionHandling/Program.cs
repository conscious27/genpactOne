//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppExceptionHandling
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int luckynumber;

//            try
//            {
//                Console.WriteLine("Enter Lucky Number: ");
//                luckynumber = int.Parse(Console.ReadLine());
//                if ((luckynumber != 0) && (luckynumber >= 7))
//                {
//                    Console.WriteLine("Common Lucky Number");
//                }
//                else
//                {
//                    Console.WriteLine($"Special Choice: {luckynumber}");
//                }
//            } catch (Exception e)
//            {
//                Console.WriteLine("Error! "+e.Message);
//            }
//            finally
//            {
//                Console.WriteLine("** End of Program **");
//            }
//            Console.ReadKey();
//        }
//    }
//}

using System;

namespace ConAppExceptionHandling
{
    public class Calculation
    {
        public static byte Add(byte num1, byte num2)
        {
            var result = num1 + num2;
            return (byte)result;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter First Number: ");
                    byte fNum = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number: ");
                    byte sNum = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Result After adding {0} and {1) = \t {2}", fNum, sNum, Calculation.Add(fNum,sNum));
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Erro! " + fe.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! "+e.Message);
                }
                finally { Console.WriteLine("End of Program"); }
                Console.ReadKey();
            }

        }
    }
}

