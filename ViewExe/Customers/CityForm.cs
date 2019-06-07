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
            //pick lists
            PickList[btnPLCity] = txtId;
            PickList[btnPLCountry] = txtCountryId;
        }

        private void CityFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            
        }

        private void TxtCountryId_TextChanged(object sender, EventArgs e) {
            txtCountryCode.Text = DBControllersFactory.FK(MODELS.Country, txtCountryId.Text);
        }
    }
    
}
