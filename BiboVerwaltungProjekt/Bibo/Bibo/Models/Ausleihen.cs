using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Rueckgabedatum { get; set; }
    }
}
