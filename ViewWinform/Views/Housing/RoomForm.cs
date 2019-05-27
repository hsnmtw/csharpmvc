using MVCWinform.Common;
using System;
using System.Collections.Generic;

namespace MVCWinform.Housing.Rooms {
    [ForEntity(Entities.Room)]
    public partial class RoomForm : SingleForm {


        public IDBController Controller;
        private RoomModel model;

        public RoomModel Model {
            get {
                model = MVCWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                MVCWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtRoomName.Select();
                this.txtRoomName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        public RoomForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = DBControllersFactory.GetController(Entities.Room);
            model = new RoomModel();
            Utils.FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtRoomName.Text = selected;
            this.Model = (RoomModel)this.Controller.Find(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields);

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
}
