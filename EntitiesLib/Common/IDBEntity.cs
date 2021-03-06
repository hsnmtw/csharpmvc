﻿using System.Collections.Generic;
using System.Data;

namespace MVCHIS.Common {
    public interface IDBEntity<M> : IEntity where M:BaseModel{
        M NewModel();
        int Create(M model);
        M Find(M model, params string[] whereFields);
        IEnumerable<M> FindById(M model, IEnumerable<int> Ids);
        DataTable GetDataById(M model, IEnumerable<int> Ids);
        IEnumerable<M> Select(M model,string fields="*", bool like = false, params string[] whereFields);
        int Update(M model, params string[] whereFields);
        int Delete(M model, params string[] whereFields);
        DataTable GetData(M model,string fields="*", bool like = false, params string[] whereFields);
        M Exists(M model);
        string Validate(M model);
        
    }
}