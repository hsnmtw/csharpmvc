using System;
using System.Collections.Generic;
using System.Data;

namespace ModelLibrary.Common {
    public interface BaseCollection {
        List<object> Read();

        List<object> Read(object model, params string[] whereFields);
        //List<object> Read(object model, string[] whereFields,int offset,int length);

        DataTable GetTable(object model, string[] whereFields, bool like=false);

        ResultSet GetTable(object model, string[] whereFields, bool like, int page,int pagesize);

        DataTable GetTable();

        object CreateNew();

        DBModificationResult Save(object model);
        
        DBModificationResult Delete(object model);
        DBModificationResult Delete(object model, params string[] whereFields);

        MetaData MetaData { get; }
    }
}