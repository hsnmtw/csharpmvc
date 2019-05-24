using ControllerLibrary.Common;
using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Common {
    public enum RecordOperation {
        Save,Delete,New,Table
    }
    public partial class CommonView : Form {
        public delegate void RecordSpecificOperationHandler();
        public delegate void RecordOperationHandler(RecordOperation operation);
        public delegate void RecordPositionHandler(int index);
        public event RecordPositionHandler OnRecordPositionChanged;
        public event RecordOperationHandler OnRecordOperationInvoked;
        public event RecordSpecificOperationHandler OnSaveInvoked;
        public event RecordSpecificOperationHandler OnNewInvoked;
        public event RecordSpecificOperationHandler OnDeleteInvoked;
        public event RecordSpecificOperationHandler OnTableInvoked;

        private int position;
        private int totalRecords = 0;
        public int TotalRecords {
            get { return totalRecords; }
            set {
                totalRecords = value;
                if(value == 0) {
                    TsbNewClick1(null, null);
                }
            }
        }
        public int Position {
            get {
                return this.position;
            }
            set {
                position = value;
                this.tslRecordPosition.Text = string.Format("{0}/{1}",position,TotalRecords);
            }
        }

        public CommonView() {
            InitializeComponent(); if (DesignMode) return;
        }

        public void SetRecordPosition(int position) {
            if (position < 1 || position > TotalRecords) return;
            this.Position = position;
            this.OnRecordPositionChanged(position - 1);
        }

        private void TsbFirstClick(object sender, EventArgs e) {
            SetRecordPosition(1);
        }

        private void TsbLastClick(object sender, EventArgs e) {
            SetRecordPosition(TotalRecords);
        }

        private void TsbPreviousClick(object sender, EventArgs e) {
            SetRecordPosition(Position - 1);
        }

        private void TsbNextClick(object sender, EventArgs e) {
            SetRecordPosition(Position + 1);
        }

        private void TsbSaveClick(object sender, EventArgs e) {
            if (this.OnRecordOperationInvoked != null) this.OnRecordOperationInvoked(RecordOperation.Save);
            if(this.OnSaveInvoked != null) this.OnSaveInvoked(); 
        }



        private void TsbTableViewClick(object sender, EventArgs e) {
            if (this.OnRecordOperationInvoked != null) this.OnRecordOperationInvoked(RecordOperation.Table);
            if(this.OnTableInvoked!=null) this.OnTableInvoked();
        }

        private void TsbNewClick1(object sender, EventArgs e) {
            if (this.OnRecordOperationInvoked != null) this.OnRecordOperationInvoked(RecordOperation.New);
            if(this.OnNewInvoked!=null) this.OnNewInvoked();
            this.tslRecordPosition.Text = "new record";
        }

        private void TsbDeleteClick1(object sender, EventArgs e) {
            if (this.OnRecordOperationInvoked != null) this.OnRecordOperationInvoked(RecordOperation.Delete);
            if (this.OnDeleteInvoked != null) this.OnDeleteInvoked();
        }
    }
}
