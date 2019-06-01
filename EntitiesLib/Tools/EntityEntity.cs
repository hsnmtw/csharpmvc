﻿using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Entity)]
    public class EntityEntity : AbstractDBEntity<EntityModel> {

        public override MetaData MetaData => new MetaData() {
            //  ModelType       = typeof(EntityModel)
              PrimaryKeyField = "Id" 
            , Fields          = new HashSet<string> { "CreatedBy", "CreatedOn", "Id", "ReadOnly", "UpdatedBy", "UpdatedOn", "EntityName", "EntityDesc" }
            , RequiredFields  = new HashSet<string> { "Id", "EntityName", "EntityDesc" }
            , UniqueKeyFields = new HashSet<string> { "EntityName" }
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"]  = 50,
                ["UpdatedBy"]  = 50,
                ["EntityName"] = 50,
                ["EntityDesc"] = 100
            }
            , Source = "ToolsEntity"
            };
    }
}
