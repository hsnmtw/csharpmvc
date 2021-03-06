﻿using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Security {
    //[ForModel(MODELS.Profile)]
    public class ProfileEntity : AbstractDBEntity<ProfileModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField = "Id"
            , Fields          = new HashSet<string> { "ReadOnly","Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "ProfileName", "ProfileDesc" }
            , RequiredFields  = new HashSet<string> { "Id", "ProfileName" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "ProfileName" } }
            , ForeignKeys     = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"  ] = 10,
                ["UpdatedBy"  ] = 10,
                ["ProfileName"] = 50,
                ["ProfileDesc"] = 100,
            }
            , Source = ENTITIES.Profile
            
        };
    }
}
