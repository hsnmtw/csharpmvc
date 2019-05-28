using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;
using System.Reflection;
using System.Windows.Forms;
using ViewWinform.Common;

namespace MVCWinform.Billing {
    [ForEntity(Entities.AccommClass)]
    public partial class AccommClassForm : AccommClassView {

        public AccommClassForm () : base() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;            
            Controller = (AccommClassController)DBControllersFactory.GetController(Entities.AccommClass);
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
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new AccommClassModel() { AccommClassCode = selected }, "AccommClassCode");
        }

        private void AccommClassFormLoad(object sender, EventArgs e) {
            
        }
    }
    public class AccommClassView : BaseView<AccommClassModel, AccommClassController> { }
}
