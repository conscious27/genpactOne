using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    [Serializable]
    public class Customer
    {
        int id;
        string name;
        DateTime dob;
        string city;
        string address;

        public Customer(string name,  DateTime dob)
        {
            this.name = name;
            this.dob = dob;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime Dob { get {  return dob; } set {  dob = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string City { get { return city; } set { city = value; } }
    }
}
