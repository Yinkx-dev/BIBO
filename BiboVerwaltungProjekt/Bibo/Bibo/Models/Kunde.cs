using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Bibo.Models
{
    [Table("Kunde")]
    public class Kunde
    {
        [Key]
        public int KundenID { get; set; }
        public string Name { get; set; }
        public string Geburtsdatum { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public string Wohnort { get; set; }
    }
}
