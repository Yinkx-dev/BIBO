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
    public partial class Buchmodifikation : UI_Helper
    {
        private Buch _buch;

        public Buchmodifikation(Buch buch)
        {
            InitializeComponent();
            _buch = buch;
        }

        private void buttonHomeBuchModi_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }

        private void buttonAbbrechenBuchmodi_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }

        private void buttonZurueckBuecherliste_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<BuecherlistePersonal>(this);
        }
    }
}
