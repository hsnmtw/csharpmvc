using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.IdentificationType)]
    public class IdentificationTypeEntity : AbstractDBEntity<IdentificationTypeModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "IdentificationTypeCode","IdentificationTypeEnglish","IdentificationTypeArabic" }
            , RequiredFields   = new HashSet<string> { "Id", "IdentificationTypeCode" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "IdentificationTypeCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"    ] = 10
                ,["UpdatedBy"    ] = 10
                ,["IdentificationTypeCode"   ] = 50
                ,["IdentificationTypeEnglish"] = 100
                ,["IdentificationTypeArabic" ] = 100
            }
            , Source = ENTITIES.IdentificationType
        };
    }
}
