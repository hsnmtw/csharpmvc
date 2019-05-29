using MVCHIS.Common;
using MVCHIS.Utils;
using System;
using ViewWinform.Common;

namespace MVCHIS.Customers {
    [ForEntity(Entities.ClientType)]
    public partial class ClientTypeForm: ClientTypeView {

         
        
        public ClientTypeForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (ClientTypeController)DBControllersFactory.GetController(Entities.ClientType);
            //template
            Mapper["Id"] = txtId;
            Mapper["CreatedBy"] = txtCreatedBy;
            Mapper["CreatedOn"] = txtCreatedOn;
            Mapper["UpdatedBy"] = txtUpdatedBy;
            Mapper["UpdatedOn"] = txtUpdatedOn;
            Mapper["ReadOnly"] = chkReadOnly;
            //data
            Mapper["ClientType"] = txtClientType;
            //actions
            SaveButton = btnSave;
            DeleteButton = btnDelete;
            NewButton = btnNew;
        }

        private void LookUpButton1LookUpSelected(object sender, EventArgs e) {
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            Model = Controller.Find(new ClientTypeModel() { ClientType=selected }, "ClientType");

        }

        private void ClientTypeFormLoad(object sender, EventArgs e) {
        }
    }
    public class ClientTypeView : BaseView<ClientTypeModel, ClientTypeController> { }
}
