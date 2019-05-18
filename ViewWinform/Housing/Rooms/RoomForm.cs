using ControllerLibrary.Common;
using ControllerLibrary.Housing;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewWinform.Common;

namespace ViewWinform.Housing.Rooms {
    public partial class RoomForm : Form {

        //private RoomController controller = new RoomController();

        private BaseController controller = new RoomController();
        private RoomModel _model = new RoomModel();

        public RoomModel Model {
            get {
                _model.Id = int.Parse($"0{this.txtId.Text}");
                _model.Room_Name = this.txtRoomName.Text;
                _model.Building_Name = this.txtBuildingName.Text;

                _model.Nationality_Code = this.txtNationalityCode.Text ;
                _model.Bed_Capacity = int.Parse($"0{this.txtBedCapacity.Text}");
                _model.Number_Of_Windows = int.Parse($"0{this.txtNumberOfWindows.Text}");
                _model.Created_By = this.txtCreatedBy.Text;
                _model.Updated_By = this.txtUpdatedBy.Text;
                try {
                    _model.Created_On = DateTime.Parse(this.txtCreatedOn.Text);
                    _model.Updated_On = DateTime.Parse(this.txtUpdatedOn.Text);
                } catch { }
                return _model;
            }
            set {
                this._model = value;
                this.txtBuildingName.Text = _model.Building_Name;

                this.txtRoomName.Text = _model.Room_Name;
                this.txtBuildingName.Text = _model.Building_Name;

                this.txtNationalityCode.Text = _model.Nationality_Code ;
                this.txtBedCapacity.Text = _model.Bed_Capacity.ToString();

                this.txtNumberOfWindows.Text = _model.Number_Of_Windows.ToString();
                this.txtId.Text = _model.Id.ToString();
                this.txtCreatedBy.Text = _model.Created_By;
                this.txtUpdatedBy.Text = _model.Updated_By;
                this.txtCreatedOn.Text = _model.Created_By == null || "".Equals(_model.Created_By) ? "" : _model.Created_On.ToString();
                this.txtUpdatedOn.Text = _model.Updated_By == null || "".Equals(_model.Updated_By) ? "" : _model.Updated_On.ToString();

            }
        }

        public RoomForm() {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.controller.Save(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = (RoomModel)controller.Read(this.Model, new string[] {
                "Room_Name"
            }).First();
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.controller.Delete(this.Model);
            Utils.FormsHelper.successMessage("SUCCESS");
            this.Model = new RoomModel();
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Model = new RoomModel();
        }

        private void LookUpButton1_OnLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtRoomName.Text = selected;
            this.Model = (RoomModel)this.controller.Read(this.Model, new string[] { "Room_Name" }).First();

        }

        private void Button1_Click(object sender, EventArgs e) {
            Reporting.ReportTemplate report = new Reporting.ReportTemplate(this.printDocument1);
            report.Header = "MY COMPANY";
            report.Footer = "COME BACK AGAIN !!! Thank you";
            report.Body = new List<string>();
            for (int i =0; i < 200; i++) {
                report.Body.Add($"Item {i}     Price 0.00 SAR");
            }
            this.printPreviewDialog1.ShowDialog();
        }
    }
}
