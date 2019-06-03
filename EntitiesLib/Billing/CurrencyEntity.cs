using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Currency)]
    public class CurrencyEntity : AbstractDBEntity<CurrencyModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(CurrencyModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                     "CurrencyCode","CurrencyEnglish","CurrencyArabic","CurrencySymbol" }
            , RequiredFields   = new HashSet<string> { "Id", "CurrencyCode", "CurrencyEnglish", "CurrencyArabic" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "CurrencyCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 10,
                ["UpdatedBy"   ] = 10,
                ["CurrencyCode"] = 3,
                ["CurrencyEnglish"] = 50,
                ["CurrencyArabic"] = 50,
                ["CurrencySymbol"] = 2,
            }
            , Source           = "BillingCurrency"

        };
    }
}
