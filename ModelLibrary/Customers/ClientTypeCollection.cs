using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class ClientTypeCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ClientTypeModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,ClientType".Split(',')
            , GetSource           = "CustomersClientTypes"
            , GetUniqueKeyFields  = new string[] { "ClientType" }
        };
    }
}
