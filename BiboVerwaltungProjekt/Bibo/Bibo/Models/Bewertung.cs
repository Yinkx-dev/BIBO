using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Models
{
    [Table("Bewertung")]
    public class Bewertung
    {
        [Key]
        public int BewertungsID { get; set; }
        public int BuchID { get; set; }
        public int KundenID { get; set; }
        public int Sterne { get; set; }
        public string Ueberschrift { get; set; }
        public string Text { get; set; }
        public string Datum { get; set; }
        public bool MitName { get; set; }
    }
}
