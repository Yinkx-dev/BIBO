using Bibo.Models;
using Bibo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Services
{
    public class BuchdatenService : IBuchdatenService
    {
        private readonly Database _db;

        public BuchdatenService(Database db)
        {
            _db = db;   
        }

        //Liefert alle Daten aus den verschiedenen Tabellen zu einem Buch
        public BuchdatenViewModel GetBuchdaten(string isbn)
        {
            var buch = _db.QuerySingle<Buch>(
                "SELECT * FROM Buch WHERE ISBN = @isbn",
                new { isbn });

            var bewertungen = _db.QueryList<Bewertung>(
                "SELECT * FROM Bewertung WHERE BuchId = @buchId",
                new { buchId = buch.BuchID });

            var leihdaten = _db.QuerySingle<Ausleihen>(
                "SELECT * FROM Ausleihen WHERE ISBN = @isbn",
                new { isbn });

            //Buch unbewertet und verfügbar
            if(bewertungen == null || !bewertungen.Any() && leihdaten == null)
            {
                return new BuchdatenViewModel
                {
                    Buch = buch
                };
            }
            //Buch ausgeliehen, aber unbewertet
            if(bewertungen == null || !bewertungen.Any())
            {
                return new BuchdatenViewModel
                {
                    Buch = buch,
                    Leihdaten = leihdaten
                };
            }
            //Buch bewertet, aber verfügbar
            if (leihdaten == null)
            {
                return new BuchdatenViewModel
                {
                    Buch = buch,
                    Bewertungen = bewertungen
                };
            }
            //Buch bewertet UND ausgeliehen
            return new BuchdatenViewModel
            {
                Buch = buch,
                Bewertungen = bewertungen,
                Leihdaten = leihdaten
            };
        }
    }
}
