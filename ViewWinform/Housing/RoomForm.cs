using ControllerLibrary.Common;
using ControllerLibrary.Housing;
using ModelLibrary.Common;
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
    public partial class RoomForm : SingleForm {

        //private RoomController Controller = new RoomController();

        public BaseController Controller => ControllersFactory.GetController(Entities.Room);
        private RoomModel model = new RoomModel();

        public RoomModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtRoomName.Select();
                this.txtRoomName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }

        public RoomForm() {
            InitializeComponent();
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtRoomName.Text = selected;
            this.Model = (RoomModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();

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
            Utils.FormsHelper.BindViewToModel(this.panel1,ref this.model);
        }
    }
}
