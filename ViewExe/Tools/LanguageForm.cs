using MVCHIS.Utils;
using System;
using MVCHIS.Common;
using MVCHIS.Tools;

namespace MVCHIS.Common {
    //[ForModel(Common.MODELS.Language)]
    public partial class LanguageForm: LanguageView {
        
        public LanguageForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = PickList[btnPLLanguage] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"]  = chkReadOnly;
            //data
            Mapper["LanguageName"] = txtLanguageName;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
        }

        private void LanguageFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }        
    }    
}
