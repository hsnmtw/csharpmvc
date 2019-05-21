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
            , GetRequiredFields   = "Id,Client_Type".Split(',')
            , GetSource           = "Customers_Client_Types"
            , GetUniqueKeyFields  = new string[] { "Client_Type" }
        };
    }
}
