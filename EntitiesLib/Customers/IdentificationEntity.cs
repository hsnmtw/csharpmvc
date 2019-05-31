using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Identification)]
    public class IdentificationEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(IdentificationModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "IdTypeId", "IdNumber", "CountryId" }
            , UniqueKeyFields  = new List<string> { "IdNumber", "IdTypeId", "CountryId" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
                ["CountryId" ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Country).MetaData.Source, "Id"),
                ["IdTypeId"  ] = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.IdentificationType).MetaData.Source, "Id"),
            }
            , GetSizes = new Dictionary<string, int> {
                 ["CreatedBy"      ] = 50
                ,["UpdatedBy"      ] = 50
                ,["IdNumber"       ] = 15
            }
            , Source           = "CustomersIdentification"
            
        };
    }
}