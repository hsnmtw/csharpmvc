using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(Common.MODELS.Entitlement)]
    public partial class EntitlementForm: EntitlementView {

        private Dictionary<int, EntitlementGroupModel> egs;
        private Dictionary<int, EntityModel> ets;

        private IDBController<EntitlementGroupModel> CntrlEG;// = DBControllersFactory.GetController<EntitlementGroupModel>();
        private IDBController<EntityModel>           CntrlET;// = DBControllersFactory.GetController<EntityModel>();

        public EntitlementForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            CntrlEG = DBControllersFactory.GetController<EntitlementGroupModel>();
            CntrlET = DBControllersFactory.GetController<EntityModel>();

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




        private void EntitlementFormLoad(object sender, EventArgs e) {
            egs = CntrlEG.Read().ToDictionary(x => x.Id, x => x);
            ets = CntrlET.Read().ToDictionary(x => x.Id, x => x);
        }

        private void EntitlementNameLookupLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new EntitlementModel() { EntitlementName = selected }, "EntitlementName");
        }

        private void TxtEntitlementGroupId_TextChanged(object sender, EventArgs e) {
            try {
                txtEntitlementGroupName.Text = egs[int.Parse(txtEntitlementGroupId.Text)].EntitlementGroupName;
            } catch { }
        }

        private void TxtEntityId_TextChanged(object sender, EventArgs e) {
            try {
                txtEntityName.Text = ets[int.Parse(txtEntityId.Text)].EntityName;
            } catch { }
        }
    }
    
}
