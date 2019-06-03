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
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["RoomId"]     = new Tuple<string, string>(DBEntitiesFactory.GetEntity<RoomModel>().MetaData.Source, "Id"),
                ["ClientId"]   = new Tuple<string, string>(DBEntitiesFactory.GetEntity<ClientModel>().MetaData.Source, "Id"),
                ["CurrencyId"] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<CurrencyModel>().MetaData.Source, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
                ["ReservationCode"] = 10
            }
            , Source           = "BillingReservation"

        };
    }
}
