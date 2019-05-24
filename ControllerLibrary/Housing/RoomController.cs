using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Housing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Housing {
    [ForControllerAttribute(Entities.Room, Enabled = true)]
    public class RoomController : AbstractDBController {
        public RoomController() : base(DBEntitiesFactory.GetEntity(Entities.Room)) { }
    }
}
