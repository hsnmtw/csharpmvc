using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Contact)]
    public class ContactEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ContactModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "MobileNumber", "FullName" }
            , UniqueKeyFields  = new List<string> { "MobileNumber" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["MobileNumber"] = 15
                ,["Email"       ] = 100
                ,["FaxNumber"   ] = 15
                ,["PhoneNumber" ] = 15
                ,["FullName"    ] = 100
            }
            , Source           = "CustomersContact"            
        };
    }
}