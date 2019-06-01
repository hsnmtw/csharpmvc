
using MVCHIS.Common;
using System;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Audit, Enabled = true)]
    public class AuditController : AbstractDBController<AuditModel> {

        public override bool Validate(AuditModel model) {
            return base.Validate(model);
        }

        public void RegisterEvent(AuditModel model) {
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
