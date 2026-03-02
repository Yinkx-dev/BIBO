using Bibo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // LoginForm in Variable speichern
            Login loginForm = new Login();
            Globals.SessionLogin = loginForm;

            // Run starten
            Application.Run(Globals.SessionLogin);



            //Application.Run(new Login());
        }
    }
}
