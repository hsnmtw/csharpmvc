using MVCWinform.Common;
using System;

namespace MVCWinform.Security {
    [ForEntity(Entities.Audit)]
    public partial class AuditForm : SingleForm {
        private MVCAdaptor<AuditController> adaptor;

        private AuditModel model = new AuditModel();
        public AuditModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);
            }
        }
        public virtual void UpdateModel() { var _ = Model; }

        public AuditForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
        }

        private void AuditViewOnRecordPositionChanged(int index) {
            var row = this.adaptor[index];
            this.Model = new AuditModel() {
                 Id            = Convert.ToInt32(row["Id"])
                ,EventComments = Convert.ToString(row["EventComments"])
                ,UserName      = Convert.ToString(row["UserName"])
                ,EventDate     = Convert.ToDateTime(row["EventDate"])
            };
        }


        private void AuditView_Load(object sender, EventArgs e) {
            this.adaptor = new MVCAdaptor<AuditController>();
            this.adaptor.Requery();
        }
    }
}
