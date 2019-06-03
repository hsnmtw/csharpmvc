using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.EntitlementGroup)]
    public class EntitlementGroupEntity : AbstractDBEntity<EntitlementGroupModel> {

        public override MetaData MetaData => new MetaData() {
            //  ModelType       = typeof(EntitlementGroupModel)
              PrimaryKeyField = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "EntitlementGroupName","Dynamic" }
            , RequiredFields  = new HashSet<string> { "Id","EntitlementGroupName" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "EntitlementGroupName" } }
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"           ] = 10,
                ["UpdatedBy"           ] = 10,
                ["EntitlementGroupName"] = 50
            }
            , Source = "SecurityEntitlementGroup"
            
        };
    }
}
