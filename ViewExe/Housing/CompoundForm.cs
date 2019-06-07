using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Housing {
    //[ForModel(Common.MODELS.Compound)]
    public partial class CompoundForm: CompoundView {

        

        public CompoundForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["CompoundName"] = txtCompoundName;
            Mapper["CompoundLocation"] = txtCompoundLocation;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLCompound] = txtId;
        }

        private void CompoundForm_Load(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        
    }
    
}
