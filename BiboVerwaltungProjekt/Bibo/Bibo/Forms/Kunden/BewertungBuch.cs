using Bibo.Core;
using Bibo.Models;
using Bibo.ViewModels;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bibo
{
    public partial class BewertungBuch: UI_Helper
    {
        private BewertungBuchViewModel _bewBuchVM;
        private CursorManager cursorManager;

        public BewertungBuch(BewertungBuchViewModel bewBuchVM)
        {
            InitializeComponent();
            _bewBuchVM = bewBuchVM;
            FillControls();
            CursorChangeOnInteractiveElements();
        }



        //Conrtols von Buch mit Daten füllen
        private void FillControls()
        {
            //COVER
            string isbn = _bewBuchVM.selectedBook.ISBN;
            string coverPfad = $@"..\..\Images\{isbn}.jpg";
            pictureBoxCover.Image = LoadCoverSafeBigger(coverPfad);

            //TITEL
            richTextBoxTitel.Text = _bewBuchVM.selectedBook.Titel;

            //BUCHINFOS -> Autor, ISBN, Genre, Altersgruppe, Erscheinungsdatum
            DateTime datum;
            DateTime.TryParseExact(_bewBuchVM.selectedBook.Erscheinungsdatum, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum);

            string additionalInformationBook =
            "Autor: " + _bewBuchVM.selectedBook.Autor +
            ", Genre: " + _bewBuchVM.selectedBook.Genre +
            ", Altersgruppe: " + _bewBuchVM.selectedBook.Altersgruppe +
            ", Erscheinungsdatum: " + datum.ToString("dd.MM.yyyy");

            richTextBoxInfos.Text = additionalInformationBook;

            //KURZBESCHREIBUNG
            richTextBoxBeschreibung.Text = _bewBuchVM.selectedBook.Kurzbeschreibung;


            //Falls vorhandene Bewertung bearbeiten -> Bewertungs-Controls füllen
            if (_bewBuchVM.vorhandeneBewBearbeiten)
            {
                FillControlsBewertung();
            }
        }


        //Ggf Bewertungs-controls füllen
        private void FillControlsBewertung()
        {
            //STERNEZAHL dropdown
            //Muss in BewertungBuch_Load gesetzt werden, sonst sind items noch nicht da

            //Gewählte Anonym-Präferenz
            radioButtonAnonymNein.Checked = _bewBuchVM.bewertungBuch.MitName;

            //Titel-Bewertung
            textBoxTitelBewertung.Text = _bewBuchVM.bewertungBuch.Ueberschrift;

            //Text-Bewertung
            richTextBoxTextBewertung.Text = _bewBuchVM.bewertungBuch.Text;
        }



        //Zu HomeKunde
        private void buttonHomeBewertung_Click(object sender, System.EventArgs e)
        {
            Globals.NavigateToNextForm<HomeKunde>(this);
        }

        //Zu BuecherlisteKunde
        private void buttonZurueckBuecherliste_Click(object sender, System.EventArgs e)
        {
            Globals.NavigateToNextForm<BuecherlisteKunde>(this);
        }

        //Abbrechen und zurück zu Buchdaten
        private void buttonAbbrechenBewertung_Click(object sender, System.EventArgs e)
        {
            Globals.NavigateToNextForm<Buchdaten>(this, _bewBuchVM.selectedBook.ISBN);
        }



        //SPEICHERN -> Checken, ob neuer Eintrag db INSERT oder aktualisieren UPDATE
        private void buttonSpeichernBewertung_Click(object sender, System.EventArgs e)
        {
            //Methode, die prüft, ob gespeichert werden darf -> alles korrekt ausgefüllt?
            if (!SpeichernErlaubt())
            {
                return;
            }

            //position = gewählte Sternezahl
            int position = dropdownSternezahl.SelectedIndex + 1;

            //bool für Anonym Ja oder Nein
            bool anonym = radioButtonAnonymJa.Checked;

            //Wenn Titel der Bewertung leer ist, "---" setzen, damit es nicht aussieht wie ein Anzeigefehler
            string inputTitelBewertung = textBoxTitelBewertung.Text;
            if (string.IsNullOrWhiteSpace(inputTitelBewertung))
            {
                textBoxTitelBewertung.Text = "---";
            }

            //Wenn Text der Bewertung leer ist, "---" setzen, damit es nicht aussieht wie ein Anzeigefehler
            string inputTextBewertung = richTextBoxTextBewertung.Text;
            if (string.IsNullOrWhiteSpace(inputTextBewertung))
            {
                richTextBoxTextBewertung.Text = "---";
            }

            //Wenn diese Bewertung "nur" bearbeitet wird
            if (_bewBuchVM.bewertungBuch != null &&
                _bewBuchVM.bewertungBuch.KundenID == Globals.CurrentKunde.KundenID)
            {
                BewertungBearbeitenInDB(position, anonym);
            }
            //Neue Bewertung anlegen
            else
            {
                BewertungAnlegenInDB(position, anonym);
            }

            Globals.NavigateToNextForm<Buchdaten>(this, _bewBuchVM.selectedBook.ISBN);
        }

        private bool SpeichernErlaubt()
        {
            //bools für maximale Längenprüfung
            bool istTitelZuLang = true;
            bool istTextZuLang= true;

            //Ist Titel länger als 100 Zeichen
            string inputTitelBewertung = textBoxTitelBewertung.Text;
            int maxLengthTitelBewertung = 100;

            if (inputTitelBewertung.Length > maxLengthTitelBewertung)
            {
                MessageBox.Show("Der Titel darf nicht länger als 100 Zeichen sein.\n" +
                    $"Aktuell hat er {inputTitelBewertung.Length - maxLengthTitelBewertung} Zeichen zu viel.");
                istTitelZuLang = false;
            }

            //Ist Text länger als 1000 Zeichen
            string inputTextBewertung = richTextBoxTextBewertung.Text;
            int maxLengthTextBewertung = 1000;

            if (inputTextBewertung.Length > maxLengthTextBewertung)
            {
                MessageBox.Show("Der Text darf nicht länger als 1000 Zeichen sein.\n" +
                    $"Aktuell hat er {inputTextBewertung.Length - maxLengthTextBewertung} Zeichen zu viel.");
                istTextZuLang = false;
            }

            return istTitelZuLang && istTextZuLang;
        }


        //Bestehende Bewertung aktualisieren in Datenbank
        private void BewertungBearbeitenInDB(int position, bool anonym)
        {
                var sql = @"UPDATE Bewertung SET
                                BuchID = @BuchID,
                                KundenID = @KundenID,
                                Sterne = @Sterne,
                                Ueberschrift = @Ueberschrift,
                                Text = @Text,
                                Datum = @Datum,
                                MitName = @MitName
                            WHERE BewertungsID = @BewertungsID";

            var param = new
            {
                BewertungsID = _bewBuchVM.bewertungBuch.BewertungsID,
                BuchID = _bewBuchVM.selectedBook.BuchID,
                KundenID = _bewBuchVM.bewertungBuch.KundenID,
                Sterne = position,
                Ueberschrift = textBoxTitelBewertung.Text.ToString(),
                Text = richTextBoxTextBewertung.Text.ToString(),
                Datum = DateTime.Now.ToString("yyyy-MM-dd"),
                MitName = anonym
            };

            Globals.Db.Execute(sql, param);

        }

        //Neue Bewertung in Datenbank speichern
        private void BewertungAnlegenInDB(int position, bool anonym)
        {
            var sql = @"INSERT INTO Bewertung 
                        (BuchID, KundenID, Sterne, Ueberschrift, Text, Datum, MitName)
                        VALUES 
                        (@BuchID, @KundenID, @Sterne, @Ueberschrift, @Text, @Datum, @MitName)";

            var param = new
            {
                BuchID = _bewBuchVM.selectedBook.BuchID,
                KundenID = Globals.CurrentKunde.KundenID,
                Sterne = position,
                Ueberschrift = textBoxTitelBewertung.Text.ToString(),
                Text = richTextBoxTextBewertung.Text.ToString(),
                Datum = DateTime.Now.ToString("yyyy-MM-dd"),
                MitName = anonym
            };

            Globals.Db.Execute(sql, param);
        }



        //Sterne für Combobox manuell, da im designer nicht klappt + Default wegen Index -1
        private void BewertungBuch_Load(object sender, EventArgs e)
        {
            dropdownSternezahl.Items.Add("★☆☆☆☆");
            dropdownSternezahl.Items.Add("★★☆☆☆");
            dropdownSternezahl.Items.Add("★★★☆☆");
            dropdownSternezahl.Items.Add("★★★★☆");
            dropdownSternezahl.Items.Add("★★★★★");

            if (_bewBuchVM.vorhandeneBewBearbeiten)
            {
                dropdownSternezahl.SelectedIndex = _bewBuchVM.bewertungBuch.Sterne - 1;
            }
            else
            {
                dropdownSternezahl.SelectedIndex = 4;
            }
        }



        //Mauszeiger anpassen bei bestimmten ELementen
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachHandCursor(buttonZurueckBuecherliste);
            cursorManager.AttachHandCursor(buttonHomeBewertung);
        }

    }
}
