using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Customers {
    //[ForModel(MODELS.Project)]
    public class ProjectEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(ProjectModel)
            , PrimaryKeyField  = "Id"
            , RequiredFields   = new List<string> { "Id", "ProjectName", "ClientId" }
            , UniqueKeyFields  = new List<string> { "ProjectName" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
                ["ClientId"]   = new System.Tuple<string, string>(DBEntitiesFactory.GetEntity(MODELS.Client).MetaData.Source,"Id")
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                 ["ProjectName"     ] = 50
            }
            , Source           = "CustomersProject"
            
        };
    }
}
