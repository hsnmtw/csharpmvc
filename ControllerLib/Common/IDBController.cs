using System;
using System.Collections.Generic;
using System.Data;

namespace MVCHIS.Common {
    public interface IDBController<M> : IController where M:BaseModel {
        //MetaData GetMetaData();
        M Find(M model, params string[] whereFields);
        IEnumerable<M> FindById(IEnumerable<int> Ids);
        DataTable GetDataById(IEnumerable<int> Ids);
        IEnumerable<M> Read();
        IEnumerable<M> Read(M model, params string[] whereFields);
        IEnumerable<M> Read(M model, bool like = false, params string[] whereFields);
        int Save(M model);
        int Delete(M model);
        M NewModel();
        object Dispatch(string action, params object[] arguments);
        //DataTable GetData();
        bool Validate(M model);
        Action<M> OnSaveAction { get; set; }
        Action<M> OnDeleteAction { get; set; }
    }
}
