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
        IEnumerable<M> Select(M model,string fields="*", bool like = false, params string[] whereFields);
        int Save(M model);
        int Delete(M model);
        M NewModel();
        string Validate(M model);
    }
}
