using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForEntity(Entities.IdentificationType)]
    public class IdentificationTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(IdentificationTypeModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "IdTypeCode" }
            , GetUniqueKeyFields  = new string[] { "IdTypeCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["IdTypeCode"   ] = 50
                ,["IdTypeEnglish"] = 100
                ,["IdTypeArabic" ] = 100
            }
            , GetSource = "CustomersIdentificationType"
        };
    }
}
