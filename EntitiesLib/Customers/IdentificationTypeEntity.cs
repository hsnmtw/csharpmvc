using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.IdentificationType)]
    public class IdentificationTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(IdentificationTypeModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "IdTypeCode" }
            , UniqueKeyFields  = new string[] { "IdTypeCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["IdTypeCode"   ] = 50
                ,["IdTypeEnglish"] = 100
                ,["IdTypeArabic" ] = 100
            }
            , Source = "CustomersIdentificationType"
        };
    }
}
