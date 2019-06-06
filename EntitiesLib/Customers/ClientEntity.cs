using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Client)]
    public class ClientEntity : AbstractDBEntity<ClientModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType       = typeof(ClientModel)
              PrimaryKeyField = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                  "ClientTypeId","ShortName","LongName","NameArabic",
                                                  "DateOfBirth","IsActive","BillingAddress","PhoneNumber",
                                                  "FaxNumber","Website","CountryId" }
            , RequiredFields  = new HashSet<string> { "Id", "ShortName", "LongName", "ClientTypeId" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "ShortName" } }
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
                ["ClientTypeId"] = new Tuple<string, string>(ENTITIES.ClientType,"Id"),
                ["CountryId"]    = new Tuple<string, string>(ENTITIES.Country, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                  ["CreatedBy"     ] = 10
                , ["UpdatedBy"     ] = 10
                , ["ShortName"     ] = 50
                , ["LongName"      ] = 150
                , ["Email"         ] = 100
                , ["FaxNumber"     ] = 20
                , ["BillingAddress"] = 255
                , ["PhoneNumber"   ] = 20
                , ["Website"       ] = 100
                , ["NameArabic"    ] = 150
            }
            , Source                 = ENTITIES.Client           
        };
    }
}