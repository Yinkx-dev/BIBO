using Bibo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo.Forms.Personal
{
    public partial class Kundenmodifikation : UI_Helper
    {
        //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
        private int _caller;

        private Kunde _kunde;

        public Kundenmodifikation(Kunde kunde, int caller)
        {
            InitializeComponent();
            _kunde = kunde;
            _caller = caller;

            InsertData();
        }


        //Ggf. Übergebene Daten anzeigen
        private void InsertData()
        {
            if (_kunde.Vorname != null)
            {
                //"simple" Textboxen
                textBoxVorname.Text = _kunde.Vorname;
                textBoxNachname.Text = _kunde.Nachname;
                textBoxStrasse.Text = _kunde.Strasse;
                textBoxHausnummer.Text = _kunde.Hausnummer;
                textBoxPostleitzahl.Text = _kunde.PLZ.ToString();
                textBoxWohnort.Text = _kunde.Wohnort;
                textBoxNutzername.Text = _kunde.Nutzername;
                textBoxPasswort.Text = _kunde.Passwort;

                //Textbox Geburtsdatum [Umwandlung in richtiges Format]
                DateTime date = DateTime.ParseExact(_kunde.Geburtsdatum, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                datePickerGebDatum.Value = date;
            }
        }


        //Zurück zu Home
        private void buttonHomeKundenModi_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }


        //Abbrechen und zurück zu Ursprungs-Form
        private void buttonAbbrechenKundenmodi_Click(object sender, EventArgs e)
        {
            //Navigation nach Ursprungs-Form
            //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
            if (_caller == 0)
            {
                //Zu Home
                Globals.NavigateToNextForm<HomePersonal>(this);
            }
            if (_caller == 1)
            {
                //Zu Kundenliste
                Globals.NavigateToNextForm<Kundenliste>(this);
            }
        }


        //Zu Kundenliste
        private void buttonZurueckZuKundenliste_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<Kundenliste>(this);
        }
    }
}
