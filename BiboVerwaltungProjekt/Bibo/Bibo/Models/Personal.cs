using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Models
{
    [Table("Personal")]
    public class Personal
    {
        [Key]
        public string Nutzername { get; set; }
        public string Kennwort { get; set; }
    }
}
