using System;
using System.Collections.Generic;
using System.Data;

namespace MVCHIS.Common {
    public interface IController {
        Type GetModelType();
        MetaData GetMetaData();
        DataTable GetData();
        Dictionary<int,string> GetKeysAndValues();
        string GetValues(int id);
        Action<int> OnSaveAction   { get; set; }
        Action<int> OnDeleteAction { get; set; }
    }
}
