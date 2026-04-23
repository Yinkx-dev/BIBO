using Bibo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.ViewModels
{
    public class BuecherlistePersonalViewModel
    {
        public Buch Buch { get; set; }
        public Ausleihen Ausleihen { get; set; }
        public Kunde KundeLeih { get; set; }


        public bool IstAusgeliehen { get; set; }
    }
}
