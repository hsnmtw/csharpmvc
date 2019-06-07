using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Billing {

    //[ForModel(Common.MODELS.Currency)]
    public partial class CurrencyForm: CurrencyView {

        public CurrencyForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["CurrencyCode"] = txtCurrencyCode;
            Mapper["CurrencyEnglish"] = txtCurrencyEnglish;
            Mapper["CurrencyArabic"] = txtCurrencyArabic;
            Mapper["CurrencySymbol"] = txtCurrencySymbol;
            Mapper["CountryId"] = txtCountryId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLCountry] = txtCountryId;
            PickList[btnPLCurrency] = txtId;
        }


        private void CurrencyFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }

        private void TxtCountryId_TextChanged(object sender, EventArgs e) {
            txtCountryCode.Text = DBControllersFactory.FK(MODELS.Country, txtCountryId.Text);
        }

        
    }
   
}
