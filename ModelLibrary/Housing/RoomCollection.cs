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
            , GetRequiredFields = "Id,RoomName,BuildingName,BedCapacity".Split(',')
            , GetSource = "HousingRoom"
            , GetUniqueKeyFields = new string[] { "RoomName" }
        };
    }
}
