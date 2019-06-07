using MVCHIS.Common;
using System;

namespace MVCHIS.Tools {
    //[ForModel(Common.MODELS.DateConversion)]
    public partial class DateConversionUC: DateConversionView {


        public DateConversionUC() : base() {
            InitializeComponent(); if (DesignMode||(Site!=null && Site.DesignMode)) return;
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            //data
            Mapper["HijriYear"] = txtHijriYear;
            Mapper["HijriMonth"] = txtHijriMonth;
            Mapper["HijriDay"] = txtHijriDay;
            Mapper["GregorianYear"] = txtGregorianYear;
            Mapper["GregorianDate"] = txtGregorianDate;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;

            AfterSave += delegate (bool status) {
                
            };

            SetDeleteButtonEnabled (false);
            SetNewButtonEnabled (false);
        }
        

        private void DateConversionUCFormLoad1(object sender, EventArgs e) {

        }

        private void DateConversionUCNameLookupButtonLookUpSelected(int id) {
            
        }
    }
    
}
