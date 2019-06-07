using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Project)]
    public class ProjectEntity : AbstractDBEntity<ProjectModel> {
        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "ProjectName", "ClientId" }
            , RequiredFields   = new HashSet<string> { "Id", "ProjectName", "ClientId" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "ProjectName" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
                ["ClientId"]   = new Tuple<MODELS, string>(MODELS.Client,"Id")
            }
            , Sizes = new Dictionary<string, int> {
                  ["CreatedBy"  ] = 10
                , ["UpdatedBy"  ] = 10
                , ["ProjectName"] = 50
            }
            , Source           = ENTITIES.Project
            
        };
    }
}
