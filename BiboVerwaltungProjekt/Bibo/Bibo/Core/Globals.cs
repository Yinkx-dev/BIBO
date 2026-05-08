using System;
using System.IO;
using System.Windows.Forms;

namespace Bibo.Models
{
    public static class Globals
    {
        public static Kunde CurrentKunde { get; set; }

        //Pfad von DefaultCover
        public static string DefaultCoverPath = $@"..\..\Images\DefaultCover.jpg";

        //Dateipfad relativ zu bin/Debug
        //public static Database Db = new Database(@"Data Source=..\..\Data\database_BiBO.db;Version=3");
        public static Database Db = CreateDb();

        private static Database CreateDb()
        {
            string binDir = AppDomain.CurrentDomain.BaseDirectory;

            DirectoryInfo dir = new DirectoryInfo(binDir);

            // 3 Ebenen hoch (typisch bin -> Debug -> netX -> project)
            string projectDir = dir.Parent?.Parent?.Parent?.FullName;

            string dbPath = Path.Combine(projectDir, "Bibo", "Data", "database_BiBO.db");

            string conn = $"Data Source={dbPath};Version=3";

            Console.WriteLine("binDir: " + binDir);
            Console.WriteLine("projectDir: " + projectDir);
            Console.WriteLine("DB Path: " + dbPath);

            return new Database(conn);
        }


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
