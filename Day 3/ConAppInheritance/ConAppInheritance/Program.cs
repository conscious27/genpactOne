using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Emp obj = new Emp() { Id = 1, Name = "Chaitanya", Qal= "B.Tech", Doj= DateTime.Now };

            //Console.WriteLine("ENTER EMPLOYEE ID: ");
            //obj.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name: ");
            //obj.Name = Console.ReadLine();
            //Console.WriteLine("Enter Qualification: ");
            //obj.Qal = Console.ReadLine();
            //Console.WriteLine("Enter Date of Joining: ");
            //obj.Doj = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Employee Date as Follows: ");
            //Console.WriteLine("ID: \t "+obj.Id);
            //Console.WriteLine("Name: \t"+obj.Name);
            //Console.WriteLine("Qualification: \t"+obj.Qal);
            //Console.WriteLine("Date of Joining: \t"+obj.Doj);

            //Console.ReadKey();

            //Example 2
            //Dev dev = new Dev();
            //Console.WriteLine("Enter Developer Id: ");
            //dev.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Developer Name: ");
            //dev.Name = Console.ReadLine();
            //Console.WriteLine("Enter Developer Qualification: ");
            //dev.Qal = Console.ReadLine();
            //Console.WriteLine("Enter Developr Date of Joining: ");
            //dev.Doj = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Developer Projects: ");
            //dev.Project = Console.ReadLine();
            //Console.WriteLine("Enter Developer Domains: ");
            //dev.Domain = Console.ReadLine();

            //Console.WriteLine("Developer Details are as follows: ");
            //Console.WriteLine("ID: "+dev.Id);
            //Console.WriteLine("Name: "+dev.Name);
            //Console.WriteLine("Qualifications: "+dev.Qal);
            //Console.WriteLine("Date of Joining: "+dev.Doj);
            //Console.WriteLine("Project: "+dev.Project);
            //Console.WriteLine("Domain: "+dev.Domain);

            //Console.ReadKey();

            //Example-3

            //Dev dev = new Dev();
            //Console.ReadKey();

            //Example-4
            Emp emp = new Emp();
            emp.Register();
            emp.Display();

            Dev dev = new Dev();
            dev.Register();
            dev.Display();

            Console.ReadKey();
        }
    }
}
