using Bibo.Models;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;

namespace Bibo.Forms.Personal
{
    public partial class Buchmodifikation : UI_Helper
    {
        private Buch _buch;

        public Buchmodifikation(Buch buch)
        {
            InitializeComponent();
            _buch = buch;
            InsertData();
        }

        private void InsertData()
        {
            if( _buch != null)
            {
                //"simple" Textboxen
                textBoxTitel.Text = _buch.Titel;
                textBoxAutor.Text = _buch.Autor;
                textBoxISBN.Text = _buch.ISBN;
                richTextBoxKurzbeschreibung.Text = _buch.Kurzbeschreibung;

                //Textbox Erscheinungsdatum [Umwandlung in richtiges Format]
                DateTime date = DateTime.ParseExact(_buch.Erscheinungsdatum, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string output = date.ToString("dd.MM.yyyy");
                textBoxErscheinungsdatum.Text = output;

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

                if (File.Exists(coverPfad))
                {
                    pictureBoxCover.Image = Image.FromFile(coverPfad);
                }
                else
                {
                    pictureBoxCover.Image = Image.FromFile($@"..\..\Images\DefaultCover.jpg");
                }
            }
        }

        private void buttonHomeBuchModi_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }

        private void buttonAbbrechenBuchmodi_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<HomePersonal>(this);
        }

        private void buttonZurueckBuecherliste_Click(object sender, EventArgs e)
        {
            Globals.NavigateToNextForm<BuecherlistePersonal>(this);
        }
    }
}
