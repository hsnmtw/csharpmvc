using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Billing {

    //[ForModel(Common.MODELS.Contract)]
    public partial class ContractForm : ContractView {


        //private Dictionary<int, BillingCategoryModel> billingCategories;
        private List<ServiceModel> Services;

        public ContractForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;

            base.Controller = (ContractController)DBControllersFactory.GetController(Common.MODELS.Contract);
            Controllers = new Dictionary<string, IDBController> {
                ["client"] = DBControllersFactory.GetController(MODELS.Client),
                ["category"] = DBControllersFactory.GetController(MODELS.BillingCategory),
                ["service"] = DBControllersFactory.GetController(MODELS.Service),
                ["currency"] = DBControllersFactory.GetController(MODELS.Currency),
            };
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ContractCode"] = txtContractCode;
            Mapper["StartDate"] = txtStartDate;
            Mapper["EndDate"] = txtEndDate;
            Mapper["ClientId"] = txtClientId;
            Mapper["IsActive"] = chkIsActive;
            Mapper["Conditions"] = txtConditions;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;

            Services = new List<ServiceModel>();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false;


            ModelChanged = delegate () {
                Console.WriteLine("-==================== model changed");
            };
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;

            Model = Controller.Find(new ContractModel() { ContractCode = selected }, "ContractCode");
        }

        private void ContractFormLoad(object sender, EventArgs e) {
            BillingCategoryColumn.DataSource = Controllers["category"].Read<BillingCategoryModel>();
            BillingCategoryColumn.DisplayMember = "BillingCategoryCode";
            BillingCategoryColumn.ValueMember = "Id";

            CurrencyColumn.DataSource = Controllers["currency"].Read<CurrencyModel>();
            CurrencyColumn.DisplayMember = "CurrencyCode";
            CurrencyColumn.ValueMember = "Id";
        }

        private void TxtClient_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtClientId.Text,out int selected);
            txtClientShortName.Text = Controllers["client"].Find(new ClientModel() { Id = selected }, "Id")?.ShortName;
        }

        private void TxtId_TextChanged(object sender, EventArgs e) {
            RequeryGrid();
        }

        private void RequeryGrid() { 
            if(int.TryParse(txtId.Text,out int id)) {
                btnAddService.Enabled = id > 0;
                btnEditService.Enabled = id > 0;
                btnDeleteService.Enabled = id > 0;
            }
            if (id > 0) {
                Services = Controllers["service"].Read<ServiceModel>(new ServiceModel() { ContractId = Model.Id }, "ContractId").ToList();
            } else {
                Services = new List<ServiceModel>();
            }
            bindingSource1.DataSource = Services;
            //dataGridView1.DataSource = bindingSource1;
            //bindingSource1.EndEdit();
        }

        private IView OpenService(ServiceModel service) {
            var form = new Form();
            var view = (ServiceForm)DBViewsFactory.GetView(MODELS.Service);
            service.ContractId = Model.Id;
            view.SetModel(service);
            view.Dock = DockStyle.Fill;
            form.Controls.Add(view);
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new System.Drawing.Size(400, 400);
            view.NewButtonEnabled = false;
            view.DeleteButtonEnabled = false;
            view.DisableChangeContract();
            view.AfterNew = delegate () {
                view.SetModel(new ServiceModel() { ContractId = Model.Id });
            };
            form.Show();
            return view;
        }

        private void BtnAddService_Click(object sender, EventArgs e) {
            var view = OpenService(new ServiceModel());
            view.AfterSave += delegate() {
                RequeryGrid();
            };
        }

        private void BtnEditService_Click(object sender, EventArgs e) {
            if (this.dataGridView1.SelectedRows.Count < 1) return;
            var view = OpenService(Services[bindingSource1.Position]);
            view.AfterSave += delegate () {
                RequeryGrid();
            };
        }

        private void BtnDeleteService_Click(object sender, EventArgs e) {
            if (this.dataGridView1.SelectedRows.Count < 1) return;
            Controllers["service"].Delete(Services[bindingSource1.Position]);
            RequeryGrid();
        }

        private void TxtStartDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtStartDate);
        }

        private void TxtEndDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtEndDate);
        }
    }
   
}
