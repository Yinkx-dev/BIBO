using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Models
{
    public class KundeAusgeliehenViewModel
    {
        public string ISBN { get; set; }
        public string Titel { get; set; }
        public string Autor { get; set; }
        public string Rueckgabedatum { get; set; }
    }
}
