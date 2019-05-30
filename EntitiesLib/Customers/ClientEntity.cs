using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Client)]
    public class ClientEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType       = typeof(ClientModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields  = new List<string> { "Id", "ShortName", "LongName", "ClientTypeId" }
            , UniqueKeyFields = new List<string> { "ShortName" }
            , ForeignKeys     = new Dictionary<string, System.Tuple<string, string>> {
                ["ClientTypeId"] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.ClientType).MetaData.Source,"Id"),
                ["CountryId"]    = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Country).MetaData.Source, "Id"),
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50
                , ["ShortName"     ] = 50
                , ["LongName"      ] = 150
                , ["Email"         ] = 100
                , ["FaxNumber"     ] = 20
                , ["BillingAddress"] = 255
                , ["PhoneNumber"   ] = 20
                , ["Website"       ] = 100
                , ["NameArabic"    ] = 150
            }
            , Source           = "CustomersClient"            
        };
    }
}