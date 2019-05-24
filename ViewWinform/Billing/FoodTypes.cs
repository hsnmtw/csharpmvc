﻿using ControllerLibrary.Common;
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
using ViewWinform.Utils;

namespace ViewWinform.Billing {
    public partial class FoodTypeForm : SingleForm {

        public IDBController Controller;
        private FoodTypeModel model;

        public FoodTypeModel Model {
            get {
                model = ViewWinform.Utils.FormsHelper.PopulateModelFromControls(model, this);
                return model;
            }
            set {
                this.model = value;
                ViewWinform.Utils.FormsHelper.PopulateControlsFromModel(model, this);

                this.txtFoodType.Select();
                this.txtFoodType.Focus();
            }
        }
        public override void UpdateModel() { var _ = Model; }
        public FoodTypeForm() {
            InitializeComponent(); if (DesignMode) return;
            
            Controller = DBControllersFactory.GetController(Entities.FoodType);
            model = new FoodTypeModel();
            FormsHelper.BindViewToModel(this.panel1, ref this.model);
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            this.txtFoodType.Text = selected;
            this.Model = (FoodTypeModel)this.Controller.Read(this.Model, this.Controller.GetMetaData().GetUniqueKeyFields ).First();

        }

        private void FoodTypeFormLoad(object sender, EventArgs e) {
            
        }
    }
}