using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    public class Statement {
        public string TargetTable { get; set; }
        public string Sql { get; set; }
        public System.Data.IDataParameter[] Parameters { get; set; }

        public Statement(string targetTable) {
            this.TargetTable = targetTable;
        }

       public Statement(string targetTable,string sql) {
            this.TargetTable = targetTable;
            this.Parameters = new System.Data.IDataParameter[0];
            this.Sql = sql;
        }

        public Statement(string targetTable, string sql, System.Data.IDataParameter[] parameters) {
            this.TargetTable = targetTable;
            this.Parameters = parameters;
            this.Sql = sql;
        }

    }
}
