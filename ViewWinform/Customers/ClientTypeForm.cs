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
    public partial class ClientTypeForm : SingleForm {

        public IDBController Controller; 
        private ClientTypeModel model; 

        public ClientTypeModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtClientType.Select();
                this.txtClientType.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public ClientTypeForm() {
            InitializeComponent(); if (DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.ClientType);
            model = new ClientTypeModel();
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtClientType.Text = selected;
            this.Model = (ClientTypeModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();

        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
            FormsHelper.BindViewToModel(this.panel1,ref this.model);
        }
    }
}
