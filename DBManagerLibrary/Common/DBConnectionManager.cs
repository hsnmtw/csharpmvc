using System;
using System.Data;
using System.Data.Common;

namespace DBManagerLibrary.Common
{

    public class DBConnectionManager
    {
        public static string
            DB_CONFIG_FACTORY   ,
            DB_CONFIG_PROVIDER  ,
            DB_CONFIG_SOURCE    ,
            DB_CONFIG_USER      ,
            DB_CONFIG_PASSWORD  ;

        private DbProviderFactory dbFactory = DbProviderFactories.GetFactory(DB_CONFIG_FACTORY);

        private DbConnection connection;
        private static DBConnectionManager _instance = null;
        private DataSet dataSet;
        public DataTable SchemaTables { get { return this.connection.GetSchema("Tables"); } }
        public DataTable SchemaColumns { get; private set; }


        private DBConnectionManager()
        {
            DbConnectionStringBuilder csBuilder = dbFactory.CreateConnectionStringBuilder();

            csBuilder["Provider"]       = DB_CONFIG_PROVIDER;
            csBuilder["Data Source"]    = DB_CONFIG_SOURCE;
            csBuilder["User Id"]        = DB_CONFIG_USER;
            csBuilder["Password"]       = DB_CONFIG_PASSWORD;

            this.connection = dbFactory.CreateConnection();
            this.connection.ConnectionString = csBuilder.ConnectionString;
            this.connection.Open();
            this.dataSet = new DataSet();
            this.SchemaColumns = this.connection.GetSchema("Columns");
        }

        public IDbDataParameter getDbDataParameter(string name,DbType dbType,int size,object value) {
            IDbDataParameter parameter = dbFactory.CreateParameter();
            parameter.ParameterName    = name;
            parameter.DbType           = dbType;
            parameter.Size             = size;
            parameter.Value            = value;
            return parameter;
        }


        public void execute(Statement statement) 
        {
            var sql = statement.Sql;
            var parameters = statement.Parameters;
            var cmd = this.connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            if (parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
                cmd.Prepare();
            }
            //Console.WriteLine(sql);
            if (this.dataSet.Tables.Contains(statement.TargetTable)) {
                this.dataSet.Tables.Remove(statement.TargetTable);
            }
            cmd.ExecuteNonQuery();
        }

        public DataTable query(Statement statement)
        {
            if (statement.Parameters.Length == 0 && this.dataSet.Tables.Contains(statement.TargetTable)) {
                //return cached data
                return this.dataSet.Tables[statement.TargetTable];
            }

            var dt = new DataTable(statement.TargetTable);
            var cmd = this.connection.CreateCommand();
            cmd.CommandText = statement.Sql;
            cmd.CommandType = CommandType.Text;

            if (statement.Parameters.Length > 0){
                cmd.Parameters.AddRange(statement.Parameters);
                cmd.Prepare();
            }

            using (var adaptor = dbFactory.CreateDataAdapter()){
                adaptor.SelectCommand = cmd;
                adaptor.Fill(dt);
            }
            DataTable cached = null; if (dataSet.Tables.Contains(dt.TableName)) { cached = dataSet.Tables[dt.TableName]; }
            if(cached != null) this.dataSet.Tables.Remove(cached);
            this.dataSet.Tables.Add(dt);  //save a cached copy
            return dt;
        }


        public object query_scalar(Statement statement) {
            var sql = statement.Sql;
            var parameters = statement.Parameters;
            
            var cmd = this.connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            if (parameters.Length > 0) {
                cmd.Parameters.AddRange(parameters);
                cmd.Prepare();
            }

            return cmd.ExecuteScalar();
        }

        public static DBConnectionManager Instance { get {
                if (_instance == null)
                {
                    _instance = new DBConnectionManager();
                }
                return _instance;
        } }

    }
}