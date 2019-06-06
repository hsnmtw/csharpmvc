using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.CurrencyFXRate)]
    public class CurrencyFXRateEntity : AbstractDBEntity<CurrencyFXRateModel> {
        public static readonly string SOURCE = "BillingContract";
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(CurrencyFXRateModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "FromCurrencyId","ToCurrencyId","FXDate","FXRate" }
            , RequiredFields   = new HashSet<string> { "Id", "FromCurrencyId", "ToCurrencyId", "FXDate", "FXRate" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "FromCurrencyId", "ToCurrencyId", "FXDate" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["FromCurrencyId"] = new Tuple<string, string>(ENTITIES.Currency, "Id"),
                ["ToCurrencyId"  ] = new Tuple<string, string>(ENTITIES.Currency, "Id"),
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 10,
                ["UpdatedBy"   ] = 10,
            }
            , Source             = ENTITIES.CurrencyFXRate
        };
    }
}
