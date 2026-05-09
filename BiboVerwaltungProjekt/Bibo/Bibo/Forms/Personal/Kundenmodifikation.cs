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
        private bool _istNeuerKunde;

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

                //datePicker Geburtsdatum [Umwandlung in richtiges Format]
                DateTime date = DateTime.ParseExact(_kunde.Geburtsdatum, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                datePickerGebDatum.Value = date;
            }
            else
            {
                _istNeuerKunde = true;
            }
        }


        //SPEICHERN in db -> ändern oder neu anlegen
        private void buttonSpeichernKundenmodi_Click(object sender, EventArgs e)
        {
            //Daten in lokale Variable speichern
            //DatePicker Geburtsdatum
            _kunde.Geburtsdatum = datePickerGebDatum.Value.ToString("yyyy-MM-dd");

            //Textboxen für string-Variablen
            _kunde.Vorname = textBoxVorname.Text;
            _kunde.Nachname = textBoxNachname.Text;
            _kunde.Strasse = textBoxStrasse.Text;
            _kunde.Hausnummer = textBoxHausnummer.Text;
            _kunde.Wohnort = textBoxWohnort.Text;
            _kunde.Nutzername = textBoxNutzername.Text;
            _kunde.Passwort = textBoxPasswort.Text;

            //Textbox PLZ in int und dann in lokale Variable
            //Prüfung ob gültige PLZ (Länge = 5 & alles Zahlen)
            if (textBoxPostleitzahl.Text.Length != 5 || !textBoxPostleitzahl.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "PLZ muss genau 5 Ziffern haben.", "Ungültige Eingabe",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );

                textBoxPostleitzahl.Focus();
                return;
            }
            //PLZ gültig
            _kunde.PLZ = int.Parse(textBoxPostleitzahl.Text);


            //Prüfung, dass alle Felder ausgefüllt
            if (!KundendatenGueltig(_kunde))
            {
                MessageBox.Show("Bitte alle Daten ausfüllen");
                return;
            }

            //Abfrage, ob alle Daten korrekt
            DialogResult result = MessageBox.Show("Sind alle Daten korrekt?", "Bestätigung", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }


            //Daten in db speichern
            //Aktualisieren, wenn vorhandener Kunde
            if (!_istNeuerKunde)
            {
                string sqlUpdateKunde = @"UPDATE Kunde
                                      SET 
                                        Nutzername = @Nutzername,
                                        Passwort = @Passwort,
                                        Vorname = @Vorname,
                                        Nachname = @Nachname,
                                        Geburtsdatum = @Geburtsdatum,
                                        Strasse = @Strasse,
                                        Hausnummer = @Hausnummer,
                                        PLZ = @PLZ,
                                        Wohnort = @Wohnort
                                      WHERE KundenID = @KundenID";
                Globals.Db.Execute(sqlUpdateKunde, new
                {
                    KundenID = _kunde.KundenID,
                    Nutzername = _kunde.Nutzername,
                    Passwort = _kunde.Passwort,
                    Vorname = _kunde.Vorname,
                    Nachname = _kunde.Nachname,
                    Geburtsdatum = _kunde.Geburtsdatum,
                    Strasse = _kunde.Strasse,
                    Hausnummer = _kunde.Hausnummer,
                    PLZ = _kunde.PLZ,
                    Wohnort = _kunde.Wohnort
                });
            }

            //NEUEN Kunden anlegen
            else
            {
                string sqlNeuerKunde = @" INSERT INTO Kunde
                                   (
                                    Nutzername,
                                    Passwort,
                                    Vorname,
                                    Nachname,
                                    Geburtsdatum,
                                    Strasse,
                                    Hausnummer,
                                    PLZ,
                                    Wohnort
                                   )
                                VALUES
                                   (
                                    @Nutzername,
                                    @Passwort,
                                    @Vorname,
                                    @Nachname,
                                    @Geburtsdatum,
                                    @Strasse,
                                    @Hausnummer,
                                    @PLZ,
                                    @Wohnort
                                   );";
                Globals.Db.Execute(sqlNeuerKunde, new
                {
                    Nutzername = _kunde.Nutzername,
                    Passwort = _kunde.Passwort,
                    Vorname = _kunde.Vorname,
                    Nachname = _kunde.Nachname,
                    Geburtsdatum = _kunde.Geburtsdatum,
                    Strasse = _kunde.Strasse,
                    Hausnummer = _kunde.Hausnummer,
                    PLZ = _kunde.PLZ,
                    Wohnort = _kunde.Wohnort
                });
            }

            //Navigation nach Ursprungs-Form
            //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
            if (_caller == 0)
            {
                //Zu Home
                Globals.NavigateToNextForm<HomePersonal>(this);
            }
            if (_caller == 1)
            {
                //Zu BücherlistePersonal
                Globals.NavigateToNextForm<Kundenliste>(this);
            }
        }


        //Prüfung, dass Kundendaten nicht null oder leer sind
        private bool KundendatenGueltig(Kunde k)
        {
            return k != null &&
            !string.IsNullOrWhiteSpace(k.Vorname) &&
            !string.IsNullOrWhiteSpace(k.Nachname) &&
            !string.IsNullOrWhiteSpace(k.Geburtsdatum) &&
            !string.IsNullOrWhiteSpace(k.Strasse) &&
            !string.IsNullOrWhiteSpace(k.Hausnummer) &&
            k.PLZ != 0 &&
            !string.IsNullOrWhiteSpace(k.Wohnort) &&
            !string.IsNullOrWhiteSpace(k.Nutzername) &&
            !string.IsNullOrWhiteSpace(k.Passwort);
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
