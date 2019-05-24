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
    public partial class EntitlementForm : SingleForm {

        public EntitlementController Controller;
        private EntitlementModel model;

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


        public EntitlementForm() {
            InitializeComponent(); if (DesignMode) return;
            Controller = (EntitlementController)DBControllersFactory.GetController(Entities.Entitlement);
            model = new EntitlementModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }




        private void EntitlementFormLoad(object sender, EventArgs e) {

        }

        private void EntitlementNameLookupLookUpSelected(object sender, EventArgs e) {
            this.txtEntitlementName.Text = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.Model = (EntitlementModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
