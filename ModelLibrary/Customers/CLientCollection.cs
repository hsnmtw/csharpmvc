using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class ClientCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ClientModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,Short_Name,Long_Name".Split(',')
            , GetSource           = "Customers_Client"
            , GetUniqueKeyFields  = new string[] { "Short_Name" }
        };
    }
}
