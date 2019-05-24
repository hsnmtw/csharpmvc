using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControllerLibrary.Housing {
    [ForControllerAttribute(Entities.Building, Enabled = true)]
    public class BuildingController : AbstractDBController {
        public BuildingController() : base(DBEntitiesFactory.GetEntity(Entities.Building)) { }
    }
}
