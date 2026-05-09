using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibo.Models
{
    [Table("Ausleihen")]
    public class Ausleihen
    {
        [Key]
        public int AusleihID { get; set; }
        public int KundenID { get; set; }
        public string ISBN { get; set; }
        public string Ausleihdatum { get; set; }
        public string Rueckgabedatum { get; set; } = "";
    }
}
