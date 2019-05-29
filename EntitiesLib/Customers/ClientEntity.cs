﻿using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Client)]
    public class ClientEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ClientModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "ShortName", "LongName", "ClientType" }
            , UniqueKeyFields  = new string[] { "ShortName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                  ["ClientType"    ] = 50
                , ["ShortName"     ] = 50
                , ["LongName"      ] = 150
                , ["Email"         ] = 100
                , ["FaxNumber"     ] = 20
                , ["BillingAddress"] = 255
                , ["PhoneNumber"   ] = 20
                , ["Website"       ] = 100
                , ["NameArabic"    ] = 150
                , ["Nationality"   ] = 50
            }
            , Source           = "CustomersClient"            
        };
    }
}