using Bibo.Core;
using Bibo.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                dgvRow.Cells["colName"].Value = kundendaten.Name;
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


        //Hand-Cursor auf bestimmte Elemente
        private void CursorChangeOnInteractiveElements()
        {
            cursorManager = new CursorManager();

            cursorManager.AttachHandCursor(buttonNeuerKunde);
            cursorManager.AttachHandCursor(buttonSucheKundenListe);
            cursorManager.AttachHandCursor(buttonHomeKundenListe);
            cursorManager.AttachHandCursor(tableKundenliste);
        }
    }
}
