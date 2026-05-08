using Bibo.Core;
using Bibo.Models;
using Bibo.Services;
using Bibo.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bibo.Forms.Personal
{
    public partial class BuecherlistePersonal : UI_Helper
    {
        private CursorManager cursorManager;
        private BuecherlistePersonalService service = new BuecherlistePersonalService(Globals.Db);
        private List<BuecherlistePersonalViewModel> _buecherlistePersonal;

        //Zum umschalten des QuickfilterButtons ohne extra button
        private int quickButtonZaehler = 0;


        public BuecherlistePersonal()
        {
            InitializeComponent();
            InsertData();
            CursorChangeOnInteractiveElements();
            DoubleclickOrEnterOnTable();
        }


        //Form befüllen
        private void InsertData()
        {
            //Datenbank Connection + ViewModelListe füllen
            var buecherlistePers = service.HoleGanzeBuecherlistePersonal();
            _buecherlistePersonal = buecherlistePers;

            FillRows(_buecherlistePersonal, tableBuecherliste);
        }


        //Tabelle füllen
        private void FillRows(List<BuecherlistePersonalViewModel> bListePers, DataGridView dgv)
        {
            foreach (var buchdaten in bListePers)
            {
                //Zeile hinzufügen
                int rowIndex = dgv.Rows.Add();
                DataGridViewRow dgvRow = dgv.Rows[rowIndex];


                //Cover setzen
                string isbn = buchdaten.Buch.ISBN;
                string coverPfad = $@"..\..\Images\{isbn}.jpg";
                dgvRow.Cells["colCover"].Value = LoadCoverSafe(coverPfad);


                //Übrige "normale"/simple Zellen der Zeile befüllen
                dgvRow.Cells["colISBN"].Value = buchdaten.Buch.ISBN;
                dgvRow.Cells["colTitel"].Value = buchdaten.Buch.Titel;
                dgvRow.Cells["colAutor"].Value = buchdaten.Buch.Autor;
                dgvRow.Cells["colGenre"].Value = buchdaten.Buch.Genre;
                dgvRow.Cells["colAlter"].Value = buchdaten.Buch.Altersgruppe;


                //Leihfrist, entsprechend ausgeliehen oder nicht (inkl. optische Differenzierung) + ButtonLeihstatus
                //TryParseExact falls Datum Fehler/null
                DateTime datum;
                if(buchdaten.Ausleihen != null)
                {
                    if (DateTime.TryParseExact(buchdaten.Ausleihen.Rueckgabedatum, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum))
                    {
                        dgvRow.Cells["colLeihfrist"].Value = datum;

                        //Datum rot, wenn Leihfrist überschritten
                        if (datum < DateTime.Today)
                        {
                        dgvRow.Cells["colLeihfrist"].Style.ForeColor = Color.Red;
                        }

                        //Button auf "Verlängern"
                        dgvRow.Cells["colLeihfristButton"].Value = Image.FromFile($@"..\..\Icons\verlaengern.png");
                    }
                    else
                    {
                        dgvRow.Cells["colLeihfrist"].Value = null;
                        //Button auf "Ausleihen"
                        dgvRow.Cells["colLeihfristButton"].Value = Image.FromFile($@"..\..\Icons\bearbeiten.png");
                    }
                }
                else
                {
                    dgvRow.Cells["colLeihfrist"].Value = null;
                    //Button auf "Ausleihen"
                    dgvRow.Cells["colLeihfristButton"].Value = Image.FromFile($@"..\..\Icons\bearbeiten.png");
                }


                //Ausgeliehen von
                if(buchdaten.KundeLeih != null)
                {
                    string kundendatenString =
                        buchdaten.KundeLeih.Name + "\n" +
                        buchdaten.KundeLeih.Strasse + buchdaten.KundeLeih.Hausnummer + "\n" +
                        buchdaten.KundeLeih.PLZ + buchdaten.KundeLeih.Wohnort;

                    dgvRow.Cells["ColKundeLeih"].Value = kundendatenString;
                }
                else
                {
                    dgvRow.Cells["ColKundeLeih"].Value = "Nicht ausgeliehen";
                }

                //Alle Buchdaten "speichern" in Tag
                dgvRow.Tag = buchdaten;
            }
        }


        //Weiterleitung zu entsprechendem Buchmodi Form bei Doppelklick/Enter Zeile
        private void DoubleclickOrEnterOnTable()
        {
            //Doppelklick/Enter auf Tabellenzeile
            ActionOnDoubleclickOrEnterDatagridview(tableBuecherliste, row =>
            {
                //Gewähltes Buch
                BuecherlistePersonalViewModel selectedRowBookVm = (BuecherlistePersonalViewModel)row.Tag;
                Buch selectedBook = selectedRowBookVm.Buch;

                //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
                int caller = 1;

                //Zu Buchmodi
                Globals.NavigateToNextForm<Buchmodifikation>(this, selectedBook, caller);
            });
        }



        //Zurück zu Home
        private void buttonHomeBuecherListePersonal_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }


        //Zu Neues Buch
        private void buttonNeuesBuch_Click(object sender, EventArgs e)
        {
            //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
            int caller = 1;

            Globals.NavigateToNextForm<Buchmodifikation>(this, new Buch(), caller);
        }


        //Quickfilter, nur überzogene zeigen
        private void buttonQuick_Click(object sender, EventArgs e)
        {
            //wenn nicht angewendet -> Nur geliehene Bücher anzeigen
            if (quickButtonZaehler == 0)
            {
                var buecherlisteAusgeliehen = service.HoleGelieheneBuecherlistePersonal();

                //Tabelle leer und neu füllen
                tableBuecherliste.Rows.Clear();
                FillRows(buecherlisteAusgeliehen, tableBuecherliste);

                //Sortieren, dass abgelaufene ganz oben bzw. kürzeste Leihfrist zuerst
                tableBuecherliste.Sort(tableBuecherliste.Columns["colLeihfrist"], System.ComponentModel.ListSortDirection.Ascending);

                quickButtonZaehler = 1;
            }
            //wenn gefiltert, wieder "entfiltern"
            else
            {
                quickButtonZaehler = 0;
                tableBuecherliste.Rows.Clear();
                
                InsertData();
            }
        }


        //Suchleiste, sucht in Buch:ISBN,Titel,Autor und Kunde:Name
        private void buttonSucheBuecherlistePersonal_Click(object sender, EventArgs e)
        {
            //input aus Eingabe in textbox
            string input = textBoxSucheBuecherlistePersonal.Text;
            if (input != null)
            {
                //ToLower, damit alles klein geschrieben, besser für Suche wenn alles klein
                input = input.ToLower();
            }
            else
            {
                //null abfangen
                input = "";
            }

            //hier auch ToLower, entsprechendes durchsuchen und Ergebnisliste erstellen
            var resultListe = _buecherlistePersonal.Where(x =>
                (x.Buch.ISBN != null && x.Buch.ISBN.ToLower().Contains(input)) ||
                (x.Buch.Titel != null && x.Buch.Titel.ToLower().Contains(input)) ||
                (x.Buch.Autor != null && x.Buch.Autor.ToLower().Contains(input)) ||
                (x.KundeLeih != null && x.KundeLeih.Name != null && x.KundeLeih.Name.ToLower().Contains(input))
            ).ToList();

            //Tabelle leeren und mit Ergebnis füllen
            tableBuecherliste.Rows.Clear();
            FillRows(resultListe, tableBuecherliste);
        }



        //Suche "Löschen", Tabelle neu machen
        private void buttonSucheaufheben_Click(object sender, EventArgs e)
        {
            tableBuecherliste.Rows.Clear();
            FillRows(_buecherlistePersonal, tableBuecherliste);
        }


        //Enter in Suchleiste zum Auslösen von buttonSucheBuecherlistePersonal_Click
        private void textBoxSucheBuecherlistePersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                buttonSucheBuecherlistePersonal_Click(buttonSucheBuecherlistePersonal, EventArgs.Empty);
            }
        }



        //Klick auf Button für Leihstatus ändern -> Leihfrist verlängern oder leihenden Kunden setzen (mit Frist)
        //Klick auf löschen -> Abfrage ob und löschen aus db
        private void tableBuecherliste_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Button Leihstatus
            if (e.ColumnIndex == tableBuecherliste.Columns["colLeihfristButton"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = tableBuecherliste.Rows[e.RowIndex];

                //Prüfung, ob Tag wirlich vm ist
                if (row.Tag is BuecherlistePersonalViewModel buchVm)
                {
                    //Schon ausgeliehen?
                    if (buchVm.Ausleihen != null)
                    {
                        //Leihfrist verlängern + nach Bestätigung in db speichern
                        DateTime rueckgabeDatum = DateTime.ParseExact(buchVm.Ausleihen.Rueckgabedatum, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        DateTime neueFrist = rueckgabeDatum.AddDays(14);

                        DialogResult result = MessageBox.Show("Leihfrist um 14 Tage verlängern","Bestätigung", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            buchVm.Ausleihen.Rueckgabedatum = neueFrist.ToString("yyyy-MM-dd");

                            //neue Leihfrist in db schreiben
                            var sql = @" UPDATE Ausleihen
                                            SET Rueckgabedatum = @Rueckgabedatum
                                            WHERE AusleihID = @AusleihID";
                            var param = new
                            {
                                Rueckgabedatum = buchVm.Ausleihen.Rueckgabedatum,
                                AusleihID = buchVm.Ausleihen.AusleihID
                            };
                            Globals.Db.Execute(sql, param);

                            //Tabelle aktualisieren
                            tableBuecherliste.Rows.Clear();
                            InsertData();
                        }
                    }
                    else
                    {
                        //Kunde leiht Buch aus, Kunde wählen über KundenID
                        IdEingabeKunde idEingabeForm = new IdEingabeKunde(buchVm);
                        idEingabeForm.ShowDialog();

                        //Tabelle aktualisieren
                        tableBuecherliste.Rows.Clear();
                        InsertData();
                    }
                }
            }

            //Button löschen
            if (e.ColumnIndex == tableBuecherliste.Columns["colDeleteButton"].Index && e.RowIndex >= 0)
            {
                //Tag des Eintrags
                DataGridViewRow row = tableBuecherliste.Rows[e.RowIndex];

                //Prüfung, ob Tag wirlich vm ist
                if (row.Tag is BuecherlistePersonalViewModel buchVm)
                {
                    //Abfrage ob sicher
                    DialogResult result = MessageBox.Show("Buch wirklich löschen?", "Bestätigung", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        //ISBN holen
                        string isbn = buchVm.Buch.ISBN;

                        //Sql-Statement
                        var sql = @"DELETE FROM Buch
                        WHERE ISBN = @ISBN";

                        var param = new
                        {
                            ISBN = isbn
                        };

                        //Eintrag in db löschen
                        Globals.Db.Execute(sql, param);

                        //Bild aus Image-Ordner löschen
                        //Ort Projektordner bestimmen
                        string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
                        //Image-Ordner finden
                        string targetFolder = Path.Combine(projectRoot, "Images");
                        //Kompletter Dateipfad dieses Covers
                        string coverPath = Path.Combine(targetFolder, isbn + ".jpg");
                        //Bild löschen, falls vorhanden
                        if (File.Exists(coverPath)) File.Delete(coverPath);

                        //Tabelle aktualisieren
                        tableBuecherliste.Rows.Clear();
                        InsertData();
                    }
                }
            }
        }


        //Mauszeiger anpassen bei bestimmten ELementen
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachHandCursor(buttonNeuesBuch);
            cursorManager.AttachHandCursor(buttonSucheBuecherlistePersonal);
            cursorManager.AttachHandCursor(buttonSucheaufheben);
            cursorManager.AttachHandCursor(buttonQuick);
            cursorManager.AttachHandCursor(buttonHomeBuecherListePersonal);
            cursorManager.AttachHandCursor(tableBuecherliste);
        }
    }
}
