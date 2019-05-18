using System;
using System.Data;

namespace ModelLibrary.Common {

    public interface IDBConnectionManager {
        IDbDataParameter GetDbDataParameter(string name, DbType dbType, int size, object value);
        ResultSet execute(Statement statement);
        DataTable Query(Statement statement);
        object queryScalar(Statement statement);
    }
}