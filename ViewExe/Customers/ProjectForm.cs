using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using ViewWinform.Common;

namespace MVCHIS.Customers {
    [ForEntity(Entities.Project)]
    public partial class ProjectForm: ProjectView {

        
        

        public ProjectForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (ProjectController)DBControllersFactory.GetController(Entities.Project);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
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
