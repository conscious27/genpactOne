using Microsoft.AspNetCore.Mvc;
using WebAppMVCOne.Models;

namespace WebAppMVCOne.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "Welcome to Employee Index";
            return View();
        }
        public string Welcome()
        {
            return "Welcome to MVC";
        }

        public IActionResult Display()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee{Id=1, FName="Sam", LName="Dicosta", Salary=98000.75, DOJ=new DateTime(day:23, year:2021, month:11) },
                new Employee{Id=2, FName="Niraj", LName="Kumar", Salary=56000.90, DOJ=new DateTime(day:06, year:2022, month:09) },
                new Employee{Id=3, FName="Nitin", LName="Anethim", Salary=67000.90, DOJ=new DateTime(day:13, year:2023, month:02) },
                new Employee{Id=4, FName="Vijay", LName="Kiran", Salary=88000.80, DOJ=new DateTime(day:23, year:2022, month:01) },
                new Employee{Id=5, FName="Rohit", LName="V.", Salary=65000.50, DOJ=new DateTime(day:23, year:2023, month:01) },
                new Employee{Id=6, FName="Deep", LName="Garg", Salary=76000.90, DOJ=new DateTime(day:25, year:2022, month:11) },
            };

            return View(listEmployees);
        }
    }
}
