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
    [ForControllerAttribute(Entities.IdentificationType, Enabled = true)]
    public class IdentificationTypeController : AbstractController {
        public IdentificationTypeController() : base(CollectionsFactory.GetCollection(Entities.IdentificationType)) {}
    }
}
