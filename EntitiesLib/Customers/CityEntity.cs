using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.City)]
    public class CityEntity : AbstractDBEntity<CityModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(CityModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "CountryId", "CityEnglish","CityArabic" }
            , RequiredFields   = new HashSet<string> { "Id", "CityArabic", "CityEnglish", "CountryId" }
            , UniqueKeyFields  = new HashSet<string> { "CityEnglish" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["CountryId"]  = new Tuple<string, string> (DBEntitiesFactory.GetEntity<CountryModel>().MetaData.Source,"Id")
            }
            , Sizes = new Dictionary<string, int> {
                 ["CreatedBy"     ] = 50
                ,["UpdatedBy"     ] = 50
                ,["CityEnglish"   ] = 100
                ,["CityArabic"    ] = 100
            }
            , Source           = "CustomersCity"
        };
    }
}
