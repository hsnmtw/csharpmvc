﻿using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.ClientContact)]
    public class ClientContactEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ClientContactModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "ClientId", "ContactId" }
            , GetUniqueKeyFields  = new string[] { "ClientId", "ContactId" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,}
            , GetSource           = "CustomersClientContact"
        };
    }
}