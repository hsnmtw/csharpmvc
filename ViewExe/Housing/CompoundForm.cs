using MVCHIS.Common;
using System;

namespace MVCHIS.Housing {
    //[ForModel(Common.MODELS.Compound)]
    public partial class CompoundForm: CompoundView {

        

        public CompoundForm() {
            InitializeComponent();
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
        }

        private void CompoundNameLookupButtonLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new CompoundModel() { CompoundName = selected }, "CompoundName");
        }

        private void CompoundForm_Load(object sender, EventArgs e) { if (DesignMode) return;

        }
    }
    
}
