using Bibo.Core;
using Bibo.Models;
using System;
using System.Windows.Forms;

namespace Bibo
{
    public partial class Buecherliste : UI_Helper
    {
        private CursorManager cursorManager;
        public Buecherliste()
        {
            InitializeComponent();
            InsertData();
            CursorChangeOnInteractiveElements();
        }

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
        }

        //    //FillRows(result, tableBuecherliste);
        //}

        //private void FillRows(List<KundeAusgeliehen> buecher, DataGridView dgv)
        //{
        //    //Bewertungs-Button verkleinern
        //    dgv.Columns["colBewertung"].DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);

        //    foreach (var buch in buecher)
        //    {
        //        int rowIndex = dgv.Rows.Add();
        //        DataGridViewRow dgvRow = dgv.Rows[rowIndex];

        //        string isbn = buch.ISBN;
        //        string coverPfad = $@"..\..\Images\{isbn}.jpg";

        //        if (File.Exists(coverPfad))
        //        {
        //            dgvRow.Cells["colCover"].Value = Image.FromFile(coverPfad);
        //        }
        //        else
        //        {
        //            dgvRow.Cells["colCover"].Value = Image.FromFile($@"..\..\Images\DefaultCover.jpg");
        //        }

        //        dgvRow.Cells["colTitle"].Value = buch.Titel;
        //        dgvRow.Cells["colAutor"].Value = buch.Autor;
        //        dgvRow.Cells["colLeihfrist"].Value = DateTime.Parse(buch.Rueckgabedatum);
        //        dgvRow.Cells["colBewertung"].Value = Image.FromFile($@"..\..\Icons\Bewertung_Black.png");
        //        //ISBN "speichern"
        //        dgvRow.Tag = isbn;
        //    }
        //    //Nach Leihfrist sortieren, kürzeste zuerst
        //    dgv.Sort(dgv.Columns["colLeihfrist"], ListSortDirection.Ascending);
        //}


        //Mauszeiger anpassen bei bestimmten ELementen
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachDataGridViewColumn(tableBuecherliste);
            cursorManager.AttachHandCursor(buttonHome);
            cursorManager.AttachHandCursor(buttonSearchbar);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            HomeKunde form = new HomeKunde();
            form.Show();
            //Fenster schließen ohne App zu schließen
            this.CloseApplicationOnUserClose = false;
            Close();
        }
    }
}
