using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Billing {

    //[ForModel(Common.MODELS.VAT)]
    public partial class VATForm: VATView {

        public VATForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["VATCode"] = txtVATCode;
            Mapper["VATDesc"] = txtVATDesc;
            Mapper["VATAmount"] = txtVATAmount;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new VATModel() { Id = txtVATCode.Text.ToInteger() }, "Id");
        }

        private void VATFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }

        private void BtnSave_Click(object sender, EventArgs e) {
            if (double.TryParse(txtVATAmount.Text,out double vat) == false) {
                txtVATAmount.Text = "0.00";
            }
        }
    }
   
}
