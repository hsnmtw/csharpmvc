using ControllerLibrary.Common;
using ControllerLibrary.Security;
using ModelLibrary.Common;
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
using ViewWinform.Common;

namespace ViewWinform.Security {
    public partial class ProfileEntitlementForm : SingleForm {
        public ProfileEntitlementForm() {
            InitializeComponent();
        }


        public ProfileEntitlementsController Controller => (ProfileEntitlementsController)ControllersFactory.GetController(Entities.ProfileEntitlement);
        private ProfileEntitlementsModel model = new ProfileEntitlementsModel();

        public ProfileEntitlementsModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtEntitlementName.Select();
                this.txtEntitlementName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        private void EntitlementFormLoad(object sender, EventArgs e) {
            Utils.FormsHelper.BindViewToModel(this,ref this.model);
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
