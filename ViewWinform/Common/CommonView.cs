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

        public string ResponseMessage {
            get {
                return textBox1.Text;
            }
            set {
                textBox1.Text = value;
            }
        }

        private int _position;
        private int _totalRecords = 0;
        public int TotalRecords {
            get { return _totalRecords; }
            set {
                _totalRecords = value;
                if(value == 0) {
                    TsbNew_Click_1(null, null);
                }
            }
        }
        public int Position {
            get {
                return this._position;
            }
            set {
                _position = value;
                this.tslRecordPosition.Text = string.Format("{0}/{1}",_position,TotalRecords);
            }
        }

        public CommonView() {
            InitializeComponent();
        }

        public void SetRecordPosition(int position) {
            if (position < 1 || position > TotalRecords) return;
            this.Position = position;
            this.OnRecordPositionChanged(position - 1);
        }

        private void TsbFirst_Click(object sender, EventArgs e) {
            SetRecordPosition(1);
        }

        private void TsbLast_Click(object sender, EventArgs e) {
            SetRecordPosition(TotalRecords);
        }

        private void TsbPrevious_Click(object sender, EventArgs e) {
            SetRecordPosition(Position - 1);
        }

        private void TsbNext_Click(object sender, EventArgs e) {
            SetRecordPosition(Position + 1);
        }

        private void TsbSave_Click(object sender, EventArgs e) {
            if (this.OnRecordOperationInvoked != null) this.OnRecordOperationInvoked(RecordOperation.Save);
            if(this.OnSaveInvoked != null) this.OnSaveInvoked(); 
        }

        private void TsbDelete_Click(object sender, EventArgs e) {
            if (this.OnRecordOperationInvoked != null) this.OnRecordOperationInvoked(RecordOperation.Delete);
            if(this.OnDeleteInvoked!=null) this.OnDeleteInvoked();
        }


        private void TsbTableView_Click(object sender, EventArgs e) {
            if (this.OnRecordOperationInvoked != null) this.OnRecordOperationInvoked(RecordOperation.Table);
            if(this.OnTableInvoked!=null) this.OnTableInvoked();
        }

        private void TsbNew_Click_1(object sender, EventArgs e) {
            if (this.OnRecordOperationInvoked != null) this.OnRecordOperationInvoked(RecordOperation.New);
            if(this.OnNewInvoked!=null) this.OnNewInvoked();
            this.tslRecordPosition.Text = "new record";
        }
    }
}
