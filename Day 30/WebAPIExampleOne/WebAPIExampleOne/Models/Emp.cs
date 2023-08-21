using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIExampleOne.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public string PhoneNumber { get; set; }
    }
}
