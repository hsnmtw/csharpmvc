using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    [ForModel(MODELS.Project)]
    public class ProjectEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ProjectModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "ProjectName", "ClientShortName" }
            , GetUniqueKeyFields  = new string[] { "ProjectName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["ClientShortName" ] = 50
                ,["ProjectName"     ] = 50
            }
            , GetSource           = "CustomersProject"
            
        };
    }
}
