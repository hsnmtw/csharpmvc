using MVCWinform.Common;
using MVCWinform.Utils;
using System;
using ViewWinform.Common;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Client)]
    public partial class ClientForm: ClientView {

        //public IDBController Controller;
        
        public ClientForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (ClientController)DBControllersFactory.GetController(Entities.Client);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
            
        }

        private void LookUpButtonShortNameLookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new ClientModel() { ShortName = selected }, "ShortName");
        }
    }
    public class ClientView : BaseView<ClientModel, ClientController> { }
}
