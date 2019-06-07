using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.ClientType)]
    public class ClientTypeEntity : AbstractDBEntity<ClientTypeModel> {
        public override MetaData MetaData => new MetaData() {
            ////  ModelType        = typeof(ClientTypeModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn",
                                                      "ClientTypeCode","ClientTypeEnglish","ClientTypeArabic" }
            , RequiredFields   = new HashSet<string> { "Id","ClientTypeCode","ClientTypeEnglish","ClientTypeArabic" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "ClientTypeCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
                ["ClientTypeCode"] = 10,
                ["ClientTypeEnglish"] = 50,
                ["ClientTypeArabic"] = 50,
            }
            , Source = ENTITIES.ClientType
        };
    }
}
