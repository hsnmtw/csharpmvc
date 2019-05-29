using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForEntity(Entities.AccommClass)]
    public class AccommClassEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(AccommClassModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "AccommClassCode", "AccommClassDesc" }
            , GetUniqueKeyFields  = new string[] { "AccommClassCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                   ["AccommClassCode"] = 50,
                   ["AccommClassDesc"] = 100,

            }
            , GetSource           = "BillingAccommClass"

        };
    }
}
