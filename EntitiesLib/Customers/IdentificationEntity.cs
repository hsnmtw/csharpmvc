using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Identification)]
    public class IdentificationEntity : AbstractDBEntity<IdentificationModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "IdentificationNumber","IdentificationTypeId","CityId","IssueDate","ExpiryDate","IsActive" }
            , RequiredFields   = new HashSet<string> { "Id", "IdentificationTypeId", "IdentificationNumber", "CityId" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "IdentificationNumber", "IdentificationTypeId", "CityId" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["CityId" ]    = new Tuple<string, string>(ENTITIES.City              , "Id"),
                ["IdentificationTypeId"  ] = new Tuple<string, string>(ENTITIES.IdentificationType, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"      ] = 10
                ,["UpdatedBy"      ] = 10
                ,["IdentificationNumber"       ] = 15
            }
            , Source           = ENTITIES.Identification
};
    }
}