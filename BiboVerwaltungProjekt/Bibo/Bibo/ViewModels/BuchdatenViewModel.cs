using Bibo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.ViewModels
{
    public class BuchdatenViewModel
    {
        public Buch Buch { get; set; }
        public List<Bewertung> Bewertungen { get; set; } = new List<Bewertung>();
        public Ausleihen Leihdaten { get; set; } = new Ausleihen();


        //rausfinden, ob CurrentKunde Buch schon bewertet hat
        public Bewertung BewertungCurrentKunde
        {
            get
            {
                //Gar keine Bewertungen = CurrentKunde hat auch keine, logisch
                if(Bewertungen == null)
                {
                    return null;
                }

                //wenn eine Bewertung von CurrentKunde da, diese zurückgeben
                foreach(Bewertung bewertung in Bewertungen)
                {
                    if(bewertung.KundenID == Globals.CurrentKunde.KundenID)
                    {
                        return bewertung;
                    }
                }

                //nur "fremde" Bewertungen = BewertungCurrentKunde hier auch null
                return null;
            }
        }

        public bool HatCurrentKundeBewertet
        {
            get
            {
                //wenn bewertung da, ja, CurrentKunde hat bewertet
                return BewertungCurrentKunde != null;
            }
        }
    }
}
