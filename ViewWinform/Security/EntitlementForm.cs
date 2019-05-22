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

namespace ViewWinform.Security.Entitlements {
    public partial class EntitlementForm : SingleForm {
        public EntitlementForm() {
            InitializeComponent();
        }


        public EntitlementController Controller => (EntitlementController)ControllersFactory.GetController(Entities.Entitlement);
        private EntitlementModel model = new EntitlementModel();

        public EntitlementModel Model {
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
            
            this.Model = new EntitlementModel();
        }

        private void EntitlementNameLookupLookUpSelected(object sender, EventArgs e) {
            this.txtEntitlementName.Text = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.Model = (EntitlementModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
