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
        private BaseController controller = ControllersFactory.GetController(Entities.Project);
        private ProjectModel _model = new ProjectModel();

        public ProjectModel Model {
            get {
                _model.Project_Name      = txtProjectName.Text;
                _model.Client_Short_Name = txtClientShortName.Text;


                 //all models share the same
                _model.Id              = int.Parse($"0{this.txtId.Text}");
                _model.Created_By      = this.txtCreatedBy.Text;
                _model.Updated_By      = this.txtUpdatedBy.Text;
                try {
                    _model.Created_On  = DateTime.Parse(this.txtCreatedOn.Text);
                    _model.Updated_On  = DateTime.Parse(this.txtUpdatedOn.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                
                txtProjectName.Text     = _model.Project_Name  ;
                txtClientShortName.Text = _model.Client_Short_Name;


                //all models share the same
                this.txtId.Text = _model.Id.ToString();
                this.txtCreatedBy.Text = _model.Created_By;
                this.txtUpdatedBy.Text = _model.Updated_By;
                this.txtCreatedOn.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.txtUpdatedOn.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();
                this.lstContracts.Items.Clear();
                //this.listBox1.Items.AddRange((from ProjectModel building in bldgCntrlr.Read(new ProjectModel() { Project_Type = _model.Project_Type },new string[] { "Project_Type" }) select building.Project_Type).ToArray());

                this.txtProjectName.Select();
                this.txtProjectName.Focus();
            }
        }

        public ProjectForm() {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = new ProjectModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = (ProjectModel)controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields).First();
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new ProjectModel();
        }

        private void ProjectTypeForm_Load(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.registerEnterAsTab(this.panel1);
        }

        private void LookUpButtonProjectName_LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtProjectName.Text = selected;
            this.Model = (ProjectModel)this.controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
