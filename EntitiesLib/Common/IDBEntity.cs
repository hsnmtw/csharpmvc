using System.Collections.Generic;
using System.Data;

namespace MVCHIS.Common {
    public interface IDBEntity : IEntity {
        M NewModel<M>();
        int Create<M>(M model);
        M Find<M>(M model, params string[] whereFields);
        IEnumerable<M> FindById<M>(M model, IEnumerable<int> Ids);
        DataTable GetDataById<M>(M model, IEnumerable<int> Ids);
        IEnumerable<M> Read<M>(M model, bool like = false, params string[] whereFields);
        int Update<M>(M model, params string[] whereFields);
        int Delete<M>(M model, params string[] whereFields);
        DataTable GetData<M>(M model, bool like = false, params string[] whereFields);
        MetaData MetaData { get; }
        string GetDDL();
    }
}