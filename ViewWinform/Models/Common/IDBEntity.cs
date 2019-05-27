using System.Collections.Generic;

namespace MVCWinform.Common {
    public interface IDBEntity : IEntity {
        object NewModel();
        int Create(object model);
        M Find<M>(M model, params string[] whereFields);
        List<object> Read(object model, bool like = false, params string[] whereFields);
        int Update(object model, params string[] whereFields);
        int Delete(object model, params string[] whereFields);
        MetaData MetaData { get; }
        string GetDDL();
    }
}