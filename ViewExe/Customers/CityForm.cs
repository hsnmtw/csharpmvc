using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.City)]
    public partial class CityForm: CityView {

        
        public CityForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["CountryId"] = txtCountryId;
            Mapper["CityArabic"] = txtCityArabic;
            Mapper["CityEnglish"] = txtCityEnglish;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(DBControllersFactory.GetController<CountryModel>());
        }

        private void CityFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            
        }

        private void CityCodeTextBoxLookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new CityModel() { Id = txtCityEnglish.Text.ToInteger() }, "Id");
        }

        private void TxtCountryId_TextChanged(object sender, EventArgs e) {
            txtCountryCode.Text = ForeignKeys.Instance[MODELS.Country, txtCountryId.Text];
        }
    }
    
}
