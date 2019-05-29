using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Customers {
    [ForModel(Common.MODELS.Project)]
    public partial class ProjectForm: ProjectView {

        
        

        public ProjectForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;; //(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            base.Controller = (ProjectController)DBControllersFactory.GetController(Common.MODELS.Project);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ProjectName"] = txtProjectName;
            Mapper["ClientShortName"] = txtClientShortName;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }


        private void ProjectTypeFormLoad(object sender, EventArgs e) {

        }

        private void LookUpButtonProjectNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new ProjectModel() { ProjectName = selected }, "ProjectName");
        }
    }
    public class ProjectView : BaseView<ProjectModel, ProjectController> { }
}
