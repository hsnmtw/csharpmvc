using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.AccomClass)]
    public class AccomClassEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(AccomClassModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "AccomClassCode", "AccommClassDesc" }
            , GetUniqueKeyFields  = new string[] { "AccomClassCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                   ["AccomClassCode"] = 50,
                   ["AccomClassDesc"] = 100,

            }
            , GetSource           = "BillingAccommClass"

        };
    }
}
