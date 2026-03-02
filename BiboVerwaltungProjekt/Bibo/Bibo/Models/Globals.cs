using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo.Models
{
    public static class Globals
    {
        public static Kunde CurrentKunde { get; set; }

        public static Login SessionLogin { get; set; }



        public static void AdjustDataGridView(DataGridView dgv, int maxHeight, int maxWidth)
        {
            // Height
            int totalHeight= 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                totalHeight += row.Height;
            }

            dgv.Height = Math.Min(totalHeight, maxHeight);


            // Width
            int totalWidth = 0;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                totalWidth += col.Width;
            }

            dgv.Width = Math.Min(totalWidth, maxWidth);


            //Scrollbars
            if (totalHeight > maxHeight)
            {
                dgv.ScrollBars =ScrollBars.Vertical;
            }
            else if (totalHeight > maxHeight)
            {
                dgv.ScrollBars = ScrollBars.Horizontal;
            }
            else if (totalHeight > maxHeight && totalHeight > maxHeight)
            {
                dgv.ScrollBars = ScrollBars.Both;
            }
            else
            {
                dgv.ScrollBars = ScrollBars.None;
            }
        }
    }
}
