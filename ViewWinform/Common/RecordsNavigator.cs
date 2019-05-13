using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Common {
    public partial class RecordsNavigator : UserControl {

        
        public event EventHandler OnGotoFirstRecord,OnGotoNextRecord,OnGotoPreviousRecord,OnGotoLastRecord,OnNewClicked;

        private int _position,_total;
        public int Position {
            get { return this._position; }
            set {
                this._position = value;
                this.label1.Text = string.Format("{0}/{1}", _position, _total);
            }
        }
        public int TotalRecords {
            get { return this._total; }
            set {
                this._total = value;
                this.label1.Text = string.Format("{0}/{1}", _position, _total);
            }
        }

        private void Button3_Click(object sender, EventArgs e) {
            if (TotalRecords < 1) return;
            if (Position < TotalRecords) {
                this.OnGotoNextRecord(sender, e);
                Position++;
            }
        }

        private void Button4_Click(object sender, EventArgs e) {
            if (TotalRecords < 1) return;
            this.OnGotoLastRecord(sender, e);
            Position = TotalRecords;
        }

        private void Button2_Click(object sender, EventArgs e) {
            if (TotalRecords < 1) return;
            if (Position > 1) {
                this.OnGotoPreviousRecord(sender, e);
                Position--;
            }
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (TotalRecords < 1) return;
            this.OnGotoFirstRecord(sender, e);
            Position = 1;
        }

        public RecordsNavigator() {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e) {
            this.OnNewClicked(sender, e);
        }
    }
}
