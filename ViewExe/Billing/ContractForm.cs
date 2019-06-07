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

            CntrlCL = DBControllersFactory.Client();
            CntrlCG = DBControllersFactory.BillingCategory();
            CntrlSR = DBControllersFactory.Service();
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
            //pick lists
            PickList[btnPLClient] = txtClientId;
            PickList[btnPLContract] = txtId;

            Services = new List<ServiceModel>();

            ModelChanged = delegate () {
                Console.WriteLine("-==================== model changed");
                RequeryServicesGrid();
            };
        }


        private void ContractFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            SuspendLayout();
            this.lstServices.Items.Clear();
            this.lstServices.Columns.Clear();
            this.lstServices.LoadData("", new ServiceModel[] { }, SERVICE_COLUMNS) ;
            ResumeLayout();
        }

        private void TxtClient_TextChanged(object sender, EventArgs e) {
            txtClientShortName.Text = DBControllersFactory.FK(MODELS.Client,txtClientId.Text);
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

            this.lstServices.LoadData("", Services, SERVICE_COLUMNS);
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
            view.SetNewButtonEnabled    ( false );
            view.SetDeleteButtonEnabled ( false );
            view.DisableChangeContract();
            view.AfterNew = delegate (bool status) {
                view.SetModel(new ServiceModel() { ContractId = Model.Id });
            };
            form.Show();
            return view;
        }

        private void BtnAddService_Click(object sender, EventArgs e) {
            if (txtId.Text.ToInteger() == 0) return;
            var view = OpenService(new ServiceModel());
            view.AfterSave += delegate(bool status) {
                if (status) {
                    Services.Add(view.Model);
                    lstServices.AddRowFromModel(view.Model);
                    lstServices.Items[Services.Count - 1].Selected = true;
                }
            };
        }

        private void BtnEditService_Click(object sender, EventArgs e) {
            if (lstServices.SelectedIndices.Count < 1) return;
            var view = OpenService(Services[lstServices.SelectedIndices[0]]);
            view.AfterSave += delegate (bool status) {
                //RequeryGrid();
                if (status) {
                    lstServices.Items.RemoveAt(lstServices.SelectedIndices[0]);
                    lstServices.AddRowFromModel(view.Model);
                    lstServices.Items[Services.Count - 1].Selected = true;
                }
            };
        }

        private void BtnDeleteService_Click(object sender, EventArgs e) {
            if (lstServices.SelectedIndices.Count < 1) return;
            if (Controller.DeleteService(lstServices.SelectedValue.ToInteger()) > 0) {
                lstServices.Items.RemoveAt(lstServices.SelectedIndices[0]);
            }
        }

        private void TxtStartDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtStartDate);
        }

        private void TxtEndDate_Leave(object sender, EventArgs e) {
            ValidateDate(txtEndDate);
        }

        

        private void PickListButton1_LookUpSelected(int obj) {
            txtClientId.Text = obj.ToString();
        }
    }
   
}
