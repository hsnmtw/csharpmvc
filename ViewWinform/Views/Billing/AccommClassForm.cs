using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Utils;
using System;
using System.Reflection;
using System.Windows.Forms;
using ViewWinform.Common;

namespace MVCWinform.Billing {
    [ForEntity(Entities.AccomClass)]
    public partial class AccommClassForm : AccomClassView {

        public AccommClassForm () : base() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;            
            Controller = (AccomClassController)DBControllersFactory.GetController(Entities.AccomClass);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["AccomClassCode"] = txtAccommClassCode;
            Mapper["AccomClassDesc"] = txtAccommClassDesc;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new AccomClassModel() {AccomClassCode = selected }, "AccomClass");
        }

        private void AccomClassFormLoad(object sender, EventArgs e) {
            
        }
    }
    public class AccomClassView : BaseView<AccomClassModel, AccomClassController> { }
}
