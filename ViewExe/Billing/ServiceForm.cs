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
                ["x"] = DBControllersFactory.GetController(MODELS.Currency)
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
    }
}
