using System;
using System.Data;

namespace MVCHIS.Common {
    public interface IController {
        Type GetModelType();
        MetaData GetMetaData();
        DataTable GetData();
    }
}
