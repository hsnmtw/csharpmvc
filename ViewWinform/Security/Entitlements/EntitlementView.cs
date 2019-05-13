using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ViewWinform.Common;
using ControllerLibrary.Security;
using ModelLibrary.Security;

namespace ViewWinform.Security.Entitlements {
    public partial class EntitlementView : CommonView {
        private MVCAdaptor<EntitlementController, EntitlementModel> adaptor;
        public EntitlementView() {
            InitializeComponent();
            this.adaptor = new MVCAdaptor<EntitlementController, EntitlementModel>();
            this.adaptor.Requery();
            this.TotalRecords = adaptor.Count;
            this.SetRecordPosition(1);
        }

        private void EntitlementView_OnRecordOperationInvoked(RecordOperation operation) {
        }

        private void EntitlementView_OnRecordPositionChanged(int index) {
            this.entitelmentFormView1.model = adaptor[index];
        }

        private void EntitlementView_OnSaveInvoked() {
            EntitlementModel model = this.entitelmentFormView1.model;
            this.adaptor.Controller.save(model);
            this.adaptor.Requery();
            this.TotalRecords = this.adaptor.Count;
            this.SetRecordPosition(adaptor.Count-1);
        }

        private void EntitlementView_OnTableInvoked() {
            Utils.FormsHelper.errorMessage("COMING SOON !!!");
        }

        private void EntitlementView_OnDeleteInvoked() {
            EntitlementModel model = this.entitelmentFormView1.model;
            this.adaptor.Controller.delete(model);
            this.adaptor.Requery();
            this.TotalRecords = this.adaptor.Count;
            this.SetRecordPosition(1);
        }

        private void EntitlementView_OnNewInvoked() {
            this.entitelmentFormView1.model = new EntitlementModel();

        }
    }
}
