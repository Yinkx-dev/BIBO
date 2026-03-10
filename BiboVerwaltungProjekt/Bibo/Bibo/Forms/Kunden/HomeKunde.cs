using Bibo.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bibo
{
    public partial class HomeKunde: Form
    {
        private Kunde _kunde;
        public HomeKunde()
        {
            InitializeComponent();
            _kunde = Globals.CurrentKunde;
            InsertData();
        }



        private void InsertData()
        {
            //Dateipfad relativ zu bin/Debug
            string connectionString = @"Data Source=..\..\Database\database_BiBO.db;Version=3";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string databaseCommand = @"
                SELECT b.ISBN, b.Titel, b.Autor, a.Rueckgabedatum
                FROM Buch b
                JOIN Ausleihen a ON b.ISBN = a.ISBN
                WHERE a.KundenID = @KundenID";

                var result = conn.Query<KundeAusgeliehen>(databaseCommand, new {Globals.CurrentKunde.KundenID}).ToList();
                FillRows(result, tableKundeHome);

                nameText.Text = Globals.CurrentKunde.Name;
                string stringAddress = $"{Globals.CurrentKunde.Strasse} {Globals.CurrentKunde.Hausnummer}\n{Globals.CurrentKunde.Wohnort}";
                addressText.Text = stringAddress;
                birthdateText.Text = Globals.CurrentKunde.Geburtsdatum;
            }
        }

        private void FillRows(List<KundeAusgeliehen> buecher, DataGridView dgv)
        {
            //Bewertungs-Button verkleinern
            dgv.Columns["colBewertung"].DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            
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

                dgvRow.Cells["colTitle"].Value = buch.Titel;
                dgvRow.Cells["colAutor"].Value = buch.Autor;
                dgvRow.Cells["colLeihfrist"].Value = DateTime.Parse(buch.Rueckgabedatum);
                dgvRow.Cells["colBewertung"].Value = Image.FromFile($@"..\..\Icons\Bewertung_Black.png");
                //ISBN "speichern"
                dgvRow.Tag = isbn;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentKunde = new Kunde();
            Globals.SessionLogin = new Login();
            Globals.SessionLogin.Show();
            Close();
        }

        //Mauszeiger Veränderung auf Button für Rezension schreiben
        private void tableKundeHome_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == tableKundeHome.Columns["colBewertung"].Index && e.RowIndex >= 0)
            {
                tableKundeHome.Cursor = Cursors.Hand;
            }
        }

        private void tableKundeHome_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            tableKundeHome.Cursor = Cursors.Default;

        }


        //Klick auf Button für Rezension schreiben
        private void tableKundeHome_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == tableKundeHome.Columns["colBewertung"].Index && e.RowIndex >= 0)
            {
                var row = tableKundeHome.Rows[e.RowIndex];

                string isbn = row.Tag as string;

                if (!string.IsNullOrEmpty(isbn))
                {
                    BewertungBuch form = new BewertungBuch(isbn);
                    form.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Buchdaten nicht hinterlegt.");
                }
            }

        }
    }
}
