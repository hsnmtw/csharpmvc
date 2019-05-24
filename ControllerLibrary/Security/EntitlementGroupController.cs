using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Security;
using ControllerLibrary.Common;
using ModelLibrary.Common;
using System.Windows.Forms;

namespace ControllerLibrary.Security
{
    [ForControllerAttribute(Entities.EntitlementGroup, Enabled = true)]
    public class EntitlementGroupController : AbstractDBController {

        public EntitlementGroupController() : base(DBEntitiesFactory.GetEntity(Entities.EntitlementGroup)) { }

    }
}
