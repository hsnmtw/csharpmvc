using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace DBManagerLibrary.Common
{

    public class DBConnectionManager
    {
        //public const string DB_CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\96650\source\repos\HIS\DB\his_database.mdb";        

        public static string
            DB_CONFIG_FACTORY   ,
            DB_CONFIG_PROVIDER  ,
            DB_CONFIG_SOURCE    ,
            DB_CONFIG_USER      ,
            DB_CONFIG_PASSWORD  ;

        private DbProviderFactory dbFactory = DbProviderFactories.GetFactory(DB_CONFIG_FACTORY);

        //private string connectionString;
        private DbConnection connection;
        private static DBConnectionManager _instance = null;
        private DataSet dataSet;
        public DataTable SchemaTables { get { return this.connection.GetSchema("Tables"); } }
        public DataTable SchemaColumns { get; private set; }


        private DBConnectionManager()
        {
            DbConnectionStringBuilder csBuilder = dbFactory.CreateConnectionStringBuilder();

            //csBuilder["Provider"]                         = "Microsoft.Jet.OLEDB.4.0";
            //csBuilder["Data Source"]                      = @"C:\Users\96650\source\repos\HIS\DB\his_database.mdb";
            //csBuilder["User Id"]                          = "Admin";
            //csBuilder["Password"]                         = null;

            csBuilder["Provider"]                         = DB_CONFIG_PROVIDER;
            csBuilder["Data Source"]                      = DB_CONFIG_SOURCE;
            csBuilder["User Id"]                          = DB_CONFIG_USER;
            csBuilder["Password"]                         = DB_CONFIG_PASSWORD;


            this.connection = dbFactory.CreateConnection();
            this.connection.ConnectionString = csBuilder.ConnectionString;
            this.connection.Open();
            this.dataSet = new DataSet();
            this.SchemaColumns = this.connection.GetSchema("Columns");


        }

        public IDbDataParameter getDbDataParameter(string name,DbType dbType,int size,object value) {
            IDbDataParameter parameter = dbFactory.CreateParameter();
            parameter.ParameterName = name;
            parameter.DbType = dbType;
            parameter.Size = size;
            parameter.Value = value;
            return parameter;
        }


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

        public DbDataReader getReader(Statement statement) {
            var sql = statement.sql;//.Replace("WHERE 1=1 AND ORDER","ORDER");
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
/*
 * OLEDB Types:
 * 0 : Empty
2 : SmallInt
3 : Integer
4 : Single
5 : Double
6 : Currency
7 : Date
8 : BSTR
9 : IDispatch
10 : Error
11 : Boolean
12 : Variant
13 : IUnknown
14 : Decimal
16 : TinyInt
17 : UnsignedTinyInt
18 : UnsignedSmallInt
19 : UnsignedInt
20 : BigInt
21 : UnsignedBigInt
64 : Filetime
72 : Guid
128 : Binary
129 : Char
130 : WChar
131 : Numeric
133 : DBDate
134 : DBTime
135 : DBTimeStamp
138 : PropVariant
139 : VarNumeric
200 : VarChar
201 : LongVarChar
202 : VarWChar
203 : LongVarWChar
204 : VarBinary
205 : LongVarBinary

    */