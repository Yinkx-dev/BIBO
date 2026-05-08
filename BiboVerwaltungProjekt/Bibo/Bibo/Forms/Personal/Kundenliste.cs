using Bibo.Core;
using Bibo.Models;
using Bibo.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Bibo.Forms.Personal
{
    public partial class Kundenliste : UI_Helper
    {
        private CursorManager cursorManager;
        private List<Kunde> _kundenliste;

        public Kundenliste()
        {
            InitializeComponent();
            InsertData();
            DoubleclickOrEnterOnTable();
            CursorChangeOnInteractiveElements();
        }


        //Form befüllen
        private void InsertData()
        {
            //Db-Connection + kundenliste füllen
            var kundenliste = Globals.Db.QueryList<Kunde>("SELECT * FROM Kunde");
            //Ergebnis in lokale Variable speichern
            _kundenliste = kundenliste;

            FillRows(_kundenliste, tableKundenliste);
        }
        
        //Tabelle füllen
        private void FillRows(List<Kunde> kundenliste, DataGridView dgv)
        {
            foreach(var kundendaten in kundenliste)
            {
                //Zeile hinzufügen
                int rowIndex = dgv.Rows.Add();
                DataGridViewRow dgvRow = dgv.Rows[rowIndex];

                //Zeile befüllen
                dgvRow.Cells["colKundenID"].Value = kundendaten.KundenID;
                dgvRow.Cells["colNutzername"].Value = kundendaten.Nutzername;
                dgvRow.Cells["colPasswort"].Value = kundendaten.Passwort;
                dgvRow.Cells["colName"].Value = kundendaten.Vorname + " " + kundendaten.Nachname;
                dgvRow.Cells["colStrasse"].Value = kundendaten.Strasse;
                dgvRow.Cells["colHausnummer"].Value = kundendaten.Hausnummer;
                dgvRow.Cells["colPlz"].Value = kundendaten.PLZ;
                dgvRow.Cells["colWohnort"].Value = kundendaten.Wohnort;

                //Geburtsdatum Format ändern + in Zelle
                DateTime gebdatum;
                DateTime.TryParseExact(kundendaten.Geburtsdatum, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out gebdatum);
                dgvRow.Cells["colGeburtsdatum"].Value = gebdatum.ToString("dd.MM.yyyy");

                //Kundendaten jeweils als Tag setzen
                dgvRow.Tag = kundendaten;
            }
        }


        //Zu Kundenmodi (neuer Kunde)
        private void buttonNeuerKunde_Click(object sender, EventArgs e)
        {
            //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
            int caller = 1;

            Globals.NavigateToNextForm<Kundenmodifikation>(this, new Kunde(), caller);
        }


        //Zu HomeKunde
        private void buttonHomeKundenListe_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }


        //Weiterleitung zu entsprechendem Kundenmodi Form bei Doppelklick/Enter Zeile
        private void DoubleclickOrEnterOnTable()
        {
            //Doppelklick/Enter auf Tabellenzeile
            ActionOnDoubleclickOrEnterDatagridview(tableKundenliste, row =>
            {
                //Gewählter Kunde
                Kunde selectedKunde = (Kunde)row.Tag;

                //int für Herkunft 0=Home 1=Liste [unschön, ich weiß]
                int caller = 1;

                //Zu Kundenmodi
                Globals.NavigateToNextForm<Kundenmodifikation>(this, selectedKunde, caller);
            });
        }


        //Suchleiste, sucht in Kunde: KundenID, Name
        private void buttonSucheKundenListe_Click(object sender, EventArgs e)
        {
            //input aus Eingabe in textbox
            string input = textBoxSucheKundenListe.Text;
            if (input != null)
            {
                //ToLower, damit alles klein geschrieben, besser für Suche wenn alles klein
                input = input.ToLower();
            }
            else
            {
                //"null" abfangen
                input = "";
            }

            //Kundenliste durchsuchen, auch ToLower, Ergebnisliste erstellen
            var resultListe = _kundenliste.Where(x=>
                (x.KundenID != null && x.KundenID.ToString().Contains(input)) ||
                (x.Vorname != null && x.Vorname.ToLower().Contains(input)) ||
                (x.Nachname != null && x.Nachname.ToLower().Contains(input))
            ).ToList();

            //Tabelle leeren und mit Ergebnis füllen
            tableKundenliste.Rows.Clear();
            FillRows(resultListe, tableKundenliste);
        }


        //Enter in Suchleiste zum Auslösen von buttonSucheKundenListe_Click
        private void textBoxSucheKundenListe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                buttonSucheKundenListe_Click(buttonSucheKundenListe, EventArgs.Empty);
            }
        }


        //Suche "Löschen", Tabelle neu machen
        private void buttonSucheaufheben_Click(object sender, EventArgs e)
        {
            //Suchfeld leeren
            textBoxSucheKundenListe.Text = null;

            //Tabelle wieder komplett anzeigen
            tableKundenliste.Rows.Clear();
            FillRows(_kundenliste, tableKundenliste);
        }


        //Klick auf löschen -> Abfrage ob und löschen aus db
        private void tableKundenliste_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Button löschen
            if (e.ColumnIndex == tableKundenliste.Columns["colDeleteButton"].Index && e.RowIndex >= 0)
            {
                //Tag des Eintrags
                DataGridViewRow row = tableKundenliste.Rows[e.RowIndex];

                //Prüfung, ob Tag wirlich Kunde ist
                if (row.Tag is Kunde k)
                {
                    //Abfrage ob sicher
                    DialogResult result = MessageBox.Show($"Kunde '{k.Vorname + " " + k.Nachname}' wirklich löschen?", "Bestätigung", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        //KundenId holen
                        int kundenID = k.KundenID;

                        //Sql-Statement
                        var sql = @"DELETE FROM Kunde
                                    WHERE KundenID = @KundenID";
                        var param = new
                        {
                            KundenID = kundenID
                        };

                        //Eintrag in db löschen
                        Globals.Db.Execute(sql, param);

                        //Tabelle aktualisieren
                        tableKundenliste.Rows.Clear();
                        InsertData();
                    }
                }
            }
        }


        //Hand-Cursor auf bestimmte Elemente
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachHandCursor(buttonNeuerKunde);
            cursorManager.AttachHandCursor(buttonSucheKundenListe);
            cursorManager.AttachHandCursor(buttonHomeKundenListe);
            cursorManager.AttachHandCursor(tableKundenliste);
            cursorManager.AttachHandCursor(buttonSucheaufheben);
        }
    }
}
