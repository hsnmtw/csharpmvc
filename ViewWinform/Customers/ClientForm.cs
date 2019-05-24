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
    public partial class ClientForm : SingleForm {

        public IDBController Controller;
        private ClientModel model;

        public ClientModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtShortName.Select();
                this.txtShortName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public ClientForm() {
            InitializeComponent(); if (DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.Client);
            model = new ClientModel();
            FormsHelper.BindViewToModel(this, ref this.model);
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
            
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtShortName.Text = selected;
            this.Model = (ClientModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
