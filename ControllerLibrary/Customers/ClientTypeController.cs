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
    [ForControllerAttribute(Entities.ClientType, Enabled = true)]
    public class ClientTypeController : AbstractDBController {
        public ClientTypeController() : base(DBEntitiesFactory.GetEntity(Entities.ClientType)) {}
    }
}
