using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Linq;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Project)]
    public partial class ProjectForm: ProjectView {

        public ProjectForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            base.Controller = (ProjectController)DBControllersFactory.GetController(Common.MODELS.Project);
            Controllers = new System.Collections.Generic.Dictionary<string, IDBController> {
                ["c"] = DBControllersFactory.GetController(MODELS.Client)
            };
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
        }


        private void ProjectTypeFormLoad(object sender, EventArgs e) {

        }

        private void LookUpButtonProjectNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new ProjectModel() { ProjectName = selected }, "ProjectName");
        }

        private void TxtClientId_TextChanged(object sender, EventArgs e) {
            txtClientShortName.Text = Controllers["c"].FindById<ClientModel>(new int[] { int.Parse($"0{txtClientId.Text}") }).FirstOrDefault()?.ShortName;
        }
    }
    public class ProjectView : BaseView<ProjectModel, ProjectController> { }
}
