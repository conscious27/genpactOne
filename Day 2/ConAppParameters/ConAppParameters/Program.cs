//// Call By Value
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppParameters
//{
//    public class Calc
//    {
//        public void Incr(int num)
//        {
//            Console.WriteLine("Value of Num in Method before Increment \t" + num);
//            num += 5;
//            Console.WriteLine("Value of Num in Method after Increment \t" + num);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int myNum = 15;
//            Calc obj = new Calc();
//            Console.WriteLine("Value of myNum in Main before Calling Increment \t" + myNum);
//            obj.Incr(myNum);
//            Console.WriteLine("Value of myNum in Main after Calling Increment \t" + myNum);
//            Console.ReadKey();
//        }
//    }
//}

//// Call By Reference
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppParameters
//{
//    public class Calc
//    {
//        public void Incr(ref int num)
//        {
//            Console.WriteLine("Value of Num in Method before Increment \t" + num);
//            num += 5;
//            Console.WriteLine("Value of Num in Method after Increment \t" + num);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int myNum = 15;
//            Calc obj = new Calc();
//            Console.WriteLine("Value of myNum in Main before Calling Increment \t" + myNum);
//            obj.Incr(ref myNum);
//            Console.WriteLine("Value of myNum in Main after Calling Increment \t" + myNum);
//            Console.ReadKey();
//        }
//    }
//}

////out
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConAppParameters
//{
//    public class Calc
//    {
//        public void Incr(double salary, out double bonus)
//        {
//            bonus = salary * 0.17;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Calc calc = new Calc();
//            double salary = 50000;
//            double bonus;
//            calc.Incr(salary, out bonus);
//            Console.WriteLine("Salary is: \t" + salary +"\n Bonus: \t"+ bonus);
//            Console.ReadKey();
//        }
//    }
//}

//params
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppParameters
{
    public class Calc
    {
        public void Add(params double[] numbers )
        {
            double sum = 0;
            foreach ( double number in numbers )
            {
                sum += number;
            }
            Console.WriteLine("Total of Numbers: \t" + sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.Add(10, 20, 30);
            calc.Add(10.5, 20.5);
            Console.ReadKey();
        }
    }
}
