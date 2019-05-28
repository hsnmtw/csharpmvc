using MVCWinform.Common;
using System;
using ViewWinform.Common;

namespace MVCWinform.Security {
    [ForEntity(Entities.Entitlement)]
    public partial class EntitlementForm: EntitlementView {

        public EntitlementForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (EntitlementController)DBControllersFactory.GetController(Entities.Entitlement);
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
