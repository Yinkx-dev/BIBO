using Bibo.Core;
using Bibo.Models;
using Bibo.Services;
using Bibo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bibo
{
    public partial class HomeKunde: UI_Helper
    {
        private CursorManager cursorManager;
        private Kunde _kunde;
        public HomeKunde()
        {
            InitializeComponent();
            _kunde = Globals.CurrentKunde;
            InsertData();
            CursorChangeOnInteractiveElements();
            DoubleclickOrEnterOnTable();
        }


        private void InsertData()
        {
            //Datenbank Connection
            var result = Globals.Db.QueryList<KundeAusgeliehenViewModel>(
                @"
                SELECT b.ISBN, b.Titel, b.Autor, a.Rueckgabedatum
                FROM Buch b
                JOIN Ausleihen a ON b.ISBN = a.ISBN
                WHERE a.KundenID = @KundenID",
                new { Globals.CurrentKunde.KundenID }
            );

            //Tabelle füllen über FillRows
            FillRows(result, tableKundeHome);

            //Labels mit Kundendaten setzen
            nameText.Text = Globals.CurrentKunde.Name;
            string stringAddress = $"{Globals.CurrentKunde.Strasse} {Globals.CurrentKunde.Hausnummer}\n{Globals.CurrentKunde.PLZ} {Globals.CurrentKunde.Wohnort}";
            addressText.Text = stringAddress;
            birthdateText.Text = Globals.CurrentKunde.Geburtsdatum;
        }

        private void FillRows(List<KundeAusgeliehenViewModel> buecher, DataGridView dgv)
        {
            //Bewertungs-Button verkleinern
            dgv.Columns["colBewertung"].DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            
            //Tabelle füllen
            foreach (var buch in buecher)
            {
                int rowIndex = dgv.Rows.Add();
                DataGridViewRow dgvRow = dgv.Rows[rowIndex];

                //Cover
                string isbn = buch.ISBN;
                string coverPfad = $@"..\..\Images\{isbn}.jpg";
                dgvRow.Cells["colCover"].Value = LoadCoverSafe(coverPfad);

                //Titel, Autor
                dgvRow.Cells["colTitle"].Value = buch.Titel;
                dgvRow.Cells["colAutor"].Value = buch.Autor;

                //TryParseExact falls Datum Fehler/null
                DateTime datum;
                if (DateTime.TryParseExact(buch.Rueckgabedatum, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum))
                {
                    dgvRow.Cells["colLeihfrist"].Value = datum;
                }
                else
                {
                    dgvRow.Cells["colLeihfrist"].Value = "66.66.6666";
                }

                //Bewertungs-"Button"
                dgvRow.Cells["colBewertung"].Value = Image.FromFile($@"..\..\Icons\Bewertung_Black.png");

                //ISBN "speichern"
                dgvRow.Tag = buch.ISBN;
            }

            //Nach Leihfrist sortieren, kürzeste zuerst
            dgv.Sort(dgv.Columns["colLeihfrist"], ListSortDirection.Ascending);
        }


        //Mauszeiger anpassen bei bestimmten ELementen
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachDataGridViewColumn(tableKundeHome, "colBewertung");
            cursorManager.AttachHandCursor(logoutButton);
        }


        //Ausloggen
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentKunde = new Kunde();
            Globals.NavigateToNextForm<Login>(this);
        }


        //Klick auf Button für Rezension schreiben
        private void tableKundeHome_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == tableKundeHome.Columns["colBewertung"].Index && e.RowIndex >= 0)
            {
                var row = tableKundeHome.Rows[e.RowIndex];

                string isbnSelectedBook = row.Tag as string;

                if (!string.IsNullOrEmpty(isbnSelectedBook))
                {
                    //Buchdaten-Service kann alle Daten liefern für nötiges BewertungBuchViewModel
                    var service = new BuchdatenService(Globals.Db);
                    var buchdatenVM = service.GetBuchdaten(isbnSelectedBook);

                    Globals.NavigateToNextForm<BewertungBuch>(this, new BewertungBuchViewModel
                    {
                        selectedBook = buchdatenVM.Buch,
                        //wenn keine von CurrentKunde vorhanden -> null, sonst gewünschte Bewertung
                        bewertungBuch = buchdatenVM.BewertungCurrentKunde,
                        vorhandeneBewBearbeiten = buchdatenVM.HatCurrentKundeBewertet
                    });
                }
                else
                {
                    MessageBox.Show("Buchdaten nicht hinterlegt.");
                }
            }

        }


        //Doppelklick/Enter auf gewählter Zeile für Buchansicht
        private void DoubleclickOrEnterOnTable()
        {
            //Weiterleitung an Buchübersicht für ausgewähltes Buch
            ActionOnDoubleclickOrEnterDatagridview(tableKundeHome, row =>
            {
                string isbnSelectedBook = (string) row.Tag;
                Globals.NavigateToNextForm<Buchdaten>(this, isbnSelectedBook);
            });
        }

        //Weiterleitung an Buecherliste
        private void discoverNewButton_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<BuecherlisteKunde>(this);
        }
    }
}
