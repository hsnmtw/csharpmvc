using MVCHIS.Common;

namespace MVCHIS.Housing {
    public class RoomModel : BaseModel {
        public string RoomName { get; set; }
        public int BuildingId { get; set; }
        public int BedCapacity { get; set; }
        public int CountryId { get; set; }
        public int NumberOfWindows { get; set; }
    }
}
