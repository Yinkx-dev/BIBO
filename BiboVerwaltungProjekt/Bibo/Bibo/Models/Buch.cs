using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibo.Models
{
    [Table("Buch")]
    public class Buch : Medium
    {
        [Key]
        public int BuchID { get; set; }

        public string ISBN { get; set; }
        public string Autor { get; set; }
    }
}
