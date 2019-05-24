using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class IdentificationEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(IdentificationModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,IdType,IdNumber".Split(',')
            , GetSource           = "CustomersIdentification"
            , GetUniqueKeyFields  = new string[] { "IdNumber" }
        };
    }
}
