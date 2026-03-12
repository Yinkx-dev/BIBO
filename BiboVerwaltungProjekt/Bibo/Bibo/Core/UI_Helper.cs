using System;
using System.Windows.Forms;

public class UI_Helper : Form
{
    protected bool CloseApplicationOnUserClose { get; set; } = true;

    protected UI_Helper()
    {
        this.FormClosing += FormsGenerals_FormClosing;
    }

    private void FormsGenerals_FormClosing(object sender, FormClosingEventArgs e)
    {
        //Nur aufrufen, wenn schließen über kreuz oder Alt+F4, nicht bei Close()
         if (CloseApplicationOnUserClose && e.CloseReason == CloseReason.UserClosing) // Nur, wenn User das X oder Alt+F4 drückt
        {
            // Form kann schließen abbrechen
            bool shouldClose = ConfirmApplicationExit();
            if (!shouldClose)
            {
                e.Cancel = true;
                return;
            }
            Application.Exit();
        }
    }
    
    //Für Implementierung von Abfragen vor dem Schließen
    protected virtual bool ConfirmApplicationExit()
    {
        return true;
    }
}