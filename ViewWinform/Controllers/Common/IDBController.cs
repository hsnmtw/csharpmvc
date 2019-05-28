using System.Collections.Generic;
using System.Data;

namespace MVCWinform.Common {
    public interface IDBController : IController {
        MetaData GetMetaData();
        M Find<M>(M model, params string[] whereFields);
        IEnumerable<M> FindById<M>(IEnumerable<int> Ids);
        DataTable GetDataById<M>(IEnumerable<int> Ids);
        IEnumerable<M> Read<M>();
        IEnumerable<M> Read<M>(M model, params string[] whereFields);
        IEnumerable<M> Read<M>(M model, bool like = false, params string[] whereFields);
        int Save(BaseModel model);
        int Delete(BaseModel model);
        M NewModel<M>();
        object Dispatch(string action, params object[] arguments);
        DataTable GetData<M>();
    }
}
