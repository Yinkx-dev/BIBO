using Bibo.Core;
using Bibo.Models;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Bibo.Forms.Personal
{
    public partial class Buchmodifikation : UI_Helper
    {
        //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
        private int _caller;

        private Buch _buch;
        private CursorManager cursorManager;
        private string _selectedCoverPath;

        public Buchmodifikation(Buch buch, int caller)
        {
            InitializeComponent();
            _buch = buch;
            _caller = caller;

            InsertData();
            CursorChangeOnInteractiveElements();
            DisableIsbnTextboxIsBorrowed();
        }


        //ISBN darf nicht geändert werden, wenn Buch ausgeliehen, zerstört Verbindung mit Kunde in Ausleihen
        private void DisableIsbnTextboxIsBorrowed()
        {
            if (_buch.IstAusgeliehen)
            {
                textBoxISBN.Enabled = false;
                labelIsbnDeactivated.Visible = true;
            }
        }


        //Ggf. Übergebene Daten anzeigen
        private void InsertData()
        {
            if( _buch.Titel != null)
            {
                //"simple" Textboxen
                textBoxTitel.Text = _buch.Titel;
                textBoxAutor.Text = _buch.Autor;
                textBoxISBN.Text = _buch.ISBN;
                richTextBoxKurzbeschreibung.Text = _buch.Kurzbeschreibung;

                //Textbox Erscheinungsdatum [Umwandlung in richtiges Format]
                DateTime date = DateTime.ParseExact(_buch.Erscheinungsdatum, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                datePickerErschDatum.Value = date;

                //Dropdown Genre + Alter [IndexOf für evtl. kleine Abweichungen]
                int idxGenre = dropdownGenre.Items.IndexOf(_buch.Genre);
                if (idxGenre >= 0)
                    dropdownGenre.SelectedIndex = idxGenre;

                int idxAge = dropdownAlter.Items.IndexOf(_buch.Altersgruppe);
                if (idxAge >= 0)
                    dropdownAlter.SelectedIndex = idxAge;

                //Cover
                string isbn = _buch.ISBN;
                string coverPfad = $@"..\..\Images\{isbn}.jpg";
                pictureBoxCover.Image = LoadCoverSafeBigger(coverPfad);
                _selectedCoverPath = coverPfad;
            }

            //Default-SelectedItem für Dropdowns wegen Speichern-Error wenn null
            dropdownAlter.SelectedIndex = 0;
            dropdownGenre.SelectedIndex = 0;
        }


        //Zu Home
        private void buttonHomeBuchModi_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }


        //Abbrechen und zurück zu Ursprungs-Form
        private void buttonAbbrechenBuchmodi_Click(object sender, EventArgs e)
        {
            //Navigation nach Ursprungs-Form
            //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
            if (_caller == 0)
            {
                //Zu Home
                Globals.NavigateToNextForm<HomePersonal>(this);
            }
            if(_caller == 1)
            {
                //Zu BücherlistePersonal
                Globals.NavigateToNextForm<BuecherlistePersonal>(this);
            }
        }


        //Zu Bücherliste
        private void buttonZurueckBuecherliste_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<BuecherlistePersonal>(this);
        }


        //Cover temporär "hochladen" [Dateipfad in Variable für ggf. spätere Speicherung]
        private void buttonCoverhochladen_Click(object sender, EventArgs e)
        {
            //Öffnet Windows-Dateiauswahl und zeigt dann nur gewünschte/gültige Bilddateien an
            using (OpenFileDialog ofd  = new OpenFileDialog())
            {
                ofd.Filter = "Bilddateien|*.jpg;";

                //Nutzer muss auch auf Ok gedrückt haben
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Bildpfad wird zwischengespeichert
                    _selectedCoverPath = ofd.FileName;

                    //Gewähltes Bild wird angezeigt
                    pictureBoxCover.Image?.Dispose();
                    pictureBoxCover.Image = LoadCoverSafeBigger(_selectedCoverPath);
                }
            }
        }


        //SPEICHERN in db -> ändern oder neu anlegen
        private void buttonSpeichernBuchmodi_Click(object sender, EventArgs e)
        {
            //Daten in lokale Variable speichern
            //textboxen Titel, Autor, ISBN, Kurzbeschreibung
            _buch.Titel = textBoxTitel.Text;
            _buch.Autor = textBoxAutor.Text;
            _buch.ISBN = textBoxISBN.Text;
            _buch.Kurzbeschreibung = richTextBoxKurzbeschreibung.Text;
            //datePicker Erscheinungsdatum
            _buch.Erscheinungsdatum = datePickerErschDatum.Value.ToString("yyyy-MM-dd");
            //Dropdowns Genre, Altersgruppe
            _buch.Genre = dropdownGenre.SelectedItem.ToString();
            _buch.Altersgruppe = dropdownAlter.SelectedItem.ToString();


            //Bild von pictureBox
            //Prüfung, dass Bild gewählt/vorhanden
            if (string.IsNullOrEmpty(_selectedCoverPath))
            {
                MessageBox.Show("Kein Bild ausgewählt.");
                return;
            }


            //Prüfung, dass alle Felder ausgefüllt
            if (!BuchdatenGueltig(_buch))
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


            //Trim() entfernt evtl. Leerzeichen, etc. außen von ISBN
            string isbn = textBoxISBN.Text.Trim();

            //Ort Projektordner bestimmen
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            //Zielordner für Bild finden
            string targetFolder = Path.Combine(projectRoot, "Images");
            Directory.CreateDirectory(targetFolder); //Absicherung, falls Ordner nicht da
            //Neuer Name für Image (ISBN) + Speicherort
            string targetPath = Path.Combine(targetFolder, isbn + ".jpg");
            //Datei in Zielordner kopieren
            File.Copy(_selectedCoverPath, targetPath, true);


            //Daten in db speichern
            //Aktualisieren, wenn vorhandenes Buch UND AUSGELIEHEN
            if (_buch.IstAusgeliehen)
            {
                string sqlUpdateBuch = @"UPDATE Buch
                                      SET 
                                        ISBN = @ISBN,
                                        Titel = @Titel,
                                        Kurzbeschreibung = @Kurzbeschreibung,
                                        Autor = @Autor,
                                        Erscheinungsdatum = @Erscheinungsdatum,
                                        Altersgruppe = @Altersgruppe,
                                        Genre = @Genre
                                      WHERE BuchID = @BuchID";
                Globals.Db.Execute(sqlUpdateBuch, new
                {
                    BuchID = _buch.BuchID,
                    ISBN = _buch.ISBN,
                    Titel = _buch.Titel,
                    Kurzbeschreibung = _buch.Kurzbeschreibung,
                    Autor = _buch.Autor,
                    Erscheinungsdatum = _buch.Erscheinungsdatum,
                    Altersgruppe = _buch.Altersgruppe,
                    Genre = _buch.Genre
                });
            }

            //NEUES BUCH anlegen
            else
            {
                string sqlNeuesBuch = @" INSERT INTO Buch
                                   (
                                    ISBN,
                                    Titel,
                                    Kurzbeschreibung,
                                    Autor,
                                    Erscheinungsdatum,
                                    Altersgruppe,
                                    Genre,
                                    IstAusgeliehen
                                   )
                                VALUES
                                   (
                                    @ISBN,
                                    @Titel,
                                    @Kurzbeschreibung,
                                    @Autor,
                                    @Erscheinungsdatum,
                                    @Altersgruppe,
                                    @Genre,
                                    @IstAusgeliehen
                                   );";
                Globals.Db.Execute(sqlNeuesBuch, new
                {
                    ISBN = _buch.ISBN,
                    Titel = _buch.Titel,
                    Kurzbeschreibung = _buch.Kurzbeschreibung,
                    Autor = _buch.Autor,
                    Erscheinungsdatum = _buch.Erscheinungsdatum,
                    Altersgruppe = _buch.Altersgruppe,
                    Genre = _buch.Genre,
                    IstAusgeliehen = _buch.IstAusgeliehen
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
                Globals.NavigateToNextForm<BuecherlistePersonal>(this);
            }
        }


        //Prüfung, dass Buchdaten nicht null oder leer sind
        private bool BuchdatenGueltig(Buch b)
        {
            return b != null &&
            !string.IsNullOrWhiteSpace(b.ISBN) &&
            !string.IsNullOrWhiteSpace(b.Titel) &&
            !string.IsNullOrWhiteSpace(b.Kurzbeschreibung) &&
            !string.IsNullOrWhiteSpace(b.Autor) &&
            !string.IsNullOrWhiteSpace(b.Erscheinungsdatum) &&
            !string.IsNullOrWhiteSpace(b.Altersgruppe) &&
            !string.IsNullOrWhiteSpace(b.Genre);
        }


        //Hand-Cursor auf Zurück zu Bücherliste
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachHandCursor(buttonZurueckBuecherliste);
        }
    }
}
