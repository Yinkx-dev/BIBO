using System.Windows.Forms;

namespace Bibo.Models
{
    public static class Globals
    {
        public static Kunde CurrentKunde { get; set; }

        public static Login SessionLogin { get; set; }
       
        //Dateipfad relativ zu bin/Debug
        public static Database Db = new Database(@"Data Source=..\..\Data\database_BiBO.db;Version=3");


        //Funktioniert aktuell nur mittelprächtig
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
