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
            var sql = statement.sql;
            var parameters = statement.parameters;
            var cmd = this.connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            if (parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
                cmd.Prepare();
            }
            Console.WriteLine(sql);
            cmd.ExecuteNonQuery();
        }

        public DbDataReader getReader(Statement statement) {
            var sql = statement.sql;
            var parameters = statement.parameters;
            var cmd = this.connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            if (parameters.Length > 0) {
                cmd.Parameters.AddRange(parameters);
                cmd.Prepare();
            }
            return cmd.ExecuteReader();
        }

        public DataTable query(Statement statement)
        {
            var sql = statement.sql;
            var parameters = statement.parameters;

            var dt = new DataTable(statement.name);
            var cmd = this.connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            if (parameters.Length > 0){
                cmd.Parameters.AddRange(parameters);
                cmd.Prepare();
            }

            using (var adaptor = dbFactory.CreateDataAdapter()){
                adaptor.SelectCommand = cmd;
                adaptor.Fill(dt);
            }
            return dt;
        }


        public object query_scalar(Statement statement) {
            var sql = statement.sql;
            var parameters = statement.parameters;
            
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