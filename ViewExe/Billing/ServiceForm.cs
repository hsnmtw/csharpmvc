using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCHIS.Common;

namespace MVCHIS.Billing {
    public partial class ServiceForm : ServiceView {
        private ContractController        CntrlCN;
        private BillingCategoryController CntrlCG;
        private CurrencyController        CntrlCU;
        private VATController             CntrlVT;
        public ServiceForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            CntrlCN = DBControllersFactory.Contract();
            CntrlCG = DBControllersFactory.BillingCategory();
            CntrlCU = DBControllersFactory.Currency();
            CntrlVT = DBControllersFactory.VAT();
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["BillingCategoryId"] = txtBillingCategoryId;
            Mapper["ContractId"] = txtContractId;
            Mapper["CurrencyId"] = txtCurrencyId;
            Mapper["Price"] = txtPrice;
            Mapper["Expired"] = chkExpired;
            Mapper["EffectiveFromDate"] = txtEffectiveFromDate;
            Mapper["VATId"] = txtVATId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLContract] = txtContractId;
            PickList[btnPLCurrency] = txtCurrencyId;
            PickList[btnPLService] = txtId;
            PickList[btnPLVAT] = txtVATId;
        }

        public void DisableChangeContract() {
            btnPLContract.Enabled = false;
            txtContractId.Enabled = false;
            txtContractCode.Enabled = false;
        }

        private void TxtContractId_TextChanged(object sender, EventArgs e) {
            txtContractCode.Text = DBControllersFactory.FK(MODELS.Contact, txtContractId.Text);
        }

        private void TxtBillingCategoryId_TextChanged(object sender, EventArgs e) {
            txtBillingCategoryCode.Text = DBControllersFactory.FK(MODELS.BillingCategory, txtBillingCategoryId.Text);
        }

        private void TxtCurrencyId_TextChanged(object sender, EventArgs e) {
            txtCurrencyCode.Text = DBControllersFactory.FK(MODELS.Currency, txtCurrencyId.Text);
        }

        private void ServiceForm_Load(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

        private void TxtEffectiveFromDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtEffectiveFromDate);
        }

        private void TxtId_TextChanged(object sender, EventArgs e) {
        }

        private void PickListButtonContract_LookUpSelected(int obj) {
            txtContractId.Text = obj.ToString();
        }

        private void PickListButtonBillingCategory_LookUpSelected(int obj) {
            txtBillingCategoryId.Text = obj.ToString();
        }

        private void PickListButtonCurrency_LookUpSelected(int obj) {
            txtContractId.Text = obj.ToString();
        }

        private void TxtVATId_TextChanged(object sender, EventArgs e) {
            txtVATCode.Text = DBControllersFactory.FK(MODELS.VAT, txtVATId.Text);
        }

        private void PickListButtonVAT_LookUpSelected(int obj) {
            txtVATId.Text = obj.ToString();
        }

        

    }
}
