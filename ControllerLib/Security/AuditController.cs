
using MVCHIS.Common;
using System;

namespace MVCHIS.Security {
    [ForEntityAttribute(Entities.Audit, Enabled = true)]
    public class AuditController : AbstractDBController {

        public AuditController() : base(DBEntitiesFactory.GetEntity(Entities.Audit)) { }

        public void registerEvent(AuditModel model) {
            model.UpdatedBy = "SYSTEM";
            model.CreatedBy = "SYSTEM";
            model.EventDate = DateTime.Now;
            model.UpdatedOn = DateTime.Now;
            model.CreatedOn = DateTime.Now;
            model.Id = 0; // this makes the model new
            Save(model);
        }
    }
}
