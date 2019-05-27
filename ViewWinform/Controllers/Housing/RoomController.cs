using MVCWinform.Common;

namespace MVCWinform.Housing {
    [ForEntityAttribute(Entities.Room, Enabled = true)]
    public class RoomController : AbstractDBController {
        public RoomController() : base(DBEntitiesFactory.GetEntity(Entities.Room)) { }
    }
}
