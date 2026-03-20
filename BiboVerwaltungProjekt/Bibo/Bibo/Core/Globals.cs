using System;
using System.Windows.Forms;

namespace Bibo.Models
{
    public static class Globals
    {
        public static Kunde CurrentKunde { get; set; }

       
        //Dateipfad relativ zu bin/Debug
        public static Database Db = new Database(@"Data Source=..\..\Data\database_BiBO.db;Version=3");


        //Navigation zu neuer Seite -> [T = Ziel-Form]
        public static void NavigateToNextForm<T>(UI_Helper currentForm) where T : UI_Helper, new()
        {
            T destinationForm = new T();
            destinationForm.Show();

            //Verhindern, dass Close die ganze Anwendung schließt
            currentForm.CloseApplicationOnUserClose = false;
            currentForm.Close();
        }

        //Navigation zu neuer Seite mit Übergabeparameter -> [T = Ziel-Form]
        public static void NavigateToNextForm<T>(UI_Helper currentForm, params object[] args) where T : UI_Helper
        {
            T destinationForm = (T)Activator.CreateInstance(typeof(T), args);

            //null abfangen
            if (destinationForm == null)
            {
                throw new InvalidOperationException($"Form vom Typ {typeof(T).Name} konnte nicht erzeugt werden.");
            }

            destinationForm.Show();

            //Verhindern, dass Close die ganze Anwendung schließt
            currentForm.CloseApplicationOnUserClose = false;
            currentForm.Close();
        }



        //Automatisch dgv skalieren, aber funktioniert aktuell nur mittelprächtig
        public static void AdjustDataGridView(DataGridView dgv)
        {
            // Smart Auto-Size
            dgv.SuspendLayout();
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int contentWidth = 0;

            //Falls Row Header sichtbar
            if (dgv.RowHeadersVisible)
            {
                contentWidth += dgv.RowHeadersWidth;
            }


            foreach (DataGridViewColumn col in dgv.Columns)
                contentWidth += col.Width;

            int freeSpace = dgv.ClientSize.Width - contentWidth;
            
            if (freeSpace > 0 && dgv.Columns.Count > 0)
            {
                int extraPerColumn = freeSpace / dgv.Columns.Count;

                foreach (DataGridViewColumn col in dgv.Columns)
                    col.Width += extraPerColumn;
            }

            dgv.ResumeLayout();
        }
    }
}
