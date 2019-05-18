using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class RoomModel : BaseModel {
        public string Room_Name { get; set; }
        public string Building_Name { get; set; }
        public int Bed_Capacity { get; set; }
        public string Nationality_Code { get; set; }
        public int Number_Of_Windows { get; set; }
    }
}
