using MVCWinform.Common;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Customers {
    [ForEntity(Entities.ClientType)]
    public partial class ClientTypeForm : SingleForm {

        public IDBController Controller; 
        private ClientTypeModel model; 

        public ClientTypeModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtClientType.Select();
                this.txtClientType.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public ClientTypeForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.ClientType);
            model = new ClientTypeModel();
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtClientType.Text = selected;
            this.Model = (ClientTypeModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
            FormsHelper.BindViewToModel(this.panel1,ref this.model);
        }
    }
}
