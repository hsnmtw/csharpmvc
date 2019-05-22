using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class NationalityCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(NationalityModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,NationalityCode,NationalityDesc".Split(',')
            , GetSource           = "CustomersNationalities"
            , GetUniqueKeyFields  = new string[] { "NationalityCode" }
        };
    }
}
