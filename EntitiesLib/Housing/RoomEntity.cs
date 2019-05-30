using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Room)]
    public class RoomEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(RoomModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "RoomName", "BuildingName", "BedCapacity" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["RoomName"] = 50
                ,["BuildingName"] = 50
                ,["CountryCode"] = 50
            }
            , Source = "HousingRoom"
            , UniqueKeyFields = new string[] { "RoomName" }
        };
    }
}
