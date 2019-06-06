using MVCHIS.Common;
using MVCHIS.Customers;
using System;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.Contract)]
    public class ContractEntity : AbstractDBEntity<ContractModel> {
        public static readonly string SOURCE = "BillingContract";
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(ContractModel)
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                     "ContractCode","StartDate","EndDate","IsActive","Conditions","ClientId" }
            , RequiredFields   = new HashSet<string> { "Id", "ContractCode","ClientId", "StartDate" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "ContractCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["ClientId"] = new Tuple<string, string>(ENTITIES.Client,"Id")
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"   ] = 10,
                ["UpdatedBy"   ] = 10,
                ["ContractCode"] = 20,
                ["Conditions"  ] = 1000,
            }
            , Source           = ENTITIES.Contract

        };
    }
}
