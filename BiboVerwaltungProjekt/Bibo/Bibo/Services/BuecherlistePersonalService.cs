using Bibo.Models;
using Bibo.ViewModels;
using System.Collections.Generic;

namespace Bibo.Services
{
    public class BuecherlistePersonalService
    {

        public BuecherlistePersonalService()
        {
        }


        //Alle Bücher besorgen, ausgeliehen oder nicht
        public List<BuecherlistePersonalViewModel> HoleGanzeBuecherlistePersonal()
        {
            var _buecher = Globals.Db.QueryList<Buch>("SELECT * FROM Buch");
            return GetBuecherlistePersonal(_buecher);
        }


        //Nur ausgeliehene Bücher besorgen
        public List<BuecherlistePersonalViewModel> HoleGelieheneBuecherlistePersonal()
        {
            var gelieheneBuecher = Globals.Db.QueryList<Buch>("SELECT * FROM Buch WHERE Buch.IstAusgeliehen = '1'");
            return GetBuecherlistePersonal(gelieheneBuecher);
        }


        //Alle gewünschten Bücher besorgen
        public List<BuecherlistePersonalViewModel> GetBuecherlistePersonal(List<Buch> buecher)
        {
            //Leere Liste von BuecherlistePersonalViewModel zum befüllen und returnen
            List<BuecherlistePersonalViewModel> BlPViewModelListe = new List<BuecherlistePersonalViewModel>();

            //GGF. Leih- und Kundendaten hinzufügen + bool setzen, ob Ausgeliehen
            foreach (var b in buecher)
            {
                //Das Buch muss in jedem Fall rein
                BuecherlistePersonalViewModel BlPVM = new BuecherlistePersonalViewModel
                {
                    Buch = b
                };

                //wenn es ausgeliehen ist, noch Leih- und Kundendaten dazu + bool
                if (b.IstAusgeliehen)
                {
                    Ausleihen a = Globals.Db.QuerySingle<Ausleihen>("SELECT * FROM Ausleihen WHERE ISBN = @isbn",
                        new { isbn = b.ISBN });
                    Kunde k = Globals.Db.QuerySingle<Kunde>("SELECT * FROM Kunde WHERE KundenID = @kundenid",
                        new { kundenid = a.KundenID });

                    BlPVM.Ausleihen = a;
                    BlPVM.KundeLeih = k;
                    BlPVM.IstAusgeliehen = true;
                }

                BlPViewModelListe.Add( BlPVM );
            }

            return BlPViewModelListe;
        }
    }
}
