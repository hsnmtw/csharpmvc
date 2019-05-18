using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Housing {
    public class RoomCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(RoomModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,Room_Name,Building_Name,Bed_Capacity".Split(',')
            , GetSource = "Housing_Room"
            , GetUniqueKeyFields = new string[] { "Room_Name" }
        };
    }
}
