using MVCHIS.Common;
using System;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.Audit)]
    public partial class AuditForm: AuditView {
        private MVCAdaptor<AuditModel,AuditController> adaptor;

        public virtual void UpdateModel() { var _ = Model; }

        public AuditForm() {
            InitializeComponent();
        }

        private void AuditView_Load(object sender, EventArgs e) { if (DesignMode) return;
            this.adaptor = new MVCAdaptor<AuditModel,AuditController>();
            this.adaptor.Requery();
        }
    }
    
}
