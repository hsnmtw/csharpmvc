using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class ProjectModel : BaseModel {
        public string ClientShortName   { get; set; }
        public string ProjectName   { get; set; }
    }
}
