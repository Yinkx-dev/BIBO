using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Bibo.Models;
using System.IO;
using Dapper;
using System.Linq;

namespace Bibo
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text.Trim();
            string password = pw_tb.Text.Trim();

            //Dateipfad relativ zu bin/Debug
            string connectionString = @"Data Source=..\..\Database\database_BiBO.db;Version=3";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                //ORM Dapper
                var kunde = conn.Query<Kunde>("SELECT * FROM Kunde WHERE Nutzername = @username AND Passwort = @password", new { username, password }).FirstOrDefault();

                if (kunde != null)
                {
                    Globals.CurrentKunde = kunde;

                    HomeKunde homeKundeForm = new HomeKunde();
                    homeKundeForm.Show();
                    Hide();

                    //KONTROLLAUSGABE
                    //Console.WriteLine($"Hello, {Globals.CurrentKunde.KundenID}!");
                }
                else
                {
                    MessageBox.Show("Benutzer nicht gefunden");
                }
            }
        }

        private void pw_tb_TextChanged(object sender, EventArgs e)
        {
            pw_tb.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(pw_tb.UseSystemPasswordChar)
            {
                pw_tb.UseSystemPasswordChar = false;
            }
            else
            {
                pw_tb.UseSystemPasswordChar = true;
            }
        }
    }
}
