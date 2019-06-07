using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Linq;
using System.Collections.Generic;
using MVCHIS.Utils;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.Entitlement)]
    public partial class EntitlementForm: EntitlementView {

        public EntitlementForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = PickList[btnPLEntitlement] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data

            Mapper["EntitlementName"] = txtEntitlementName;
            Mapper["EntitlementGroupId"] = txtEntitlementGroupId;
            Mapper["EntityId"] = txtEntityId;
            //action
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLEntitlementGroup] = txtEntitlementGroupId;
            PickList[btnPLEntity] = txtEntityId;
        }

        private void EntitlementFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void TxtEntitlementGroupId_TextChanged(object sender, EventArgs e) {
            txtEntitlementGroupName.Text = DBControllersFactory.FK(MODELS.EntitlementGroup, txtEntitlementGroupId.Text);
        }

        private void TxtEntityId_TextChanged(object sender, EventArgs e) {
            txtEntityName.Text = DBControllersFactory.FK(MODELS.Entity, txtEntityId.Text);
        }

        

        private void EntitlementGroupNameLookup_LookUpSelected(int obj) {
            txtEntitlementGroupId.Text = obj.ToString();
        }

        private void LookUpEntityName_LookUpSelected(int obj) {
            txtEntityId.Text = obj.ToString();
        }
    }
    
}
