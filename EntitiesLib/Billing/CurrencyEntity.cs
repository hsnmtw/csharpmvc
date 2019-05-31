using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Currency)]
    public class CurrencyEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(CurrencyModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "CurrencyCode", "CurrencyEnglish", "CurrencyArabic" }
            , UniqueKeyFields  = new List<string> { "CurrencyCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 50,
                ["UpdatedBy"   ] = 50,
                ["CurrencyCode"] = 3,
                ["CurrencyEnglish"] = 50,
                ["CurrencyArabic"] = 50,
                ["CurrencySymbol"] = 2,
            }
            , Source           = "BillingCurrency"

        };
    }
}
