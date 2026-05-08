using Bibo.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class UI_Helper : Form
{
    internal bool CloseApplicationOnUserClose { get; set; } = true;

    protected UI_Helper()
    {
        //Wenn gerade Form noch aufgebaut wird, Finger weg hiervon sonst alles putt!!!
        if(LicenseManager.UsageMode == LicenseUsageMode.Designtime)
        {
            return;
        }

        this.FormClosing += FormsGenerals_FormClosing;
    }


    //Überall Form schließen wenn Kreuz/Alt+F4
    private void FormsGenerals_FormClosing(object sender, FormClosingEventArgs e)
    {
        //Wenn gerade Form noch aufgebaut wird, Finger weg hiervon sonst alles putt!!!
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
        {
            return;
        }

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
    protected static string GetStarString(int mengeSterne)
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


    //Methode für Nutzen von "Enter"/Doppelklick auf Datagridview-Zeile des Forms
    protected static void ActionOnDoubleclickOrEnterDatagridview(DataGridView dgv, Action<DataGridViewRow> action)
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


    //Methode für Nutzen von "Enter" auf "normalem" Element des Forms, falls sinnvoll
    protected static void ActionOnClickOrEnter(Control control, Action action)
    {
        control.Click += (s, e) => action();
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


    //Bilder in Zwischenspeicher statt Image FromFile, weil sonst Bild "festgehalten" wird
    //LISTENANSICHT
    protected static Image LoadCoverSafe(string path, int width = 60, int height = 90)
    {
        //Ob Datei da, sonst defaultCover
        string finalPath = File.Exists(path) ? path : Globals.DefaultCoverPath;

        //Bild in RAM
        using (var imgTemp = new Bitmap(finalPath))
        {
            //Größe ändern um RAM-Last zu minimieren
            return new Bitmap(imgTemp, new Size(width, height));
        }
    }

    //EINZELANSICHT
    protected static Image LoadCoverSafeBigger(string path)
    {
        string finalPath = File.Exists(path) ? path : Globals.DefaultCoverPath;

        using (var imgTemp = new Bitmap(finalPath))
        {
            return new Bitmap(imgTemp, new Size(250, 350));
        }
    }
}