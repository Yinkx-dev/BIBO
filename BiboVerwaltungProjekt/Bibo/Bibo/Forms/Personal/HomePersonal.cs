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
    public partial class HomePersonal : UI_Helper
    {
        public HomePersonal()
        {
            InitializeComponent();
        }

        //Logout
        private void logoutButtonPersonal_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<Login>(this);
        }

        //Neuen Kunden anlegen
        private void buttonNeuerKunde_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<Kundenmodifikation>(this, new Kunde());
        }

        //Neues Buch anlegen
        private void buttonNeuesBuch_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<Buchmodifikation>(this, new Buch());
        }

        //Zu Kundenliste
        private void buttonKundenliste_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<Kundenliste>(this);
        }

        //Zu BuecherlistePersonal
        private void buttonBuecherliste_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<BuecherlistePersonal>(this);
        }

        //Zu LeihstatusPersonal
        private void buttonLeihstatus_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<LeihstatusPersonal>(this);
        }
    }
}
