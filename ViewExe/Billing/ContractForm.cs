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

        private ClientController          CntrlCL ;
        private BillingCategoryController CntrlCG ;
        private ServiceController         CntrlSR ;
        private CurrencyController        CntrlCU ;
        private VATController             CntrlVT ;

        private List<ServiceModel> Services;

        public ContractForm() {
            InitializeComponent();
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
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;

            Model = Controller.Find(new ContractModel() { ContractCode = selected }, "ContractCode");
        }

        private void ContractFormLoad(object sender, EventArgs e) { if (DesignMode) return;

            Services = new List<ServiceModel>();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false;


            ModelChanged = delegate () {
                Console.WriteLine("-==================== model changed");
            };

            CntrlCL = (ClientController)DBControllersFactory.GetController<ClientModel>();
            CntrlCG = (BillingCategoryController)DBControllersFactory.GetController<BillingCategoryModel>();
            CntrlSR = (ServiceController)DBControllersFactory.GetController<ServiceModel>();
            CntrlCU = (CurrencyController)DBControllersFactory.GetController<CurrencyModel>();
            CntrlVT = (VATController)DBControllersFactory.GetController<VATModel>();

            BillingCategoryColumn.DataSource = CntrlCG.Read().ToList();
            BillingCategoryColumn.DisplayMember = "BillingCategoryCode";
            BillingCategoryColumn.ValueMember = "Id";

            CurrencyColumn.DataSource = CntrlCU.Read().ToList();
            CurrencyColumn.DisplayMember = "CurrencyCode";
            CurrencyColumn.ValueMember = "Id";

            VATColumn.DataSource = CntrlVT.Read().ToList();
            VATColumn.DisplayMember = "VATCode";
            VATColumn.ValueMember = "Id";
        }

        private void TxtClient_TextChanged(object sender, EventArgs e) {
            int.TryParse(txtClientId.Text,out int selected);
            txtClientShortName.Text = CntrlCL.Find(new ClientModel() { Id = selected }, "Id")?.ShortName;
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
                Services = CntrlSR.Read(new ServiceModel() { ContractId = Model.Id }, "ContractId").ToList();
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
            form.Size = new System.Drawing.Size(430, 430);
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
            CntrlSR.Delete(Services[bindingSource1.Position]);
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
