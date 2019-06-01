using MVCHIS.Common;
using System;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.EntitlementGroup)]
    public partial class EntitlementGroupForm: EntitlementGroupView {

 
        public EntitlementGroupForm() {
            InitializeComponent();
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

        private void EntitlementGroupFormLoad(object sender, EventArgs e) { if (DesignMode) return;

        }

        private void EntitlementGroupNameLookupLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new EntitlementGroupModel() { EntitlementGroupName = selected }, "EntitlementGroupName");
        }
    }
    
}
