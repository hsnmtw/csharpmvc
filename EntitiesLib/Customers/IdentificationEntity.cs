using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Identification)]
    public class IdentificationEntity : AbstractDBEntity<IdentificationModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(IdentificationModel)
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "IdNumber","IdTypeId","CityId","IssueDate","ExpiryDate","IsActive" }
            , RequiredFields   = new HashSet<string> { "Id", "IdTypeId", "IdNumber", "CityId" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "IdNumber", "IdTypeId", "CityId" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["CityId" ]    = new Tuple<string, string>(DBEntitiesFactory.GetEntity<CityModel              >().MetaData.Source, "Id"),
                ["IdTypeId"  ] = new Tuple<string, string>(DBEntitiesFactory.GetEntity<IdentificationTypeModel>().MetaData.Source, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"      ] = 10
                ,["UpdatedBy"      ] = 10
                ,["IdNumber"       ] = 15
            }
            , Source           = "CustomersIdentification"
            
        };
    }
}