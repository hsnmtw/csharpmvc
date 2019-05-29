using MVCHIS.Common;
using System;
using ViewWinform.Common;

namespace MVCHIS.Security {
    [ForEntity(Entities.EntitlementGroup)]
    public partial class EntitlementGroupForm: EntitlementGroupView {

 
        public EntitlementGroupForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (EntitlementGroupController)DBControllersFactory.GetController(Entities.EntitlementGroup);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["EntitlementGroupName"] = txtEntitlementGroupName;
            Mapper["Dynamic"] = chkDynamic;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void EntitlementGroupFormLoad(object sender, EventArgs e) {

        }

        private void EntitlementGroupNameLookupLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new EntitlementGroupModel() { EntitlementGroupName = selected }, "EntitlementGroupName");
        }
    }
    public class EntitlementGroupView : BaseView<EntitlementGroupModel, EntitlementGroupController> { }
}
