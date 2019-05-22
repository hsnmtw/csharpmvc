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
        DataTable GetTable(object model, string[] whereFields,bool like=false);
        ResultSet GetTable(object model, string[] whereFields,bool like,int offset,int length);
        List<object> Read();
        List<object> Read(object model, string[] whereFields);
        DBModificationResult Save(object model);
        DBModificationResult Delete(object model);
        object CreateNewModel();
        object Dispatch(string action, params object[] arguments);
    }
}
