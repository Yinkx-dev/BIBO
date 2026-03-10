using System;
using System.Windows.Forms;

public abstract class FormsGenerals : Form
{
    protected FormsGenerals()
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        this.FormClosing += FormsGenerals_FormClosing;
    }

    private void FormsGenerals_FormClosing(object sender, FormClosingEventArgs e)
    {
        //Nur aufrufen, wenn schließen und Alt+F4, nicht bei Close()
        if (e.CloseReason == CloseReason.UserClosing) // Nur, wenn User das X oder Alt+F4 drückt
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
    
    protected abstract bool ConfirmApplicationExit();
}