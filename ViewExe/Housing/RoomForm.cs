using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Housing.Rooms {
    //[ForModel(Common.MODELS.Room)]
    public partial class RoomForm: RoomView {


        

        public RoomForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;
            base.Controller = (RoomController)DBControllersFactory.GetController(Common.MODELS.Room);
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
            Mapper["CountryCode"] = txtCountryCode;
            Mapper["BedCapacity"] = txtBedCapacity;
            Mapper["BuildingName"] = txtBuildingName;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new RoomModel() { RoomName = selected }, "RoomName");
        }

        private void Button1Click(object sender, EventArgs e) {
            Reporting.ReportTemplate report = new Reporting.ReportTemplate(this.printDocument1);
            report.Header = "MY COMPANY";
            report.Footer = "COME BACK AGAIN !!! Thank you";
            report.Body = new List<string>();
            for (int i =0; i < 200; i++) {
                report.Body.Add($"Item {i}     Price 0.00 SAR");
            }
            this.printPreviewDialog1.ShowDialog();
        }

        private void RoomFormLoad(object sender, EventArgs e) {

        }
    }
    public class RoomView : BaseView<RoomModel, RoomController> { }
}
