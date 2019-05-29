using MVCHIS.Common;
using System;
using ViewWinform.Common;

namespace MVCHIS.Security {
    [ForModel(Common.MODELS.Entitlement)]
    public partial class EntitlementForm: EntitlementView {

        public EntitlementForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            base.Controller = (EntitlementController)DBControllersFactory.GetController(Common.MODELS.Entitlement);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["EntityName"] = txtEntityName;
            Mapper["EntitlementName"] = txtEntitlementName;
            Mapper["EntitlementGroupName"] = txtEntitlementGroupName;
            //action
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }




        private void EntitlementFormLoad(object sender, EventArgs e) {

        }

        private void EntitlementNameLookupLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new EntitlementModel() { EntitlementName = selected }, "EntitlementName");
        }
    }
    public class EntitlementView : BaseView<EntitlementModel, EntitlementController> { }
}
