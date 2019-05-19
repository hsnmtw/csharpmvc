using System;
using System.Collections.Generic;
using System.Data;

namespace ModelLibrary.Common {
    public interface BaseCollection {
        List<object> Read();

        List<object> Read(object model, string[] whereFields);
        //List<object> Read(object model, string[] whereFields,int offset,int length);

        DataTable GetTable(object model, string[] whereFields, bool like=false);

        ResultSet GetTable(object model, string[] whereFields, bool like, int page,int pagesize);

        DataTable GetTable();

        object CreateNew();

        object Save(object model);

        void Delete(object model);

        MetaData MetaData { get; }
    }
}