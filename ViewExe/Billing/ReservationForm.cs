using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Billing {

    //[ForModel(Common.MODELS.Reservation)]
    public partial class ReservationForm: ReservationView {

        private BuildingController CntrlBD;
        private CompoundController CntrlCM;
        private RoomController     CntrlRM;
        private ClientController   CntrlCL;
        private CurrencyController CntrlCR;

        public ReservationForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ReservationCode"] = txtReservationCode;
            Mapper["RoomId"    ] = txtRoomId;
            Mapper["ClientId"  ] = txtClientId;
            Mapper["CurrencyId"] = txtCurrencyId;
            Mapper["FromDate"  ] = txtFromDate;
            Mapper["ToDate"    ] = txtToDate;
            Mapper["Rate"      ] = txtRate;
            Mapper["Confirmed" ] = chkConfirmed;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;

            CntrlBD = (BuildingController)DBControllersFactory.GetController<BuildingModel>();
            CntrlRM = (RoomController)DBControllersFactory.GetController<RoomModel>();
            CntrlCL = (ClientController)DBControllersFactory.GetController<ClientModel>();
            CntrlCM = (CompoundController)DBControllersFactory.GetController<CompoundModel>();
            CntrlCR = (CurrencyController)DBControllersFactory.GetController<CurrencyModel>();

            AfterNew += AfterNewButtonClick;
        }

        private void AfterNewButtonClick(bool obj) {
            foreach(var control in Controls.OfType<TextBox>()) {
                control.Text = "";
            }
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new ReservationModel() { ReservationCode = txtReservationCode.Text }, "ReservationCode");
        }

        private void ReservationFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }

        private void TxtRoomId_TextChanged(object sender, EventArgs e) {
            if(int.TryParse(txtRoomId.Text,out int roomid)) {
                RoomModel     room     = CntrlRM.Find(new RoomModel()     { Id = roomid              }, "Id");
                BuildingModel building = CntrlBD.Find(new BuildingModel() { Id = room.BuildingId     }, "Id");
                CompoundModel compound = CntrlCM.Find(new CompoundModel() { Id = building.CompoundId }, "Id");
                txtRoomName.Text     = room?.RoomName;
                txtBuildingName.Text = building?.BuildingName;
                txtCompoundName.Text = compound?.CompoundName;
            }
        }

        private void TxtClientId_TextChanged(object sender, EventArgs e) {
            if(int.TryParse(txtClientId.Text,out int clientid)) {
                ClientModel client   = CntrlCL.Find(new ClientModel() { Id = clientid }, "Id");
                txtClientName.Text = client?.ShortName;
            }
        }

        private void LookUpButtonCurrency_LookUpSelected(object sender, EventArgs e) {
            if (int.TryParse(txtCurrencyId.Text, out int currencyid)) {
                CurrencyModel currency = CntrlCR.Find(new CurrencyModel() { Id = currencyid }, "Id");
                txtCurrencyEnglish.Text = currency?.CurrencyEnglish;
            }
        }

        private void TxtFromDate_Leave(object sender, EventArgs e) {
            if(DateTime.TryParse(txtFromDate.Text,out DateTime fromdate)) {
                txtFromDate.Text = fromdate.ToSortableString();
            }
        }

        private void TxtToDate_Leave(object sender, EventArgs e) {
            if (DateTime.TryParse(txtToDate.Text, out DateTime todate)) {
                txtToDate.Text = todate.ToSortableString();
            }
        }
    }
   
}
