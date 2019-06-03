using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;

namespace MVCHIS.Billing {

    //[ForModel(Common.MODELS.CurrencyFXRate)]
    public partial class CurrencyFXRateForm: CurrencyFXRateView {

        private CurrencyController CntrlCR;

        public CurrencyFXRateForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["FromCurrencyId"] = txtFromCurrencyId;
            Mapper["ToCurrencyId"  ] = txtToCurrencyId;
            Mapper["FXDate"        ] = txtFXDate;
            Mapper["FXRate"        ] = txtRate;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;

            CntrlCR = (CurrencyController)DBControllersFactory.GetController<CurrencyModel>();

            AfterNew += AfterNewButtonClick;
        }

        private void AfterNewButtonClick(bool obj) {
            foreach(var control in Controls.OfType<TextBox>()) {
                control.Text = "";
            }
        }

        private void CurrencyFXRateFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            new Thread(LoadFKs).Start();
        }

        private void LoadFKs() {
            if (!new string[] { "CurrencyId", "FromCurrencyId", "ToCurrencyId" }.All(x => ListViewControl.FK.ContainsKey(x))) {
                ListViewControl.FK["CurrencyId"] = CntrlCR.Read().ToDictionary(x => x.Id, x => x.CurrencyCode);
                ListViewControl.FK["FromCurrencyId"] = ListViewControl.FK["CurrencyId"];
                ListViewControl.FK["ToCurrencyId"] = ListViewControl.FK["CurrencyId"];
            }
        }

        private void TxtFromDate_Leave(object sender, EventArgs e) {
            if(DateTime.TryParse(txtFXDate.Text,out DateTime fromdate)) {
                txtFXDate.Text = fromdate.ToSortableString();
            }
        }

        private void LookUpButtonRecordId_LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new CurrencyFXRateModel() { Id = int.Parse($"0{txtId.Text}") }, "Id");
        }

        private void TxtFromCurrencyId_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(txtFromCurrencyId.Text, out int currencyid)) {
                CurrencyModel currency = CntrlCR.Find(new CurrencyModel() { Id = currencyid }, "Id");
                txtFromCurrencyEnglish.Text = currency?.CurrencyEnglish;
            }
        }

        private void TxtToCurrencyId_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(txtToCurrencyId.Text, out int currencyid)) {
                CurrencyModel currency = CntrlCR.Find(new CurrencyModel() { Id = currencyid }, "Id");
                txtToCurrencyEnglish.Text = currency?.CurrencyEnglish;
            }
        }
    }
   
}
