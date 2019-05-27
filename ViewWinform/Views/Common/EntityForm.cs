using MVCWinform.Utils;
using System;

namespace MVCWinform.Common {
    [ForEntity(Entities.Entity)]
    public partial class EntityForm : SingleForm {

        public IDBController Controller;
        private EntityModel model;

        public EntityModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtEntityName.Select();
                this.txtEntityName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public EntityForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Entity);
            model = new EntityModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtEntityName.Text = selected;
            this.Model = (EntityModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

        }

        private void EntityFormLoad(object sender, EventArgs e) {
        }
    }
}
