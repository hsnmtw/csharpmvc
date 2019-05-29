using MVCHIS.Utils;
using System;
using MVCHIS.Common;

namespace MVCHIS.Common {
    [ForModel(Common.MODELS.Entity)]
    public partial class EntityForm: EntityView {

        
        
        public EntityForm() {
            InitializeComponent(); if (DesignMode || (Site != null && Site.DesignMode)) return;;
            base.Controller = (EntityController)DBControllersFactory.GetController(Common.MODELS.Entity);
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
