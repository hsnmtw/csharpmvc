using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Country)]
    public class CountryEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(CountryModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "CountryCode", "CountryEnglish" }
            , UniqueKeyFields  = new string[] { "CountryCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["CountryCode"]    = 50
                ,["CountryEnglish"] = 100
                ,["CountryArabic"]  = 100
            }
            , Source           = "CustomersCountry"
        };
    }
}
