﻿using MVCHIS.Utils;
using System;
using MVCHIS.Common;
using MVCHIS.Tools;

namespace MVCHIS.Common {
    //[ForModel(Common.MODELS.Entity)]
    public partial class EntityForm: EntityView {
        
        public EntityForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["EntityName"] = txtEntityName;
            Mapper["EntityDesc"] = txtEntityDesc;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            
            //this.txtEntityName.Text = selected;
            Model = Controller.Find(new EntityModel() { Id = txtEntityName.Text.ToInteger() }, "Id");

        }

        private void EntityFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }
    }
    
}
