using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MVCHIS.Housing.Rooms {
    //[ForModel(Common.MODELS.Room)]
    public partial class RoomForm: RoomView {

        private BuildingController CntrlBD;
        private CountryController  CntrlCY;


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
        private void RoomForm_Load(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
            CntrlBD = (BuildingController)DBControllersFactory.GetController<BuildingModel>();
            CntrlCY = (CountryController)DBControllersFactory.GetController<CountryModel>();
            if (ListViewControl.FK.ContainsKey("CountryId") == false) {
                ListViewControl.FK["CountryId"] = CntrlCY.Read().ToDictionary(x=>x.Id,x=>x.CountryCode);
            }

        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new RoomModel() { RoomName = selected }, "RoomName");
        }

        //private void Button1Click(object sender, EventArgs e) {
        //    Reporting.ReportTemplate report = new Reporting.ReportTemplate(this.printDocument1);
        //    report.Header = "MY COMPANY";
        //    report.Footer = "COME BACK AGAIN !!! Thank you";
        //    report.Body = new List<string>();
        //    for (int i =0; i < 200; i++) {
        //        report.Body.Add($"Item {i}     Price 0.00 SAR");
        //    }
        //    this.printPreviewDialog1.ShowDialog();
        //}


        private void TxtBuildingId_TextChanged(object sender, EventArgs e) {
            int selected = Convert.ToInt32(txtBuildingId.Text);
            var building = CntrlBD.Find(new BuildingModel() { Id = selected }, "Id");
            txtBuildingName.Text = building?.BuildingName;
        }

        private void TxtCountryId_TextChanged(object sender, EventArgs e) {
            int selected = Convert.ToInt32(txtCountryId.Text);
            var country = CntrlCY.Find(new CountryModel() { Id = selected }, "Id");
            txtCountryCode.Text = country?.CountryCode;
            txtCountryEnglish.Text = country?.CountryEnglish;
        }


    }
    
}
