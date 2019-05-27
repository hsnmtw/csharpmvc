using MVCWinform.Common;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Project)]
    public partial class ProjectForm : SingleForm {

        public IDBController Controller;
        private ProjectModel model;

        public ProjectModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtProjectName.Select();
                this.txtProjectName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        public ProjectForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Project);
            model = new ProjectModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }


        private void ProjectTypeFormLoad(object sender, EventArgs e) {

        }

        private void LookUpButtonProjectNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtProjectName.Text = selected;
            this.Model = (ProjectModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);
        }
    }
}
