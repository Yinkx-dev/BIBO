using Bibo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.ViewModels
{
    public class BewertungBuchViewModel
    {
        public Buch selectedBook { get; set; }
        public Bewertung bewertungBuch { get; set; }
        public bool vorhandeneBewBearbeiten { get; set; }
    }
}
