using MVCWinform.Common;

namespace MVCWinform.Housing {
    public class RoomModel : BaseModel {
        public string RoomName { get; set; }
        public string BuildingName { get; set; }
        public int BedCapacity { get; set; }
        public string CountryCode { get; set; }
        public int NumberOfWindows { get; set; }
    }
}
