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

namespace ViewWinform.Billing {
    public partial class AccomodationClassForm : SingleForm {

        public IDBController Controller ;
        private AccomClassModel model;

        public AccomClassModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtAccomodationClass.Select();
                this.txtAccomodationClass.Focus();
            }
        }

        public override void UpdateModel() { var _ = Model; }
   

        public AccomodationClassForm() {
            InitializeComponent(); if (DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.AccomClass);
            model = new AccomClassModel();
            ViewWinform.Utils.FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtAccomodationClass.Text = selected;
            this.Model = (AccomClassModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields ).First();

        }

        private void AccomClassFormLoad(object sender, EventArgs e) {
            
        }
    }
}
