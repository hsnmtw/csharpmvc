using MVCHIS.Common;
using System;
using MVCHIS.Common;

namespace MVCHIS.Security {
    [ForModel(Common.MODELS.Audit)]
    public partial class AuditForm: AuditView {
        private MVCAdaptor<AuditController> adaptor;

        public virtual void UpdateModel() { var _ = Model; }

        public AuditForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
        }

        private void AuditView_Load(object sender, EventArgs e) {
            this.adaptor = new MVCAdaptor<AuditController>();
            this.adaptor.Requery();
        }
    }
    public class AuditView : BaseView<AuditModel, AuditController> { }
}
