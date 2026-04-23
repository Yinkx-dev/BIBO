using Bibo.Models;
using Bibo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Services
{
    public class BuecherlistePersonalService
    {
        private readonly Database _db;

        public BuecherlistePersonalService(Database db)
        {
            _db = db;
        }


        //Alle Bücher besorgen, ausgeliehen oder nicht
        public List<BuecherlistePersonalViewModel> HoleGanzeBuecherlistePersonal()
        {
            var _buecher = _db.QueryList<Buch>("SELECT * FROM Buch");
            return GetBuecherlistePersonal(_buecher);
        }


        //Nur ausgeliehene Bücher besorgen
        public List<BuecherlistePersonalViewModel> HoleGelieheneBuecherlistePersonal()
        {
            var gelieheneBuecher = _db.QueryList<Buch>("SELECT * FROM Buch WHERE Buch.IstAusgeliehen = '1'");
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
                    Ausleihen a = _db.QuerySingle<Ausleihen>("SELECT * FROM Ausleihen WHERE ISBN = @isbn",
                        new { isbn = b.ISBN });
                    Kunde k = _db.QuerySingle<Kunde>("SELECT * FROM Kunde WHERE KundenID = @kundenid",
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
