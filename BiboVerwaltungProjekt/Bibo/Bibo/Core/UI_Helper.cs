using System;
using System.Windows.Forms;

public class UI_Helper : Form
{
    protected bool CloseApplicationOnUserClose { get; set; } = true;

    
    protected UI_Helper()
    {
        this.FormClosing += FormsGenerals_FormClosing;
    }


    //Überall Form schließen wenn Kreuz/Alt+F4
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


    // Methode für Sternanzeige
    public static string GetStarString(int mengeSterne)
    {
        int maxStars = 5;
        string stars = "";

        if(mengeSterne == 0)
        {
            stars = "- - - - -";
            return stars;
        }

        for (int i = 0; i < maxStars; i++)
        {
            if (i < mengeSterne)
                stars += "★";
            else
                stars += "☆";
        }

        return stars;
    }


    //Methode für Nutzen von "Enter" auf "normalem" Element des Forms
    public static void ActionOnClickOrEnter(Control control, Action action)
    {
        control.Click += (s,e) => action();
        control.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                action();
            }
        };
    }

    //Methode für Nutzen von "Enter"/Doppelklick auf Datagridview-Zeile des Forms
    public static void ActionOnDoubleclickOrEnterDatagridview(DataGridView dgv, Action<DataGridViewRow> action)
    {
        //Für Enter
        dgv.KeyDown += (s, e) =>
        {
            //Andere Tasten "in Ruhe lassen"
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
            if(dgv.CurrentRow != null)
            {
                action(dgv.CurrentRow);
            }
        };

        //Für Doppelklick auf Zelle -> Aktion für Zeile
        dgv.CellDoubleClick += (s, e) =>
        {
            if(e.RowIndex >= 0)
            {
                //Fokus auf geklickte Zeile
                dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[0];
                //Aktion wie Enter, aber mit geklickter Zeile
                action(dgv.Rows[e.RowIndex]);
            }
        };
    }
}