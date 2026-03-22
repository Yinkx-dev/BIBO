using Bibo.Core;
using Bibo.Models;
using Bibo.Services;
using Bibo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo
{
    public partial class Buchdaten: UI_Helper
    {
        private string _isbnSelectedBook;
        private CursorManager cursorManager;
        private BuchdatenViewModel buchdaten;

        public Buchdaten(string isbnSelectedBook)
        {
            InitializeComponent();
            _isbnSelectedBook = isbnSelectedBook;
            InsertData();
            CursorChangeOnInteractiveElements();
        }

        private void InsertData()
        {
            //Datenbank Connection + ViewModel füllen
            var service = new BuchdatenService(Globals.Db);
            var buchdatenVM = service.GetBuchdaten(_isbnSelectedBook);

            //lokale Variable setzen für andere Methoden
            buchdaten = buchdatenVM;

            //"Normale" Controls befüllen
            FillControls(buchdatenVM);

            //Bewertungen DataGridView befüllen
            FillRows(buchdatenVM.Bewertungen, tableBewertungenAnzeigen);
        }


        //"Normale" Controls befüllen
        private void FillControls(BuchdatenViewModel buchdatenVM)
        {
            //COVER
            string isbn = buchdatenVM.Buch.ISBN;
            string coverPfad = $@"..\..\Images\{isbn}.jpg";
            
            //Cover nur setzen, wenn vorhanden (Default in Designer gesetzt)
            if (File.Exists(coverPfad))
            {
                pictureBoxCover.Image = Image.FromFile(coverPfad);
            }

            //TITEL
            richTextBoxTitel.Text = buchdatenVM.Buch.Titel;

            //BUCHINFOS -> Autor, ISBN, Genre, Altersgruppe, Erscheinungsdatum
            DateTime datum;
            DateTime.TryParseExact(buchdatenVM.Buch.Erscheinungsdatum, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum);
            
            string additionalInformationBook =
            "Autor: " + buchdatenVM.Buch.Autor +
            ", ISBN: " + buchdatenVM.Buch.ISBN +
            ", Genre: " + buchdatenVM.Buch.Genre +
            ", Altersgruppe: " + buchdatenVM.Buch.Altersgruppe +
            ", Erscheinungsdatum: " + datum.ToString("dd.MM.yyyy");

            richTextBoxInfos.Text = additionalInformationBook;

            //KURZBESCHREIBUNG
            richTextBoxBeschreibung.Text = buchdatenVM.Buch.Kurzbeschreibung;

            //LEIHSTATUS +++ BewertungsButton
            //Wenn Buch in Bibliothek ist
            if(buchdatenVM.Leihdaten.Rueckgabedatum == "")
            {
                richTextBoxLeihstatus.Text = "In Bibliothek verfügbar";
            }
            //Anzeige nach selbst ausgeliehen oder "fremd" +++ Bewertungsbutton aktivieren, wenn selbst ausgeliehen
            else if (buchdatenVM.Leihdaten.KundenID == Globals.CurrentKunde.KundenID)
            {
                //Leihstatus
                string rueckgabeDatum = buchdatenVM.Leihdaten.Rueckgabedatum;
                string rueckgabeDatumString = rueckgabeDatum.Replace("-", ".");

                richTextBoxLeihstatus.Text = "Zurückgeben bis: " + rueckgabeDatumString;

                //Bewertungs-Button (+label)
                labelBewertungSchreiben.Visible = true;
                buttonBewertungSchreiben.Visible = true;
                buttonBewertungSchreiben.Enabled = true;
                buttonBewertungSchreiben.BackColor = Color.FromArgb(166, 136, 191);
            }
            else
            {
                string rueckgabeDatum = buchdatenVM.Leihdaten.Rueckgabedatum;
                string rueckgabeDatumString = rueckgabeDatum.Replace("-", ".");

                richTextBoxLeihstatus.Text = "Voraussichtlich wieder verfügbar ab: " + rueckgabeDatumString;
            }

            //labelBewertungSchreiben wenn Bewertung von CurrentKunde vorhanden
            if (buchdatenVM.HatCurrentKundeBewertet)
            {
                labelBewertungSchreiben.Text = "Bewertung bearbeiten";
            }
        }


        //Tabelle Bewertungen befüllen
        private void FillRows(List<Bewertung> bewertungenBuch, DataGridView dgv)
        {
            foreach (var bewertung in bewertungenBuch)
            {
                int rowIndex = dgv.Rows.Add();
                DataGridViewRow dgvRow = dgv.Rows[rowIndex];

                dgvRow.Cells["colSterneTitel"].Value = $"{UI_Helper.GetStarString(bewertung.Sterne)}\n{bewertung.Ueberschrift}";
                dgvRow.Cells["colText"].Value = $"{bewertung.Text}";

                //Name nur anzeigen, wenn von Verfasser gewünscht
                string nameVerfasser; //Variable für colDatumName -> Name
                if (bewertung.MitName)
                {
                    //KundenID von dieser Bewertung speichern
                    int verfasserKundenID = bewertung.KundenID;

                    //Die Kundendaten des Verfassers holen
                    Kunde verfasser = Globals.Db.QuerySingle<Kunde>(
                        @"SELECT * FROM Kunde WHERE KundenID LIKE @verfasserKundenID",
                        new { verfasserKundenID = "%" + verfasserKundenID + "%" }
                        );

                    //Den Namen des Verfassers ins dgv schreiben
                    nameVerfasser = verfasser.Name;
                }
                else
                {
                    nameVerfasser = "Anonym"; //Verfasser will anonym bleiben
                }

                //TryParseExact falls Datum Fehler/null
                DateTime datum;
                if (DateTime.TryParseExact(bewertung.Datum, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum))
                {
                    dgvRow.Cells["colDatumName"].Value = $"{datum.ToString("dd.MM.yyyy")}\nVon {nameVerfasser}";
                }
                else
                {
                    dgvRow.Cells["colDatumName"].Value = $"66.66.6666\nVon {nameVerfasser}";
                }
            }
        }


        //Dropdown für Bewertungen sortieren
        private void dropDownBewertungenSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sortieren nach Ausgewähltem
            switch (dropDownBewertungenSort.SelectedItem.ToString())
            {
                case "Sterne absteigend":
                    buchdaten.Bewertungen.Sort((a, b) => b.Sterne.CompareTo(a.Sterne));
                    break;
                case "Sterne aufsteigend":
                    buchdaten.Bewertungen.Sort((a, b) => a.Sterne.CompareTo(b.Sterne));
                    break;
                case "Neueste zuerst":
                    buchdaten.Bewertungen.Sort((a, b) => b.Datum.CompareTo(a.Datum));
                    break;
            }
            //DataGrid neu füllen
            tableBewertungenAnzeigen.Rows.Clear();
            FillRows(buchdaten.Bewertungen, tableBewertungenAnzeigen);
        }


        //Zu Home
        private void buttonHomeBuchdatenKunde_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomeKunde>(this);
        }

        //Zu Bücherliste
        private void buttonZurueckBuecherliste_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<BuecherlisteKunde>(this);
        }

        //Zu BewertungBuch
        private void buttonBewertungSchreiben_Click(object sender, EventArgs e)
        {
            if (buchdaten.HatCurrentKundeBewertet)
            {
                Globals.NavigateToNextForm<BewertungBuch>(this, buchdaten.BewertungCurrentKunde);
            }
            else
            {
                Globals.NavigateToNextForm<BewertungBuch>(this, new Bewertung());
            }
        }


        //Mauszeiger anpassen bei bestimmten ELementen
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachHandCursor(buttonZurueckBuecherliste);
            cursorManager.AttachHandCursor(buttonHomeBuchdatenKunde);
            cursorManager.AttachHandCursor(dropDownBewertungenSort);
        }
    }
}
