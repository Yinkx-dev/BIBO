using Bibo.Core;
using Bibo.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bibo
{
    public partial class BuecherlisteKunde : UI_Helper
    {
        private CursorManager cursorManager;
        public BuecherlisteKunde()
        {
            InitializeComponent();
            InsertData();
            CursorChangeOnInteractiveElements();
            DoubleclickOrEnterOnTable();
        }

        //DB-Verbindung + Reihen füllen
        private void InsertData()
        {
            //Datenbank Connection

            //Sterne als Durchschnitt (AVG), null vermieden durch COALESCE, ganze Zahlen weil ganze Sterne (ROUND)
            //Ergebnis als int in SterneDurchschnitt (CAST AS...)
            var buecher = Globals.Db.QueryList<BuecherlisteViewModel>(
                @"
                SELECT b.BuchID, b.ISBN, b.Titel, b.Autor, b.Erscheinungsdatum, b.Altersgruppe, b.Genre, b.IstAusgeliehen, CAST(ROUND(COALESCE(AVG(be.Sterne),0),0) AS int) AS SterneDurchschnitt 
                FROM Buch b 
                LEFT JOIN Bewertung be ON b.BuchID = be.BuchID 
                GROUP BY b.BuchID, b.ISBN, b.Titel, b.Autor, b.Erscheinungsdatum, b.Altersgruppe, b.Genre, b.IstAusgeliehen;"
            );
            FillRows(buecher, tableBuecherliste);
        }

        //Tabelle "manuell" befüllen
        private void FillRows(List<BuecherlisteViewModel> buecher, DataGridView dgv)
        {
            foreach (var buch in buecher)
            {
                int rowIndex = dgv.Rows.Add();
                DataGridViewRow dgvRow = dgv.Rows[rowIndex];

                string isbn = buch.ISBN;
                string coverPfad = $@"..\..\Images\{isbn}.jpg";

                if (File.Exists(coverPfad))
                {
                    dgvRow.Cells["colCover"].Value = Image.FromFile(coverPfad);
                }
                else
                {
                    dgvRow.Cells["colCover"].Value = Image.FromFile($@"..\..\Images\DefaultCover.jpg");
                }

                dgvRow.Cells["colBewertung"].Value = GetStarString(buch.SterneDurchschnitt);
                dgvRow.Cells["colTitel"].Value = buch.Titel;
                dgvRow.Cells["colAutor"].Value = buch.Autor;
                dgvRow.Cells["colGenre"].Value = buch.Genre;
                dgvRow.Cells["colAlter"].Value = buch.Altersgruppe;

                if (buch.IstAusgeliehen)
                {
                    dgvRow.Cells["colLeihstatus"].Value = Image.FromFile($@"..\..\Icons\HakenGruen.png");
                }
                else
                {
                    dgvRow.Cells["colLeihstatus"].Value = Image.FromFile($@"..\..\Icons\KreuzRot.png");
                }

                //ISBN "speichern"
                dgvRow.Tag = buch.ISBN;
            }
        }


        //Mauszeiger anpassen bei bestimmten ELementen
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachDataGridViewColumn(tableBuecherliste);
            cursorManager.AttachHandCursor(buttonHomeBuecherlisteKunde);
            cursorManager.AttachHandCursor(buttonSucheBuecherlisteKunde);
            cursorManager.AttachHandCursor(buttonSucheaufheben);
        }

        //Weiterleitung zu entsprechendem Buchdaten Form
        private void DoubleclickOrEnterOnTable()
        {
            //Doppelklick/Enter auf Tabellenzeile
            ActionOnDoubleclickOrEnterDatagridview(tableBuecherliste, row =>
            {
                string isbnSelectedBook = (string)row.Tag;
                Globals.NavigateToNextForm<Buchdaten>(this, isbnSelectedBook);
            });
        }


        //Zurück zur Übersicht
        private void buttonHome_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomeKunde>(this);
        }

        //Suchleiste
        private void buttonSucheBuecherlisteKunde_Click(object sender, EventArgs e)
        {
            string input = textBoxSucheBuecherlisteKunde.Text;

            var result = Globals.Db.QueryList<BuecherlisteViewModel>(
            @"
            SELECT b.BuchID, b.ISBN, b.Titel, b.Autor, b.Erscheinungsdatum, b.Altersgruppe, b.Genre, b.IstAusgeliehen, 
            CAST(ROUND(COALESCE(AVG(be.Sterne),0),0) AS int) AS SterneDurchschnitt 
            FROM Buch b 
            LEFT JOIN Bewertung be ON b.BuchID = be.BuchID
            WHERE b.Titel LIKE @input
               OR b.Autor LIKE @input
               OR b.Genre LIKE @input
               OR b.Altersgruppe LIKE @input
            GROUP BY b.BuchID, b.ISBN, b.Titel, b.Autor, b.Erscheinungsdatum, b.Altersgruppe, b.Genre, b.IstAusgeliehen;",

            new { input = "%" + input + "%" }
            );

            tableBuecherliste.Rows.Clear();
            FillRows(result, tableBuecherliste);
        }

        //Suchfilter löschen, vollständige Liste wieder anzeigen
        private void buttonSucheaufheben_Click(object sender, EventArgs e)
        {
            tableBuecherliste.Rows.Clear();
            textBoxSucheBuecherlisteKunde.Clear();
            InsertData();
        }


        //Enter in Suchleiste zum Auslösen von buttonSucheBuecherlisteKunde_Click
        private void textBoxSucheBuecherlisteKunde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                buttonSucheBuecherlisteKunde_Click(buttonSucheBuecherlisteKunde, EventArgs.Empty);
            }
        }
    }
}
