using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManagerLibrary.Common {
    public class Statement {
        public string name { get; set; }
        public string sql { get; set; }
        public System.Data.IDataParameter[] parameters { get; set; }

        public Statement() {
            this.parameters = new System.Data.IDataParameter[0];
        }

        public Statement(string sql) {
            this.parameters = new System.Data.IDataParameter[0];
            this.sql = sql;
        }

        public Statement(string sql, System.Data.IDataParameter[] parameters) {
            this.parameters = parameters;
            this.sql = sql;
        }

    }
}
