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

namespace ViewWinform.Security {
    public partial class AuditView : Common.CommonView {
        private MVCAdaptor<AuditController> adaptor;

        private AuditModel model = new AuditModel();
        public AuditModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);
            }
        }
        public virtual void UpdateModel() { var _ = Model; }

        public AuditView() {
            InitializeComponent();
            this.adaptor = new MVCAdaptor<AuditController>();
            this.adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(1);
        }

        private void AuditViewOnRecordPositionChanged(int index) {
            this.Model = (AuditModel)this.adaptor[index];
        }

        private void AuditViewOnRecordOperationInvoked(RecordOperation operation) {
            if (operation == RecordOperation.Table) {
                Utils.FormsHelper.Error("COMING SOON !!!");
            } else {
                Utils.FormsHelper.Error("Action has no effect ...");
            }
        }

        private void AuditView_Load(object sender, EventArgs e) {

        }
    }
}
