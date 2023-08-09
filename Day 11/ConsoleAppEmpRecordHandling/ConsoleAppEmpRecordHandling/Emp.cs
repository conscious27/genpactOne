using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmpRecordHandling
{
    [Serializable]
    public class Emp
    {
        private int id;

        public int Id { get { return id; } set { id = value; } }

        private string name;

        public string Name { get { return name; } set {  name = value; } }

        private double salary;

        public double Salary { get { return salary; } set {  salary = value; } }
    }
}
