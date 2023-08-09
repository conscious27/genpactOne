using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProperties
{
    public class EmpSalary
    {
        double salary;
        static double tax;

        public EmpSalary(double sal)
        {
            salary = sal;
        }

        public double Salary { get { return salary; } }
        public static double Tax { get { return tax; } set { tax = value; } }
    }
}
