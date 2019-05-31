using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Room)]
    public class RoomEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(RoomModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "RoomName", "BuildingId", "BedCapacity" }
            , UniqueKeyFields  = new List<string> { "RoomName" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
                ["BuildingId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Building).MetaData.Source,"Id"),
                ["CountryId" ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Country ).MetaData.Source, "Id"),
            }
            , GetSizes = new Dictionary<string, int> {
                 ["CreatedBy"   ] = 50
                ,["UpdatedBy"   ] = 50
                ,["RoomName"    ] = 50
            }
            , Source = "HousingRoom"
        };
    }
}
