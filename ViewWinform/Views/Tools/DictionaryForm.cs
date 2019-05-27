using MVCWinform.Common;
using System;

namespace MVCWinform.Tools {
    [ForEntity(Entities.Dictionary)]
    public partial class DictionaryForm : SingleForm {

        public IDBController Controller;
        private IDBController dictionaryController;
        private DictionaryModel model;

        public DictionaryForm() : base() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            dictionaryController = DBControllersFactory.GetController(Entities.Dictionary);
            Controller = DBControllersFactory.GetController(Entities.Dictionary);
            model = new DictionaryModel();
            Utils.FormsHelper.BindViewToModel(this, ref this.model);
        }

        public DictionaryModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtWordInEnglish.Focus();
                this.txtWordInEnglish.Select();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        private void DictionaryFormLoad1(object sender, EventArgs e) {

        }

        private void DictionaryNameLookupButtonLookUpSelected(object sender, EventArgs e) {
            this.Model = (DictionaryModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);
        }
    }
}
