using ControllerLibrary.Common;
using ControllerLibrary.Customers;
using ModelLibrary.Common;
using ModelLibrary.Customers;
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

namespace ViewWinform.Customers.Clients {
    public partial class ClientForm : SingleForm {

        //private BaseController bldgCntrlr = ControllersFactory.GetController(Entities.Client);
        public BaseController Controller => ControllersFactory.GetController(Entities.Client);
        private ClientModel model = new ClientModel();

        public ClientModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.lstProjects.Items.Clear();
                this.txtShortName.Select();
                this.txtShortName.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public ClientForm() {
            InitializeComponent();
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
            ViewWinform.Utils.FormsHelper.BindViewToModel(this.panel1,ref this.model);
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtShortName.Text = selected;
            this.Model = (ClientModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields).First();
        }
    }
}
