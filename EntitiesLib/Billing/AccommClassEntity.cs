using System;
using System.Linq;
using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.AccommClass)]
    public class AccommClassEntity : AbstractDBEntity<AccommClassModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "AccommClassCode", "AccommClassDesc" }
            , RequiredFields   = new HashSet<string> { "Id", "AccommClassCode", "AccommClassDesc" }
            , UniqueKeyFields  = new HashSet<string> { "AccommClassCode" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 50,
                ["UpdatedBy"] = 50,
                ["AccommClassCode"] = 50,
                ["AccommClassDesc"] = 100,

            }
            , Source           = "BillingAccommClass"

        };
    }
}
