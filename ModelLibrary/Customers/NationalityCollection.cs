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
            , GetRequiredFields   = "Id,Nationality_Code,Nationality_Desc".Split(',')
            , GetSource           = "Customers_Nationalities"
            , GetUniqueKeyFields  = new string[] { "Nationality_Code" }
        };
    }
}
