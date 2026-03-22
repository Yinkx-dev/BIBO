using Bibo.Models;
using System.Windows.Forms;

namespace Bibo
{
    public partial class BewertungBuch: UI_Helper
    {
        private Bewertung _bewertung;

        public BewertungBuch(Bewertung bewertung)
        {
            InitializeComponent();
            _bewertung = bewertung;
        }
    }
}
