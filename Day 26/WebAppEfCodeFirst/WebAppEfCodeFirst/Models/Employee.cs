using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppEfCodeFirst.Models
{
    [Table("Employee")]
    public class Employee
    {
            [Key]
            public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
    }
}
