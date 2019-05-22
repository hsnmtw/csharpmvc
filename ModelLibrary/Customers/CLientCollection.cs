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
            , GetRequiredFields   = "Id,ShortName,LongName,ClientType".Split(',')
            , GetSource           = "CustomersClient"
            , GetUniqueKeyFields  = new string[] { "ShortName" }
        };
    }
}
