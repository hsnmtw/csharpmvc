using ControllerLibrary.Common;
using ControllerLibrary.Customers;
using ModelLibrary.Common;
using ModelLibrary.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewWinform.Common;

namespace ViewWinform.Customers.Projects {
    public partial class ProjectForm : SingleForm {

        //private BaseController bldgCntrlr = ControllersFactory.GetController(Entities.Project);
        public BaseController Controller => ControllersFactory.GetController(Entities.Project);
        private ProjectModel model = new ProjectModel();

        public ProjectModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtProjectName.Select();
                this.txtProjectName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        public ProjectForm() {
            InitializeComponent();
        }


        private void ProjectTypeFormLoad(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.BindViewToModel(this.panel1,ref this.model);
        }

        private void LookUpButtonProjectNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtProjectName.Text = selected;
            this.Model = (ProjectModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
