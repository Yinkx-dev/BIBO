using Bibo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo.Forms.Personal
{
    public partial class Kundenmodifikation : UI_Helper
    {
        private Kunde _kunde;

        public Kundenmodifikation(Kunde kunde)
        {
            InitializeComponent();
            _kunde = kunde;
        }

        private void buttonHomeKundenModi_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }

        private void buttonAbbrechenKundenmodi_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }

        private void buttonZurueckZuKundenliste_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<Kundenliste>(this);
        }
    }
}
