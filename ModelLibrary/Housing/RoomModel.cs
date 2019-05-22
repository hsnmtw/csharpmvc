using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class RoomModel : BaseModel {
        public string RoomName { get; set; }
        public string BuildingName { get; set; }
        public int BedCapacity { get; set; }
        public string NationalityCode { get; set; }
        public int NumberOfWindows { get; set; }
    }
}
