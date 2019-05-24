using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Housing;
using ControllerLibrary.Common;
using ModelLibrary.Common;

namespace ControllerLibrary.Housing
{
    [ForControllerAttribute(Entities.Compound, Enabled = true)]
    public class CompoundController : AbstractDBController {
        public CompoundController() : base(DBEntitiesFactory.GetEntity(Entities.Compound)) { }
    }
}
