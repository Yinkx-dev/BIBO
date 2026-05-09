using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibo.Models
{
    [Table("Personal")]
    public class Personal
    {
        [Key]
        public string Nutzername { get; set; }
        public string Kennwort { get; set; }
    }
}
