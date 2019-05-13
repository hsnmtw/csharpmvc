using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManagerLibrary.Utils
{
    class CustomDataGridView : DataGridView
    {
        public CustomDataGridView() : base() {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.ReadOnly = true;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.EnableHeadersVisualStyles = false;
            this.Font = new System.Drawing.Font("Consals", 8);
            this.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.RowHeadersWidth = 30;
            this.Dock = DockStyle.Fill;
        }
    }
}
