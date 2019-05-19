using System;
using System.Data;

namespace ModelLibrary.Common {

    public interface IDBConnectionManager {
        void Open();
        void Close();
        ResultSet Execute(Statement statement);
        DataTable Query(Statement statement);
        object QueryScalar(Statement statement);
    }
}