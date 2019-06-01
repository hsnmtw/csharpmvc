using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Billing {

    //[ForModel(Common.MODELS.BillingCycle)]
    public partial class BillingCycleForm: BillingCycleView {

        public BillingCycleForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            
            var type = typeof(BillingCycleModel);
            //template
            Mapper["Id"       ] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["BillingCycleYear"] = txtBillingCycleYear;
            Mapper["BillingCycleMonth"] = txtBillingCycleMonth;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new BillingCycleModel() { Id = int.Parse($"0{selected}") }, "Id");
        }

        private void BillingCycleFormLoad(object sender, EventArgs e) {
            
        }
    }
    
}
