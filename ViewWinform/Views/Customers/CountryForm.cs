using MVCWinform.Common;
using System;
using System.Linq;
using System.Windows.Forms;
using ViewWinform.Common;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Country)]
    public partial class CountryForm: CountryView {

        //public IDBController Controller;

        public CountryForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (CountryController)DBControllersFactory.GetController(Entities.Country);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper[Model.CountryCode] = txtCountryCode;
            Mapper[Model.CountryArabic] = txtCountryArabic;
            Mapper[Model.CountryEnglish] = txtCountryEnglish;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void CountryFormLoad(object sender, EventArgs e) {
            Label[] fieldsmarkers = { lblMetaDataCountryArabic,lblMetaDataCountryCode,lblMetaDataCountryEnglish };

            foreach(var required in fieldsmarkers) {
                string field = required.Name.Replace("lblMetaData", "");
                if (this.Controller.GetMetaData().GetRequiredFields.Contains(field)) {
                    required.Text = "*";
                } else {
                    required.Text = "";
                }
            }
        }

        private void CountryCodeTextBoxLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new CountryModel() { CountryCode = selected }, "CountryCode");
        }
    }
    public class CountryView : BaseView<CountryModel, CountryController> { }
}
