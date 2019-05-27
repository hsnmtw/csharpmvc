using System.Collections.Generic;
using System.Data;

namespace MVCWinform.Common {
    public interface IDBController : IController {
        MetaData GetMetaData();
        M Find<M>(M model, params string[] whereFields);
        List<object> Read();
        List<object> Read(object model, params string[] whereFields);
        List<object> Read(object model, bool like = false, params string[] whereFields);
        int Save(object model);
        int Delete(object model);
        object CreateNewModel();
        object Dispatch(string action, params object[] arguments);

        DataTable ConvertToDataTable(List<object> models);
    }
}
