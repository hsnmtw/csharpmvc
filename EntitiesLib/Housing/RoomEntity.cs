using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    [ForEntity(Entities.Room)]
    public class RoomEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(RoomModel)
            , GetPrimaryKeyFields = new string[]{ "Id" }
            , GetRequiredFields   = new string[] { "Id", "RoomName", "BuildingName", "BedCapacity" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["RoomName"] = 50
                ,["BuildingName"] = 50
                ,["CountryCode"] = 50
            }
            , GetSource = "HousingRoom"
            , GetUniqueKeyFields = new string[] { "RoomName" }
        };
    }
}
