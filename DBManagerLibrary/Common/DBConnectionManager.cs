using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace DBManagerLibrary.Common
{
    public class DBConnectionManager
    {
        public const string DB_CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\96650\source\repos\HIS\DB\his_database.mdb";        
        private DbProviderFactory dbFactory = DbProviderFactories.GetFactory("System.Data.OleDb");

        //private string connectionString;
        private DbConnection connection;
        private static DBConnectionManager _instance = null;
        private DataSet dataSet;

        private DBConnectionManager(string connectionString)
        {
            //this.connectionString = connectionString;
            this.connection = dbFactory.CreateConnection();
            this.connection.ConnectionString = DB_CONNECTION_STRING;
            this.connection.Open();
            this.dataSet = new DataSet();
        }

        public IDbDataParameter getDbDataParameter(string name,DbType dbType,int size,object value) {
            IDbDataParameter parameter = dbFactory.CreateParameter();
            parameter.ParameterName = name;
            parameter.DbType = dbType;
            parameter.Size = size;
            parameter.Value = value;
            return parameter;
        }

        //public void execute(string sql,IDataParameter[] parameters) {
        //    this.execute(new Statement(sql,parameters));
        //}
        //{
        //    execute(sql, new DbParameter[] { });
        //}

        public void execute(Statement statement) //string sql,DbParameter[]parameters)
        {
            var sql = statement.sql;
            var parameters = statement.parameters;
            //var cmd = new DbCommand(sql, this.connection);
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

        //public DataTable query(string sql)
        //{
        //    return query(sql, new DbParameter[] { });
        //}

        //public DataTable query(string sql, IDataParameter[] parameters) {
        //    return query(new Statement(sql, parameters));
        //}

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
                    _instance = new DBConnectionManager(DB_CONNECTION_STRING);
                }
                return _instance;
        } }

    }
}
