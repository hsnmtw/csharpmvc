using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MVCHIS.Housing.Rooms {
    //[ForModel(Common.MODELS.Room)]
    public partial class RoomForm: RoomView {

        public RoomForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["RoomName"] = txtRoomName;
            Mapper["NumberOfWindows"] = txtNumberOfWindows;
            Mapper["CountryId"] = txtCountryId;
            Mapper["BedCapacity"] = txtBedCapacity;
            Mapper["BuildingId"] = txtBuildingId;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLBuilding] = txtBuildingId;
            PickList[btnPLCountry] = txtCountryId;
            PickList[btnPLRoom] = txtId;
        }
        
        private void RoomForm_Load(object sender, EventArgs e) { if (DesignMode || (Site != null && Site.DesignMode)) return;
        }

        private void TxtBuildingId_TextChanged(object sender, EventArgs e) {
            txtBuildingName.Text = DBControllersFactory.FK(MODELS.Building, txtBuildingId.Text);
        }

        private void TxtCountryId_TextChanged(object sender, EventArgs e) {
            txtCountryCode.Text = DBControllersFactory.FK(MODELS.Country, txtCountryId.Text);
        }

        
    }
    
}
