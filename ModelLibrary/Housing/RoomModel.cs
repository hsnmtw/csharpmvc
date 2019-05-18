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

        public override string[] GetFields() => new string[]{
            "Room_Name","Building_Name","Bed_Capacity","Nationality_Code","Number_Of_Windows",
            "Id","Created_By","Created_On","Updated_By","Updated_On" };
        public override string[] GetPrimaryKeyFields() => "Id".Split(',');
        public override string[] GetRequiredFields() => "Id,Room_Name,Building_Name,Bed_Capacity".Split(',');
        public override string GetSource() => "Housing_Room";
        public override string[] GetUniqueKeyFields() => new string[] { "Room_Name" };
    }
}
