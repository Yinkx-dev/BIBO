using System;
using System.Windows.Forms;
using Bibo.Models;
using Bibo.Forms.Personal;

namespace Bibo
{
    public partial class Login: UI_Helper
    {
        public Login()
        {
            InitializeComponent();
            CloseApplicationOnUserClose = true;
        }

        //Login-Button Klick -> geht auch mit Enter
        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_tb.Text.Trim();
            string password = pw_tb.Text.Trim();

            //PERSONAL-LOGIN!
            //Prüfen, ob Admin sich einloggt, wenn ja, ab zu PersonalHome
            var personal = Globals.Db.QuerySingle<Personal>("SELECT * FROM Personal");
            
            if(username == personal.Nutzername && password == personal.Kennwort)
            {
                HomePersonal homePersonal = new HomePersonal();
                homePersonal.Show();
                Hide();
                return;
            }


            //KUNDEN-LOGIN!
            //Datenbank Connection für Kunde
            var kunde = Globals.Db.QuerySingle<Kunde>(
                "SELECT * FROM Kunde WHERE Nutzername = @username AND Passwort = @password",
                new { username, password }
            );
            //Nur einloggen versuchen, wenn ein Kunde vorhanden ist
            if (kunde != null)
            {
                Globals.CurrentKunde = kunde;
                HomeKunde homeKundeForm = new HomeKunde();
                homeKundeForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Benutzer nicht gefunden");
            }
        }

        //Zwischen Passwort-Char und normalen Zeichen hin und herschalten mit der checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
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
