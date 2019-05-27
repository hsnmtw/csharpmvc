using MVCWinform.Common;
using System;

namespace MVCWinform.Housing.Compounds {
    [ForEntity(Entities.Compound)]
    public partial class CompoundForm : SingleForm {

        public IDBController Controller;
        private CompoundModel model;

        public CompoundForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Compound);
            model = new CompoundModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }

        public CompoundModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);
            }
        }
        public override void UpdateModel() { var _ = Model; }

        private void CompoundFormLoad1(object sender, EventArgs e) {

        }

        private void CompoundNameLookupButtonLookUpSelected(object sender, EventArgs e) {
            this.Model = (CompoundModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);
        }
    }
}
