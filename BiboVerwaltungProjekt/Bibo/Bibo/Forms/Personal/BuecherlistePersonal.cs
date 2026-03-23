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
    public partial class BuecherlistePersonal : UI_Helper
    {
        public BuecherlistePersonal()
        {
            InitializeComponent();
        }

        private void buttonHomeBuecherListePersonal_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }

        private void buttonNeuesBuch_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<Buchmodifikation>(this, new Buch());
        }
    }
}
