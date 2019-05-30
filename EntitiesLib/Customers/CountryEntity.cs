using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Country)]
    public class CountryEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(CountryModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "CountryCode", "CountryEnglish" }
            , UniqueKeyFields  = new List<string> { "CountryCode" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["CountryCode"]    = 50
                ,["CountryEnglish"] = 100
                ,["CountryArabic"]  = 100
            }
            , Source           = "CustomersCountry"
        };
    }
}
