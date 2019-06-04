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
        }

        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(DBControllersFactory.GetController<CountryModel>());
            base.LoadForeignKeys(FK);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new CurrencyModel() { CurrencyCode = txtCurrencyCode.Text }, "CurrencyCode");
        }

        private void CurrencyFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }

        private void TxtCountryId_TextChanged(object sender, EventArgs e) {
            txtCountryCode.Text = ForeignKeys.Instance[MODELS.Country, txtCountryId.Text];
        }
    }
   
}
