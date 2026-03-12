using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bibo.Core
{
    public class CursorManager
    {
        //Variable für Cursor-Management bei DataGridView
        private readonly Dictionary<DataGridView, List<int>> dgvColumns = new Dictionary<DataGridView, List<int>>();

        // DataGridView-Spalte(n)
        public void AttachDataGridViewColumn(DataGridView dgv, params string[] columnNames)
        {
            if (!dgvColumns.ContainsKey(dgv))
                dgvColumns[dgv] = new List<int>();

            foreach (var name in columnNames)
            {
                if (dgv.Columns.Contains(name))
                    dgvColumns[dgv].Add(dgv.Columns[name].Index);
            }

            dgv.CellMouseEnter += Dgv_CellMouseEnter;
            dgv.CellMouseLeave += Dgv_CellMouseLeave;
        }

        private void Dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dgv && dgvColumns.TryGetValue(dgv, out var cols))
            {
                if (e.RowIndex >= 0 && cols.Contains(e.ColumnIndex))
                    dgv.Cursor = Cursors.Hand;
            }
        }

        private void Dgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dgv)
                dgv.Cursor = Cursors.Default;
        }


        //"normale" ELemente
        public void AttachHandCursor(Control ctrl)
        {
            ctrl.MouseEnter += Control_MouseEnter;
            ctrl.MouseLeave += Control_MouseLeave;
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Control ctrl)
                ctrl.Cursor = Cursors.Hand;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Control ctrl)
                ctrl.Cursor = Cursors.Default;
        }
    }
}
