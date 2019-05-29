using MVCHIS.Utils;
using System;
using ViewWinform.Common;

namespace MVCHIS.Common {
    [ForEntity(Entities.Entity)]
    public partial class EntityForm: EntityView {

        
        
        public EntityForm() {
            InitializeComponent(); if(Site != null && Site.DesignMode) return;
            Controller = (EntityController)DBControllersFactory.GetController(Entities.Entity);
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
            string selected = ((LookupEventArgs)e).SelectedValueFromLookup;
            //this.txtEntityName.Text = selected;
            Model = Controller.Find(new EntityModel() { EntityName=selected }, "EntityName");

        }

        private void EntityFormLoad(object sender, EventArgs e) {
        }
    }
    public class EntityView : BaseView<EntityModel, EntityController> { }
}
