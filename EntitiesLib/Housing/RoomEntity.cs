using MVCHIS.Common;
using MVCHIS.Customers;
using System;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Room)]
    public class RoomEntity : AbstractDBEntity<RoomModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "RoomName","BuildingId","BedCapacity","CountryId","NumberOfWindows" }
            , RequiredFields   = new HashSet<string> { "Id", "RoomName", "BuildingId", "BedCapacity" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "RoomName" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
                ["BuildingId"] = new Tuple<MODELS, string>(MODELS.Building,"Id"),
                ["CountryId" ] = new Tuple<MODELS, string>(MODELS.Country, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"   ] = 10
                ,["UpdatedBy"   ] = 10
                ,["RoomName"    ] = 10
            }
            , Source = ENTITIES.Room
        };
    }
}
