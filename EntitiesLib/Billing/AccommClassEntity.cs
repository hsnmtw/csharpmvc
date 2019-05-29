using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    [ForModel(MODELS.AccommClass)]
    public class AccommClassEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(AccommClassModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "AccommClassCode", "AccommClassDesc" }
            , UniqueKeyFields  = new string[] { "AccommClassCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                   ["AccommClassCode"] = 50,
                   ["AccommClassDesc"] = 100,

            }
            , Source           = "BillingAccommClass"

        };
    }
}
