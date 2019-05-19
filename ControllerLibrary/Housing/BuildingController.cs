using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControllerLibrary.Housing {
    [ForControllerAttribute(ControllersEnum.Building, Enabled = true)]
    public class BuildingController : AbstractController {
        public BuildingController() : base(CollectionsFactory.GetCollection(CollectionsEnum.Building)) {

        }
    }
}
