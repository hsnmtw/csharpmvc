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
            //pick lists
            PickList[btnPLClient] = txtClientId;
            //PickList[btnPLClient]

            AfterNew += AfterNewButtonClick;
        }

        private void AfterNewButtonClick(bool obj) {
            foreach(var control in Controls.OfType<TextBox>()) {
                control.Text = "";
            }
        }

        private void PickListButton1LookUpSelected(int id) {
        }

        private void ReservationFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;

        }

        private void TxtRoomId_TextChanged(object sender, EventArgs e) {
            txtRoomName.Text = DBControllersFactory.FK(MODELS.Room, txtRoomId.Text);
        }

        private void TxtClientId_TextChanged(object sender, EventArgs e) {
            txtClientName.Text = DBControllersFactory.FK(MODELS.Client, txtClientId.Text);
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

        private void TxtCurrencyId_TextChanged(object sender, EventArgs e) {
            txtCurrencyEnglish.Text = DBControllersFactory.FK(MODELS.Currency, txtCurrencyId.Text);
        }

        

        private void PickListButtonRoom_LookUpSelected(int obj) {
            txtRoomId.Text = obj.ToString();
        }

        private void PickListButtonClient_LookUpSelected(int obj) {
            txtClientId.Text = obj.ToString();
        }

        private void PickListButtonCurrency_LookUpSelected(int obj) {
            txtCurrencyId.Text = obj.ToString();
        }
    }
   
}
