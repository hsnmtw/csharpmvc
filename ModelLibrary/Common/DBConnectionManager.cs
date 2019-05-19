using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace ModelLibrary.Common
{
    public class DBConnectionManager : IDBConnectionManager
    {
        public static string
            DB_CONFIG_FACTORY   ,
            DB_CONFIG_PROVIDER  ,
            DB_CONFIG_SOURCE    ,
            DB_CONFIG_USER      ,
            DB_CONFIG_PASSWORD  ;

        public DbProviderFactory dbFactory => DbProviderFactories.GetFactory(DB_CONFIG_FACTORY);

        private DbConnection connection;
        private static DBConnectionManager _instance = null;
        private DataSet dataSet;
        public DataTable SchemaTables { get { return this.connection.GetSchema("Tables"); } }
        public DataTable SchemaColumns { get; private set; }


        private DBConnectionManager()
        {
        }

        public ResultSet Execute(Statement statement) 
        {
            
            var sql = statement.Sql;
            var parameters = statement.Parameters;
            var cmd = this.connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            if (parameters.Length > 0) {
                cmd.Parameters.AddRange(parameters);
                cmd.Prepare();
            }
            //Console.WriteLine(sql);

            var result = cmd.ExecuteNonQuery();
            if (this.dataSet.Tables.Contains(statement.TargetTable)) {
                this.dataSet.Tables.Remove(statement.TargetTable);
            }

            return new ResultSet() { Status = true, ResponseMessage = result.ToString() };            
        }

        public DataTable Query(Statement statement)
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
            if (statement.Parameters.Length == 0) {
                DataTable cached = null; if (dataSet.Tables.Contains(dt.TableName)) { cached = dataSet.Tables[dt.TableName]; }
                if (cached != null) this.dataSet.Tables.Remove(cached);
                this.dataSet.Tables.Add(dt);  //save a cached copy
            }
            return dt;
        }


        public object QueryScalar(Statement statement) {
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

        public void Open() {
            if(!(this.connection == null || this.connection.State == ConnectionState.Closed)) {
                throw new InvalidOperationException("database is already open");
            }
            DbConnectionStringBuilder csBuilder = dbFactory.CreateConnectionStringBuilder();

            csBuilder["Provider"] = DB_CONFIG_PROVIDER;
            csBuilder["Data Source"] = DB_CONFIG_SOURCE;
            csBuilder["User Id"] = DB_CONFIG_USER;
            csBuilder["Password"] = DB_CONFIG_PASSWORD;

            this.connection = dbFactory.CreateConnection();
            this.connection.ConnectionString = csBuilder.ConnectionString;
            this.connection.Open();
            this.dataSet = new DataSet();
            this.SchemaColumns = this.connection.GetSchema("Columns");
        }

        public void Close() {
            if (this.connection == null || this.connection.State == ConnectionState.Closed) {
                throw new InvalidOperationException("database is null or already closed");
            }
            this.connection.Close();
            this.connection.Dispose();
            this.connection = null;
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