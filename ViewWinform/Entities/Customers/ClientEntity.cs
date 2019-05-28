using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Client)]
    public class ClientEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ClientModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "ShortName", "LongName", "ClientType" }
            , GetUniqueKeyFields  = new string[] { "ShortName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["ClientType"    ] = 50
                ,["ShortName"     ] = 50
                ,["LongName"      ] = 150
                ,["Email"         ] = 100
                ,["FaxNumber"     ] = 20
                ,["BillingAddress"] = 255
                ,["PhoneNumber"   ] = 20
                ,["ContactPerson" ] = 100
            }
            , GetSource           = "CustomersClient"            
        };
    }
}
/*
ClientType
ShortName
LongName
Email
FaxNumber
BillingAddress
PhoneNumber
ContactPerson 
    */