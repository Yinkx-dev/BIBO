using Bibo.Core;
using Bibo.Models;
using System;

namespace Bibo.Forms.Personal
{
    public partial class HomePersonal : UI_Helper
    {
        private CursorManager cursorManager;

        public HomePersonal()
        {
            InitializeComponent();
            CursorChangeOnInteractiveElements();
        }

        //Logout
        private void logoutButtonPersonal_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<Login>(this);
        }

        //Neuen Kunden anlegen
        private void buttonNeuerKunde_Click(object sender, EventArgs e)
        {
            //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
            int caller = 0;

            //Zu Kundenmodi neu
            Globals.NavigateToNextForm<Kundenmodifikation>(this, new Kunde(), caller);
        }

        //Neues Buch anlegen
        private void buttonNeuesBuch_Click(object sender, EventArgs e)
        {
            //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
            int caller = 0;

            //Zu Buchmodi neu
            Globals.NavigateToNextForm<Buchmodifikation>(this, new Buch(), caller);
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


        //Mauszeiger anpassen bei bestimmten ELementen
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachHandCursor(logoutButtonPersonal);
        }
    }
}
