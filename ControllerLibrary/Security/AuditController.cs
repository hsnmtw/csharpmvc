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
    public class AuditController : AbstractController {
       
        public AuditController() : base(new AuditCollection()) {

        }

        public void registerEvent(AuditModel model) {
            model.Updated_By = "SYSTEM";
            model.Created_By = "SYSTEM";
            model.Event_Date = DateTime.Now;
            model.Updated_On = DateTime.Now;
            model.Created_On = DateTime.Now;
            model.Id = 0; // this makes the model new
            Save(model);
        }
    }
}
