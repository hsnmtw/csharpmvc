using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Customers {
    [ForControllerAttribute(Entities.Identification, Enabled = true)]
    public class IdentificationController : AbstractDBController {
        public IdentificationController() : base(DBEntitiesFactory.GetEntity(Entities.Identification)) {}
    }
}
