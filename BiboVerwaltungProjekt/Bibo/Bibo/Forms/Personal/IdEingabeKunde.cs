using Bibo.Models;
using Bibo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo.Forms.Personal
{
    //erbt NICHT von UI_HElper, da als "MessageBox" fungiert
    public partial class IdEingabeKunde : Form
    {
        private BuecherlistePersonalViewModel _selectedBuchVm;

        public IdEingabeKunde(BuecherlistePersonalViewModel selectedBuchVm)
        {
            InitializeComponent();
            _selectedBuchVm = selectedBuchVm;
        }


        //Eingaben bestätigen & in Db speichern
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //try catch für ggf exception besser auswerten und falsche Daten in db verhindern
            try
            {
                //Buch auf ausgeliehen setzen
                string updateBuch = @"UPDATE Buch
                                      SET IstAusgeliehen = 1
                                      WHERE ISBN = @ISBN";

                Globals.Db.Execute(updateBuch, new
                {
                    ISBN = _selectedBuchVm.Buch.ISBN
                });


                //Eintrag in Ausleihen erstellen
                string insertAusleihen = @"
                INSERT INTO Ausleihen
                (
                    KundenID,
                    ISBN,
                    Ausleihdatum,
                    Rueckgabedatum
                )
                VALUES
                (
                    @KundenID,
                    @ISBN,
                    @Ausleihdatum,
                    @Rueckgabedatum
                )";

                Globals.Db.Execute(insertAusleihen, new
                {
                    KundenID = _selectedBuchVm.Ausleihen.KundenID,
                    ISBN = _selectedBuchVm.Ausleihen.ISBN,
                    Ausleihdatum = _selectedBuchVm.Ausleihen.Ausleihdatum,
                    Rueckgabedatum = _selectedBuchVm.Ausleihen.Rueckgabedatum
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Fenster schließen
            this.Close();
        }


        //Eingabe abbrechen
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Eingabe-Validierung und temporär Daten speichern
        private void buttonCheckID_Click(object sender, EventArgs e)
        {
            //Test, dass wirklich Zahl eingegeben
            if (!int.TryParse(textBoxKundenID.Text, out int kundenID))
            {
                MessageBox.Show("Bitte eine gültige Zahl eingeben.");
                return;
            }

            //db-Abfrage, ob Kunde da
            var resultKunde = Globals.Db.QuerySingle<Kunde>(
                @"SELECT * FROM Kunde WHERE KundenID = @kundenID",
                new { kundenID }
                );

            //Kein Kunde mit der ID vorhanden
            if (resultKunde == null)
            {
                labelKundeName.Visible = true;
                labelKundeName.ForeColor = Color.Red;
                labelKundeName.Text = "Kunde nicht gefunden";
            }
            //Kunde vorhanden -> Benötigte Daten temporär in ViewModel (DB erst, wenn bestätigt!)
            else
            {
                labelKundeName.Visible = true;
                labelKundeName.ForeColor = Color.Black;
                labelKundeName.Text = resultKunde.Name;

                //Werte TEMPORÄR setzen
                //Bool in Buch
                _selectedBuchVm.Buch.IstAusgeliehen = true;

                //Ausleihen
                _selectedBuchVm.Ausleihen = new Ausleihen
                {
                    KundenID = kundenID,
                    ISBN = _selectedBuchVm.Buch.ISBN,
                    Ausleihdatum = DateTime.Today.ToString("yyyy-MM-dd"),
                    Rueckgabedatum = DateTime.Today.AddDays(14).ToString("yyyy-MM-dd")
                };
            }
        }
    }
}
