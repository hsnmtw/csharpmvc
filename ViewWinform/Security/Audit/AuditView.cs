using ControllerLibrary.Security;
using ViewWinform.Common;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Security.Audit {
    public partial class AuditView : Common.CommonView {
        private MVCAdaptor<AuditController> adaptor;
        public AuditView() {
            InitializeComponent();
            this.adaptor = new MVCAdaptor<AuditController>();
            this.adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(1);
        }

        private void AuditView_OnRecordPositionChanged(int index) {
            this.auditFormView1.Model = (AuditModel)this.adaptor[index];
        }

        private void AuditView_OnRecordOperationInvoked(RecordOperation operation) {
            if (operation == RecordOperation.Table) {
                Utils.FormsHelper.errorMessage("COMING SOON !!!");
            } else {
                Utils.FormsHelper.errorMessage("Action has no effect ...");
            }
        }
    }
}
