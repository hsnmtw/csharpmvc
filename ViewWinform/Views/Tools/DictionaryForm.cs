using MVCWinform.Common;
using System;
using ViewWinform.Common;

namespace MVCWinform.Tools {
    [ForEntity(Entities.Dictionary)]
    public partial class DictionaryForm: DictionaryView {


        public DictionaryForm() : base() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (DictionaryController)DBControllersFactory.GetController(Entities.Dictionary);
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
        }
        

        private void DictionaryFormLoad1(object sender, EventArgs e) {

        }

        private void DictionaryNameLookupButtonLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new DictionaryModel() { WordInEnglish = selected }, "WordInEnglish");
        }
    }
    public class DictionaryView : BaseView<DictionaryModel, DictionaryController> { }
}
