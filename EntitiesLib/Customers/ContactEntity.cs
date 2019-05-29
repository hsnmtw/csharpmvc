using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Contact)]
    public class ContactEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ContactModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "MobileNumber", "FullName" }
            , GetUniqueKeyFields  = new string[] { "MobileNumber" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["MobileNumber"] = 15
                ,["Email"       ] = 100
                ,["FaxNumber"   ] = 15
                ,["PhoneNumber" ] = 15
                ,["FullName"    ] = 100
            }
            , GetSource           = "CustomersContact"            
        };
    }
}