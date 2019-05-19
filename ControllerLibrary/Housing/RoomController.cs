using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Housing {
    public class RoomController : AbstractController {
        public RoomController() : base(CollectionsFactory.GetCollection(CollectionsEnum.Room)) {

        }
    }
}
