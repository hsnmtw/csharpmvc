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
            InitializeComponent();
            CntrlCN = (ContractController)DBControllersFactory.GetController<ContractModel>();
            CntrlCG = (BillingCategoryController)DBControllersFactory.GetController<BillingCategoryModel>();
            CntrlCU = (CurrencyController)DBControllersFactory.GetController<CurrencyModel>();
            CntrlVT = (VATController)DBControllersFactory.GetController<VATModel>();
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
            int.TryParse(txtContractId.Text,out int id);
            txtContractCode.Text = CntrlCN.Find(new ContractModel() { Id = id }, "Id")?.ContractCode;
        }

        private void TxtBillingCategoryId_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtBillingCategoryId.Text, out int id);
            txtBillingCategoryCode.Text = CntrlCG.Find(new BillingCategoryModel() { Id = id }, "Id")?.BillingCategoryCode;
        }

        private void TxtCurrencyId_TextChanged(object sender, EventArgs e) {
            //int selected = Convert.ToInt32(txtCurrencyId.Text);
            int.TryParse(txtCurrencyId.Text, out int id);
            var currency = CntrlCU.Find(new CurrencyModel() { Id = id }, "Id");
            txtCurrencyCode.Text = currency?.CurrencyCode;
            txtCurrencyEnglish.Text = currency?.CurrencyEnglish;
        }

        private void ServiceForm_Load(object sender, EventArgs e) { if (DesignMode) return;
            cmbVATId.DataSource = CntrlVT.Read().OrderBy(x => -x.VATAmount).ToList();
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
