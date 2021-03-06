﻿using MVCHIS.Common;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.BillingCategory)]
    public class BillingCycleEntity : AbstractDBEntity<BillingCycleModel> {
        public override MetaData MetaData => new MetaData() {
            ////  ModelType        = typeof(BillingCycleModel)
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                   "BillingCycleYear", "BillingCycleMonth" }
            , RequiredFields   = new HashSet<string> { "Id", "BillingCycleYear", "BillingCycleMonth" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "BillingCycleYear", "BillingCycleMonth" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
            }
            , Source           = ENTITIES.BillingCycle
        };
    }
}