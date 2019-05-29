﻿using MVCHIS.Common;
using System;
using ViewWinform.Common;

namespace MVCHIS.Housing {
    [ForEntity(Entities.Compound)]
    public partial class CompoundForm: CompoundView {

        

        public CompoundForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (CompoundController)DBControllersFactory.GetController(Entities.Compound);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["CompoundName"] = txtCompoundName;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }
        

        private void CompoundFormLoad1(object sender, EventArgs e) {

        }

        private void CompoundNameLookupButtonLookUpSelected(object sender, EventArgs e) {
            var selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new CompoundModel() { CompoundName = selected }, "CompoundName");
        }
    }
    public class CompoundView : BaseView<CompoundModel, CompoundController> { }
}