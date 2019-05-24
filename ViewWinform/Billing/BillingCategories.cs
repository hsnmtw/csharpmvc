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
    public partial class BillingCategoryForm : SingleForm {

        public IDBController Controller;  
        private BillingCategoryModel model; 

        public BillingCategoryModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtBillingCategory.Select();
                this.txtBillingCategory.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public BillingCategoryForm() {
            InitializeComponent(); if (DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.AccomCategory);
            model = new BillingCategoryModel();
            ViewWinform.Utils.FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtBillingCategory.Text = selected;
            this.Model = (BillingCategoryModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields ).First();

        }

        private void AccomCategoryFormLoad(object sender, EventArgs e) {
            
        }
    }
}
