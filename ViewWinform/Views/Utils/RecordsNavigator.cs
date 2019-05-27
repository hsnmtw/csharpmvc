using System;
using System.Windows.Forms;

namespace MVCWinform.Common {
    public partial class RecordsNavigator : UserControl {

        
        public event EventHandler OnGotoFirstRecord,OnGotoNextRecord,OnGotoPreviousRecord,OnGotoLastRecord,OnNewClicked;

        private int position,total;
        public int Position {
            get { return this.position; }
            set {
                this.position = value;
                this.label1.Text = string.Format("{0}/{1}", position, total);
            }
        }
        public int TotalRecords {
            get { return this.total; }
            set {
                this.total = value;
                this.label1.Text = string.Format("{0}/{1}", position, total);
            }
        }

        private void Button3Click(object sender, EventArgs e) {
            if (TotalRecords < 1) return;
            if (Position < TotalRecords) {
                this.OnGotoNextRecord(sender, e);
                Position++;
            }
        }

        private void Button4Click(object sender, EventArgs e) {
            if (TotalRecords < 1) return;
            this.OnGotoLastRecord(sender, e);
            Position = TotalRecords;
        }

        private void Button2Click(object sender, EventArgs e) {
            if (TotalRecords < 1) return;
            if (Position > 1) {
                this.OnGotoPreviousRecord(sender, e);
                Position--;
            }
        }

        private void Button1Click(object sender, EventArgs e) {
            if (TotalRecords < 1) return;
            this.OnGotoFirstRecord(sender, e);
            Position = 1;
        }

        public RecordsNavigator() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
        }

        private void Button5Click(object sender, EventArgs e) {
            this.OnNewClicked(sender, e);
        }
    }
}
