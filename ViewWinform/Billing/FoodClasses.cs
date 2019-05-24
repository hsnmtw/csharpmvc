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
    public partial class FoodClassForm : SingleForm {

        public IDBController Controller;
        private FoodClassModel model;   

        public FoodClassModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtFoodClass.Select();
                this.txtFoodClass.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public FoodClassForm() {
            InitializeComponent(); if (DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.FoodClass);
            model = new FoodClassModel();
            ViewWinform.Utils.FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtFoodClass.Text = selected;
            this.Model = (FoodClassModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields ).First();

        }

        private void FoodClassFormLoad(object sender, EventArgs e) {
           
        }
    }
}
