using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.IdentificationType)]
    public class IdentificationTypeEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(IdentificationTypeModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "IdTypeCode" }
            , UniqueKeyFields  = new List<string> { "IdTypeCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["IdTypeCode"   ] = 50
                ,["IdTypeEnglish"] = 100
                ,["IdTypeArabic" ] = 100
            }
            , Source = "CustomersIdentificationType"
        };
    }
}
