using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace MVCHIS.Billing {

    //[ForModel(Common.MODELS.Contract)]
    public partial class ContractForm : ContractView {

        public readonly string[] SERVICE_COLUMNS = { "BillingCategoryId", "EffectiveFromDate", "Expired", "CurrencyId", "VATId", "Price" };

        private ClientController          CntrlCL ;
        private BillingCategoryController CntrlCG ;
        private ServiceController         CntrlSR ;
        private CurrencyController        CntrlCU ;
        private VATController             CntrlVT ;

        private List<ServiceModel> Services;

        public ContractForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;

            CntrlCL = (ClientController)DBControllersFactory.GetController<ClientModel>();
            CntrlCG = (BillingCategoryController)DBControllersFactory.GetController<BillingCategoryModel>();
            CntrlSR = (ServiceController)DBControllersFactory.GetController<ServiceModel>();
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

            ModelChanged = delegate () {
                Console.WriteLine("-==================== model changed");
                RequeryServicesGrid();
            };
        }


        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(CntrlCU);
            FK.Put(CntrlVT);
            FK.Put(CntrlCG);
            FK.Put(CntrlCL);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new ContractModel() { Id = txtContractCode.Text.ToInteger() }, "Id");
        }

        private void ContractFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            SuspendLayout();
            this.listViewControl1.Items.Clear();
            this.listViewControl1.Columns.Clear();
            this.listViewControl1.LoadData("", new ServiceModel[] { }, SERVICE_COLUMNS) ;
            ResumeLayout();
        }

        private void TxtClient_TextChanged(object sender, EventArgs e) {
            txtClientShortName.Text = ForeignKeys.Instance[MODELS.Client,txtClientId.Text];
        }

        private void TxtId_TextChanged(object sender, EventArgs e) {
            RequeryServicesGrid();
        }

        private void RequeryServicesGrid() { 
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

            this.listViewControl1.LoadData("", Services, SERVICE_COLUMNS);
        }

        private ServiceView OpenService(ServiceModel service) {
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
            view.AfterNew = delegate (bool status) {
                view.SetModel(new ServiceModel() { ContractId = Model.Id });
            };
            form.Show();
            return view;
        }

        private void BtnAddService_Click(object sender, EventArgs e) {
            var view = OpenService(new ServiceModel());
            view.AfterSave += delegate(bool status) {
                if (status) {
                    Services.Add(view.Model);
                    listViewControl1.AddRowFromModel(view.Model);
                    listViewControl1.Items[Services.Count - 1].Selected = true;
                }
            };
        }

        private void BtnEditService_Click(object sender, EventArgs e) {
            if (listViewControl1.SelectedIndices.Count < 1) return;
            var view = OpenService(Services[listViewControl1.SelectedIndices[0]]);
            view.AfterSave += delegate (bool status) {
                //RequeryGrid();
                if (status) {
                    listViewControl1.Items.RemoveAt(listViewControl1.SelectedIndices[0]);
                    listViewControl1.AddRowFromModel(view.Model);
                    listViewControl1.Items[Services.Count - 1].Selected = true;
                }
            };
        }

        private void BtnDeleteService_Click(object sender, EventArgs e) {
            if (listViewControl1.SelectedIndices.Count < 1) return;
            CntrlSR.Delete(Services[listViewControl1.SelectedIndices[0]]);
            listViewControl1.Items.RemoveAt(listViewControl1.SelectedIndices[0]);
        }

        private void TxtStartDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtStartDate);
        }

        private void TxtEndDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtEndDate);
        }
    }
   
}
