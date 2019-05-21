using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class ProjectCollection : AbstractCollection {
        public override MetaData MetaData => new MetaData() {
              GetModelType        = typeof(ProjectModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields   = "Id,Project_Name,Client_Short_Name".Split(',')
            , GetSource           = "Customers_Project"
            , GetUniqueKeyFields  = new string[] { "Project_Name" }
        };
    }
}
