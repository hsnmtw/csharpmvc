using System;
using System.Linq;
using MVCHIS.Common;
using System.Collections.Generic;
using MVCHIS.Housing;
using MVCHIS.Customers;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Reservation)]
    public class ReservationEntity : AbstractDBEntity<ReservationModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "FromDate", "ToDate", "RoomId", "ClientId", "Confirmed", "Rate", "CurrencyId","ReservationCode" }
            , RequiredFields   = new HashSet<string> { "Id", "FromDate", "ToDate", "RoomId", "ClientId" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "ReservationCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
                ["RoomId"]     = new Tuple<MODELS, string>(MODELS.Room, "Id"),
                ["ClientId"]   = new Tuple<MODELS, string>(MODELS.Client, "Id"),
                ["CurrencyId"] = new Tuple<MODELS, string>(MODELS.Currency, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
                ["ReservationCode"] = 10
            }
            , Source           = ENTITIES.Reservation
        };
    }
}
