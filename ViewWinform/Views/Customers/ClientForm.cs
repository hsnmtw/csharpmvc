using MVCWinform.Common;
using MVCWinform.Utils;
using System;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Client)]
    public partial class ClientForm : SingleForm {

        public IDBController Controller;
        private ClientModel model;

        public ClientModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtShortName.Select();
                this.txtShortName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public ClientForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.Client);
            model = new ClientModel();
            FormsHelper.BindViewToModel(this, ref this.model);
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
            
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtShortName.Text = selected;
            this.Model = (ClientModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);
        }
    }
}
