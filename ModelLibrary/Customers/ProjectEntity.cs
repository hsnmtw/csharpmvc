using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class ProjectEntity : AbstractDBEntity {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ProjectModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,ProjectName,ClientShortName".Split(',')
            , GetSource           = "CustomersProject"
            , GetUniqueKeyFields  = new string[] { "ProjectName" }
        };
    }
}
