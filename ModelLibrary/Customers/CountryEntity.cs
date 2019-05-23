using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class CountryEntity : AbstractEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(CountryModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,CountryCode,CountryEnglish".Split(',')
            , GetSource           = "CustomersCountry"
            , GetUniqueKeyFields  = new string[] { "CountryCode" }
        };
    }
}
