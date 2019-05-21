using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Customers {
    public class ProjectModel : BaseModel {
        public string Client_Short_Name   { get; set; }
        public string Project_Name   { get; set; }
    }
}
