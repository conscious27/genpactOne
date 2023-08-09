using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Emp
    {
        int id;
        string name;
        double salary;
        static int no_of_emp=0;

        public int Id { get { return id; } set {  id = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public string Name { get {
                if (name.Length >= 6)
                {
                    return name;
                }
                return "invalid name";
            } set { name = value; } }

        public static int No_of_emp { get { no_of_emp += 1;  return no_of_emp;} }
    }
}
