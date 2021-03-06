﻿using System;
using System.Linq;
using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Billing {
    //[ForModel(MODELS.AccommClass)]
    public class AccommClassEntity : AbstractDBEntity<AccommClassModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> {"ReadOnly","Id","CreatedBy","CreatedOn","UpdatedBy","UpdatedOn",
                                                      "AccommClassCode", "AccommClassDesc" }
            , RequiredFields   = new HashSet<string> { "Id", "AccommClassCode", "AccommClassDesc" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "AccommClassCode" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"] = 10,
                ["UpdatedBy"] = 10,
                ["AccommClassCode"] = 50,
                ["AccommClassDesc"] = 100,

            }
            , Source           = ENTITIES.AccommClass

        };
    }
}
