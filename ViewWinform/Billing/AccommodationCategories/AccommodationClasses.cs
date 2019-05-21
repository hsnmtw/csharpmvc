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

namespace ViewWinform.Billing.AccomodationClasses {
    public partial class AccomodationClassForm : SingleForm {

        //private BaseController bldgCntrlr = ControllersFactory.GetController(Entities.Client);
        private BaseController controller = ControllersFactory.GetController(Entities.AccomClass);
        private AccomClassModel _model = new AccomClassModel();

        public AccomClassModel Model {
            get {
                _model.Id = int.Parse($"0{this.txtId.Text}");
                _model.Accom_Class = this.txtAccomodationClass.Text;
                _model.Created_By = this.txtCreatedBy.Text;
                _model.Updated_By = this.txtUpdatedBy.Text;
                try {
                    _model.Created_On = DateTime.Parse(this.txtCreatedOn.Text);
                    _model.Updated_On = DateTime.Parse(this.txtUpdatedOn.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                this.txtAccomodationClass.Text = _model.Accom_Class;
                this.txtId.Text = _model.Id.ToString();
                this.txtCreatedBy.Text = _model.Created_By;
                this.txtUpdatedBy.Text = _model.Updated_By;
                this.txtCreatedOn.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.txtUpdatedOn.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();
                
                this.txtAccomodationClass.Select();
                this.txtAccomodationClass.Focus();
            }
        }

        public AccomodationClassForm() {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = new AccomClassModel();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = (AccomClassModel)controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields ).First();
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new AccomClassModel();
        }

        private void LookUpButton1_LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtAccomodationClass.Text = selected;
            this.Model = (AccomClassModel)this.controller.Read(this.Model, this.controller.GetMetaData().GetUniqueKeyFields ).First();

        }

        private void AccomClassForm_Load(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.registerEnterAsTab(this.panel1);
        }
    }
}
