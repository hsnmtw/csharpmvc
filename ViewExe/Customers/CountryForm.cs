﻿using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MVCHIS.Customers {
    //[ForModel(Common.MODELS.Country)]
    public partial class CountryForm: CountryView {

        

        public CountryForm() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["CountryCode"] = txtCountryCode;
            Mapper["CountryArabic"] = txtCountryArabic;
            Mapper["CountryEnglish"] = txtCountryEnglish;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
            //pick lists
            PickList[btnPLCountry] = txtId;
        }

        private void CountryFormLoad(object sender, EventArgs e) { if (DesignMode||(Site!=null && Site.DesignMode)) return;
        }


        
    }
    
}
