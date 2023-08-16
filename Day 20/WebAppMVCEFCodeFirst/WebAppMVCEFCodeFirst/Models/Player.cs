using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVCEFCodeFirst.Models
{
    [Table("Player")]

    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerTeam { get; set; }
        public double Average { get; set; }
        public string PlayerType { get; set; }
    }
}
