﻿using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Project)]
    public class ProjectEntity : AbstractDBEntity<ProjectModel> {
        public override MetaData MetaData => new MetaData() {
            //  ModelType        = typeof(ProjectModel)
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn", "ProjectName", "ClientId" }
            , RequiredFields   = new HashSet<string> { "Id", "ProjectName", "ClientId" }
            , UniqueKeyFields  = new HashSet<string> { "ProjectName" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
                ["ClientId"]   = new Tuple<string, string>(DBEntitiesFactory.GetEntity<ClientModel>().MetaData.Source,"Id")
            }
            , Sizes = new Dictionary<string, int> {
                  ["CreatedBy"  ] = 50
                , ["UpdatedBy"  ] = 50
                , ["ProjectName"] = 50
            }
            , Source           = "CustomersProject"
            
        };
    }
}
