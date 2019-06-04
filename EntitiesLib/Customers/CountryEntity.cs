using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Country)]
    public class CountryEntity : AbstractDBEntity<CountryModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(CountryModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "CountryCode", "CountryEnglish","CountryArabic" }
            , RequiredFields   = new HashSet<string> { "Id", "CountryCode", "CountryEnglish" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "CountryCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"     ] = 10
                ,["UpdatedBy"     ] = 10
                ,["CountryCode"   ]    = 50
                ,["CountryEnglish"] = 100
                ,["CountryArabic" ]  = 100
            }
            , Source           = ENTITIES.Country
        };
    }
}
