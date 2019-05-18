using ModelLibrary.Common;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {
    public interface BaseController {
        MetaData GetMetaData();
        DataTable GetTable();
        DataTable GetTable(object model, string[] whereFields);
        List<object> Read();
        List<object> Read(object model, string[] whereFields);
        object Save(object model);
        void Delete(object model);
    }
}
