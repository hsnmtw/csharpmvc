using MVCHIS.Common;
using MVCHIS.Utils;
using System;

namespace MVCHIS.Tools {
    //[ForModel(Common.MODELS.Dictionary)]
    public partial class DictionaryForm: DictionaryView {


        public DictionaryForm() : base() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            //data
            Mapper["WordInArabic"] = txtWordInArabic;
            Mapper["WordInEnglish"] = txtWordInEnglish;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;

            AfterSave += delegate (bool status) {
                this.Controller[Model.WordInEnglish] = Model.WordInArabic;
            };
        }
        

        private void DictionaryFormLoad1(object sender, EventArgs e) {

        }

        private void DictionaryNameLookupButtonLookUpSelected(object sender, EventArgs e) {
            
            Model = Controller.Find(new DictionaryModel() { Id = txtWordInEnglish.Text.ToInteger() }, "Id");
        }
    }
    
}
