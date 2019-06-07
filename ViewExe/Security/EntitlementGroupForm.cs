using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.EntitlementGroup)]
    public partial class EntitlementGroupForm: EntitlementGroupView {

 
        public EntitlementGroupForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
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
            //pick lists
            PickList[btnPLEntitlementGroup] = txtId;
        }

        private void EntitlementGroupFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }        
    }
    
}
