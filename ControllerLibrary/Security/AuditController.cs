
using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Security {
    [ForControllerAttribute(Entities.Audit, Enabled = true)]
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
