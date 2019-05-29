
using MVCHIS.Common;
using System;

namespace MVCHIS.Security {
    [ForModel(MODELS.Audit, Enabled = true)]
    public class AuditController : AbstractDBController {

        public AuditController() : base(DBEntitiesFactory.GetEntity(MODELS.Audit)) { }

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
