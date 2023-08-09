using System;
using System.Collections.Generic;


namespace EmployeesLibrary
{
    public class EmployeeHandler
    {
        static List<Employee> listEmployees;

        public EmployeeHandler()
        {
            listEmployees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            listEmployees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            listEmployees.Remove(employee);
        }

        public Employee Get(int id)
        {
            return listEmployees[id];
        }

        public void Print()
        {
            foreach (var  employee in listEmployees)
            {
                Console.WriteLine("ID: "+employee.Id);
                Console.WriteLine("Name: "+employee.Name);
                Console.WriteLine("Salary: "+employee.Salary);
                Console.WriteLine("Date of Joining: "+employee.Doj);
            }
        }
    }
}
