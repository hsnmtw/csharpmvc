using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Project)]
    public class ProjectEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ProjectModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "ProjectName", "ClientShortName" }
            , UniqueKeyFields  = new string[] { "ProjectName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["ClientShortName" ] = 50
                ,["ProjectName"     ] = 50
            }
            , Source           = "CustomersProject"
            
        };
    }
}
