using MVCHIS.Common;
using MVCHIS.Customers;
using System;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Room)]
    public class RoomEntity : AbstractDBEntity<RoomModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(RoomModel)
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "RoomName","BuildingId","BedCapacity","CountryId","NumberOfWindows" }
            , RequiredFields   = new HashSet<string> { "Id", "RoomName", "BuildingId", "BedCapacity" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "RoomName" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["BuildingId"] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<BuildingModel>().MetaData.Source,"Id"),
                ["CountryId" ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<CountryModel>().MetaData.Source, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"   ] = 10
                ,["UpdatedBy"   ] = 10
                ,["RoomName"    ] = 50
            }
            , Source = "HousingRoom"
        };
    }
}
