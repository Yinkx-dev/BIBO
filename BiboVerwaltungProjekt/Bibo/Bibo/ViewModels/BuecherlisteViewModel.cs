namespace Bibo.Models
{
    public class BuecherlisteViewModel
    {
        public int BuchID { get; set; }
        public string ISBN { get; set; }
        public string Titel { get; set; }
        public string Autor { get; set; }
        public string Erscheinungsdatum { get; set; }
        public string Altersgruppe { get; set; }
        public string Genre { get; set; }
        public bool IstAusgeliehen { get; set; }
        public int SterneDurchschnitt { get; set; }
    }
}