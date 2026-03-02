using Bibo.Models;
using Dapper;
using System;
using System.Data.SQLite;
using System.Drawing;
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
            Globals.AdjustDataGridView(tableKundeHome,panelTable.Height,panelTable.Width);
        }



        private void InsertData()
        {
            tableKundeHome.AutoGenerateColumns = true;

            //Dateipfad relativ zu bin/Debug
            string connectionString = @"Data Source=..\..\Database\database_BiBO.db;Version=3";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                //FALSCHE TABELLE!!! LEIH-TABELLE ausfüllen!!!!
                var result = conn.Query("SELECT * FROM Buch").ToList();
                tableKundeHome.DataSource = result;

                Kunde kundendaten = conn.Query<Kunde>($"SELECT * FROM Kunde WHERE KundenID is {Globals.CurrentKunde.KundenID}").FirstOrDefault();

                //var kundendaten = conn.Query($"SELECT * FROM Kunde WHERE ID is {Globals.CurrentKunde.KundenID}").ToList();
                nameText.Text = kundendaten.Name;
                string stringAddress = $"{kundendaten.Strasse} {kundendaten.Hausnummer}\n{kundendaten.Wohnort}";
                addressText.Text = stringAddress;
                birthdateText.Text = kundendaten.Geburtsdatum;
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentKunde = new Kunde();
            Globals.SessionLogin = new Login();
            Globals.SessionLogin.Show();
            Close();
        }
    }
}
