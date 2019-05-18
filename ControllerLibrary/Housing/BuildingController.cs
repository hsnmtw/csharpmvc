using ControllerLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControllerLibrary.Housing {
    public class BuildingController : AbstractController {
        public BuildingController() : base(new BuildingCollection()) {

        }
    }
}
