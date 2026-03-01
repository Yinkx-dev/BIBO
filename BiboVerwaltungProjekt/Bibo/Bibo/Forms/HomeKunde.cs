using Bibo.Models;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo
{
    public partial class HomeKunde: Form
    {
        private Kunde _kunde;
        public HomeKunde()
        {
            InitializeComponent();
            _kunde = Globals.CurrentKunde;

        }



        //private void TableBooksKundeHome(object sender, DataGridViewCellEventArgs e)
        //{
        //    //Dateipfad relativ zu bin/Debug
        //    string connectionString = @"Data Source=..\..\Database\database_BiBO.db;Version=3";

        //    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        //    {
        //        conn.Open();
        //    }
        //}
    }
}
