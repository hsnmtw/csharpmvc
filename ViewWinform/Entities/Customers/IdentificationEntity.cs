using MVCWinform.Common;
using System.Collections.Generic;

namespace MVCWinform.Customers {
    [ForEntity(Entities.Identification)]
    public class IdentificationEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(IdentificationModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "IdType", "IdNumber" }
            , GetUniqueKeyFields  = new string[] { "IdNumber" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["IdNumber"       ] = 15
                ,["IdType"         ] = 50
                ,["IssuingCountry" ] = 50
            }
            , GetSource           = "CustomersIdentification"
            
        };
    }
}
/*
IdNumber      
IdType        
IssuingCountry
IssueDate     
ExpiryDate    
IsActive      
*/