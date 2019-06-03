using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.IdentificationType)]
    public class IdentificationTypeEntity : AbstractDBEntity<IdentificationTypeModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(IdentificationTypeModel)
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "IdTypeCode","IdTypeEnglish","IdTypeArabic" }
            , RequiredFields   = new HashSet<string> { "Id", "IdTypeCode" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "IdTypeCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"    ] = 10
                ,["UpdatedBy"    ] = 10
                ,["IdTypeCode"   ] = 50
                ,["IdTypeEnglish"] = 100
                ,["IdTypeArabic" ] = 100
            }
            , Source = "CustomersIdentificationType"
        };
    }
}
