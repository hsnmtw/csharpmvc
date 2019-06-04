using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.Entitlement)]
    public partial class EntitlementForm: EntitlementView {

        public EntitlementForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
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
        }

        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(DBControllersFactory.GetController<EntitlementGroupModel>());
            FK.Put(DBControllersFactory.GetController<EntityModel>());
            base.LoadForeignKeys(FK);
        }


        private void EntitlementFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void EntitlementNameLookupLookUpSelected(object sender, EventArgs e) {
            
            Model = Controller.Find(new EntitlementModel() { EntitlementName = txtEntitlementName.Text }, "EntitlementName");
        }

        private void TxtEntitlementGroupId_TextChanged(object sender, EventArgs e) {
            txtEntitlementGroupName.Text = ForeignKeys.Instance[MODELS.EntitlementGroup, txtEntitlementGroupId.Text];
        }

        private void TxtEntityId_TextChanged(object sender, EventArgs e) {
            txtEntityName.Text = ForeignKeys.Instance[MODELS.Entity, txtEntityId.Text];
        }
    }
    
}
