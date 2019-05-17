using System;
using System.Data;

namespace DBManagerLibrary.Common {

    public interface IDBConnectionManager {
        IDbDataParameter getDbDataParameter(string name, DbType dbType, int size, object value);
        ResultSet execute(Statement statement);
        DataTable query(Statement statement);
        object queryScalar(Statement statement);
    }
}