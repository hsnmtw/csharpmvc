﻿using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Utils;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Billing {
    //[ForModel(Common.MODELS.AccommClass)]
    public partial class AccommClassForm : AccommClassView {

        public AccommClassForm () : base() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["AccommClassCode"] = txtAccommClassCode;
            Mapper["AccommClassDesc"] = txtAccommClassDesc;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLAccommClass] = txtId;
        }

        private void AccommClassFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }

    }    
}
