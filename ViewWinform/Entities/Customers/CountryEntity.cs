using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Country)]
    public class CountryEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(CountryModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "CountryCode", "CountryEnglish" }
            , GetUniqueKeyFields  = new string[] { "CountryCode" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["CountryCode"]    = 50
                ,["CountryEnglish"] = 100
                ,["CountryArabic"]  = 100
            }
            , GetSource           = "CustomersCountry"
        };
    }
}
