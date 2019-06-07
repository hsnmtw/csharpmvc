using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Entity)]
    public class EntityEntity : AbstractDBEntity<EntityModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> { "CreatedBy", "CreatedOn", "Id", "ReadOnly", "UpdatedBy", "UpdatedOn", "EntityName", "EntityDesc" }
            , RequiredFields   = new HashSet<string> { "Id", "EntityName", "EntityDesc" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "EntityName" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy" ] = 10,
                ["UpdatedBy" ] = 10,
                ["EntityName"] = 50,
                ["EntityDesc"] = 100
            }
            , Source = ENTITIES.Entity
            };
    }
}
