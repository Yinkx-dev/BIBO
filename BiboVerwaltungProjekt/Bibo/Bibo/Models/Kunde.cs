using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibo.Models
{
    [Table("Kunde")]
    public class Kunde
    {
        [Key]
        public int KundenID { get; set; }
        public string Nutzername { get; set; }
        public string Passwort { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geburtsdatum { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public int PLZ { get; set; }
        public string Wohnort { get; set; } 
    }
}
