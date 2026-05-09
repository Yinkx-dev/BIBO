using System.ComponentModel.DataAnnotations;

namespace Bibo.Models
{
    //"Gerüst" für Buch und eventuelle zukünftige andere Arten von Medien
    public abstract class Medium
    {
        public string Titel { get; set; }
        public string Kurzbeschreibung { get; set; }
        public string Erscheinungsdatum { get; set; }
        public string Altersgruppe { get; set; }
        public string Genre { get; set; }
        public bool IstAusgeliehen { get; set; }
    }
}
