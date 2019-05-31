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
        public ServiceForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;

            base.Controller = (ServiceController)DBControllersFactory.GetController(MODELS.Service);
            Controllers = new Dictionary<string, IDBController> {
                ["b"] = DBControllersFactory.GetController(MODELS.BillingCategory),
                ["c"] = DBControllersFactory.GetController(MODELS.Contract),
                ["x"] = DBControllersFactory.GetController(MODELS.Currency),
                ["v"] = DBControllersFactory.GetController(MODELS.VAT)
            };
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
            Mapper["VATId"] = lblVATId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        public void DisableChangeContract() {
            lookUpButtonContract.Enabled = false;
            txtContractId.Enabled = false;
            txtContractCode.Enabled = false;
        }

        private void TxtContractId_TextChanged(object sender, EventArgs e) {
            int selected = Convert.ToInt32(txtContractId.Text);
            txtContractCode.Text = Controllers["c"].Find(new ContractModel() { Id = selected }, "Id")?.ContractCode;
        }

        private void TxtBillingCategoryId_TextChanged(object sender, EventArgs e) {
            int selected = Convert.ToInt32(txtBillingCategoryId.Text);
            txtBillingCategoryCode.Text = Controllers["b"].Find(new BillingCategoryModel() { Id = selected }, "Id")?.BillingCategoryCode;
        }

        private void TxtCurrencyId_TextChanged(object sender, EventArgs e) {
            int selected = Convert.ToInt32(txtCurrencyId.Text);
            var currency = Controllers["x"].Find(new CurrencyModel() { Id = selected }, "Id");
            txtCurrencyCode.Text = currency?.CurrencyCode;
            txtCurrencyEnglish.Text = currency?.CurrencyEnglish;
        }

        private void ServiceForm_Load(object sender, EventArgs e) {
            cmbVATId.DataSource = Controllers["v"].Read<VATModel>().OrderBy(x => -x.VATAmount).ToList();
            cmbVATId.DisplayMember = "VATCode";
            cmbVATId.ValueMember = "Id";
            cmbVATId.SelectedIndex = 0;
        }

        private void TxtEffectiveFromDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtEffectiveFromDate);
        }

        private void TxtId_TextChanged(object sender, EventArgs e) {
            cmbVATId.SelectedIndex = 0;
        }

        private void CmbVATId_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbVATId.SelectedValue is VATModel) {
                lblVATId.Text = ((VATModel)cmbVATId.SelectedValue)?.Id.ToString();
            } else {
                lblVATId.Text = cmbVATId.SelectedValue?.ToString();
            }

        }
    }
}
