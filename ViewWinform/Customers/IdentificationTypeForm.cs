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
    public partial class IdentificationTypeForm : SingleForm {

        public IDBController Controller;
        private IdentificationTypeModel model;

        public IdentificationTypeModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtIdTypeCode.Select();
                this.txtIdTypeCode.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public IdentificationTypeForm() {
            InitializeComponent(); if (DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.IdentificationType);
            model = new IdentificationTypeModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtIdTypeCode.Text = selected;
            this.Model = (IdentificationTypeModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();

        }

        private void IdentificationTypeFormLoad(object sender, EventArgs e) {
        }
    }
}
