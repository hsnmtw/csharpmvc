using System;
using System.Collections.Generic;
using System.Data;

namespace ModelLibrary.Common {
    public interface BaseCollection {
        List<object> Read();

        List<object> Read(object model, string[] whereFields);

        DataTable GetTable(object model, string[] whereFields);

        DataTable GetTable();

        object CreateNew();

        object Save(object model);

        void Delete(object model);

        MetaData MetaData { get; }
    }
}