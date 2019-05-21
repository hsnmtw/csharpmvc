using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControllerLibrary.Housing {
    [ForControllerAttribute(Entities.BuildingType, Enabled = true)]
    public class BuildingTypeController : AbstractController {
        public BuildingTypeController() : base(CollectionsFactory.GetCollection(Entities.BuildingType)) { }
    }
}
