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
using ViewWinform.Utils;

namespace ViewWinform.Customers {
    public partial class IdentificationForm : SingleForm {

        public IDBController Controller;
        private IdentificationModel model;

        public IdentificationModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtIdNumber.Select();
                this.txtIdNumber.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public IdentificationForm() {
            InitializeComponent(); if (DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Identification);
            model = new IdentificationModel();
            FormsHelper.BindViewToModel(this, ref this.model);
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtId.Text = selected;
            this.Model = (IdentificationModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
