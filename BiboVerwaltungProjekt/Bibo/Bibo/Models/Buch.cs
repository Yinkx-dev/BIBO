using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Models
{
    [Table("Buch")]
    public class Buch
    {
        [Key]
        public int BuchID { get; set; }
        public string ISBN { get; set; }
        public string Titel { get; set; }
        public string Kurzbeschreibung { get; set; }
        public string Autor { get; set; }
        public string Erscheinungsdatum { get; set; }
        public string Altersgruppe { get; set; }
        public string Genre { get; set; }
        public bool IstAusgeliehen { get; set; }
    }
}
