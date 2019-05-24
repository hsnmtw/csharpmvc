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
    public partial class EntitlementGroupForm : SingleForm {

        public EntitlementGroupController Controller;
        private EntitlementGroupModel model;

        public EntitlementGroupForm() {
            InitializeComponent(); if (DesignMode) return;
            Controller = (EntitlementGroupController)DBControllersFactory.GetController(Entities.EntitlementGroup);
            model = new EntitlementGroupModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }

        public EntitlementGroupModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtEntitlementGroupName.Select();
                this.txtEntitlementGroupName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }


        private void EntitlementGroupFormLoad(object sender, EventArgs e) {

        }

        private void EntitlementGroupNameLookupLookUpSelected(object sender, EventArgs e) {
            this.txtEntitlementGroupName.Text = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.Model = (EntitlementGroupModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
