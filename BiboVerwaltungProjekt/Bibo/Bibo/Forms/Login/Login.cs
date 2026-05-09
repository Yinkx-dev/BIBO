using Bibo.Core;
using Bibo.Forms.Personal;
using Bibo.Models;
using Bibo.Services;
using System;
using System.Windows.Forms;

namespace Bibo
{
    public partial class Login: UI_Helper
    {
        private LoginService loginService;

        public Login()
        {
            InitializeComponent();
            loginService = new LoginService();
            CloseApplicationOnUserClose = true;
        }

        //Login-Button Klick -> geht auch mit Enter
        private void login_btn_Click(object sender, EventArgs e)
        {
            //Eingaben in Variablen
            string username = username_tb.Text.Trim();
            string password = pw_tb.Text.Trim();

            //Eingaben mit Service prüfen
            var response = loginService.CheckLogin(username, password);
            //Aktion nach Ergebnis
            switch (response.Result)
            {
                //Admin loggt sich ein
                case LoginResult.Personal:
                    new HomePersonal().Show();
                    Hide();
                    break;

                //Kunde loggt sich ein
                case LoginResult.Kunde:
                    Globals.CurrentKunde = response.Kunde;

                    new HomeKunde().Show();
                    Hide();
                    break;

                //Eingabe falsch
                default:
                    MessageBox.Show("Benutzer nicht gefunden");
                    break;
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


        //Fokus bei Start auf Nutzername Textbox
        private void Login_Shown(object sender, EventArgs e)
        {
            username_tb.Focus();
        }
    }
}
