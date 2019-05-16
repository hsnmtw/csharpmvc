using ModelLibrary.Common;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {
    public interface BaseController { //<M> where M : BaseModel {
        string Source { get; }
        DataTable selectModelsAsDataTable();
    }
}
