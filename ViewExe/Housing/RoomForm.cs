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
        }
        public override void LoadForeignKeys(ForeignKeys FK) {
            FK.Put(DBControllersFactory.GetController<CountryModel>());
            FK.Put(DBControllersFactory.GetController<BuildingModel>());
        }

        private void RoomForm_Load(object sender, EventArgs e) { if (DesignMode || (Site != null && Site.DesignMode)) return;
        }


        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            Model = Controller.Find(new RoomModel() { RoomName = txtRoomName.Text }, "RoomName");
        }

        private void TxtBuildingId_TextChanged(object sender, EventArgs e) {
            txtBuildingName.Text = ForeignKeys.Instance[MODELS.Building, txtBuildingId.Text];
        }

        private void TxtCountryId_TextChanged(object sender, EventArgs e) {
            txtCountryCode.Text = ForeignKeys.Instance[MODELS.Country, txtCountryId.Text];
        }


    }
    
}
