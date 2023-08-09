using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProperties
{
    public class Emp
    {
        int id;
        string name;

        public int ID { 
            get 
            {
                if (id == -1)
                {
                    Console.WriteLine("Invalid ID!");
                }
                return id; 
            } 
            set 
            { 
                if (value >= 1)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Invalid ID!!");
                    id = -1;
                }
            } 
        }
        public string Name { 
            get {
                if (name.Length >= 6)
                {
                    return name;
                }
                return "invalid name";
            } set { name = value; } }
    }
}
