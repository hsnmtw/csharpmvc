using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Linq;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Project)]
    public partial class ProjectForm: ProjectView {

        //private ClientController CntrlCL;

        public ProjectForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ProjectName"] = txtProjectName;
            Mapper["ClientId"] = txtClientId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick list
            PickList[btnPLClient] = txtClientId;
            PickList[btnPLProject] = txtId;
        }

        private void ProjectTypeFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            
        }

        private void TxtClientId_TextChanged(object sender, EventArgs e) {
            txtClientShortName.Text = DBControllersFactory.FK(MODELS.Client, txtClientId.Text);
        }

        
    }
    
}
