using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Identification)]
    public class IdentificationEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(IdentificationModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "IdType", "IdNumber" }
            , UniqueKeyFields  = new List<string> { "IdNumber", "IdType" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["IdNumber"       ] = 15
                ,["IdType"         ] = 50
                ,["IssuingCountry" ] = 50
            }
            , Source           = "CustomersIdentification"
            
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