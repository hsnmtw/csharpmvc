using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace ModelLibrary.Common
{
    public class DBConnectionManager : IDBConnectionManager, IDisposable
    {
        public static string
            DBCONFIGFACTORY   ,
            DBCONFIGPROVIDER  ,
            DBCONFIGSOURCE    ,
            DBCONFIGUSER      ,
            DBCONFIGPASSWORD  ;

        public DbProviderFactory dbFactory => DbProviderFactories.GetFactory(DBCONFIGFACTORY);

        private DbConnection connection;
        private static DBConnectionManager instance = null;
        private DataSet dataSet;
        public DataTable SchemaTables { get { return this.connection.GetSchema("Tables"); } }
        public DataTable SchemaColumns { get; private set; }

        private DBConnectionManager() { }

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

        public string GetConnectionString() {
            DbConnectionStringBuilder csBuilder = dbFactory.CreateConnectionStringBuilder();

            csBuilder["Provider"]    = DBCONFIGPROVIDER;
            csBuilder["Data Source"] = DBCONFIGSOURCE;
            csBuilder["User Id"]     = DBCONFIGUSER;
            csBuilder["Password"]    = DBCONFIGPASSWORD;

            return csBuilder.ConnectionString;
        }

        public void Open() {
            if(!(this.connection == null || this.connection.State == ConnectionState.Closed)) {
                throw new InvalidOperationException("database is already open");
            }


            this.connection = dbFactory.CreateConnection();
            this.connection.ConnectionString = GetConnectionString();
            this.connection.Open();
            this.dataSet = new DataSet();
            this.SchemaColumns = this.connection.GetSchema("Columns");
        }

        public void Close() {
            if (this.connection == null || this.connection.State == ConnectionState.Closed) {
                throw new InvalidOperationException("database is null or already closed");
            }
            this.connection.Close();
            try {
                this.connection.GetType().GetMethod("ReleaseObjectPool").Invoke(null,null);
            } catch { }
            this.connection.Dispose();
            this.connection = null;
            GC.Collect();
        }

        public static DBConnectionManager Instance { get {
                if (instance == null)
                {
                    instance = new DBConnectionManager();
                }
                return instance;
        } }


        public async void CompactAndRepair(ProgressUpdate pu) {
            //var pu = Operations["CompactAndRepair"] = new ProgressUpdate("CompactAndRepair");

            pu.SetProgress("Closing database", 0);
            ModelLibrary.Common.DBConnectionManager.Instance.Close();
            await Task.Delay(1000);

            pu.SetProgress("Database is closed", 10);
            await Task.Delay(3000);

            string dbFileName = DBCONFIGSOURCE;

            //engine.OpenDatabase(dbFileName).Close();
            string FORMAT = "yyyyMMdd.HHmmss";
            pu.SetProgress("Taking backup of database file", 20);
            System.IO.File.Copy(dbFileName, dbFileName + $".bak.{DateTime.Now.ToString(FORMAT)}",true);
            System.IO.File.Copy(dbFileName, dbFileName + $".bak", true);

            pu.SetProgress("Deleting previous compact and repair files", 30);
            if (System.IO.File.Exists(dbFileName + ".car")) {
                System.IO.File.Delete(dbFileName + ".car");
            }

            if (System.IO.File.Exists(dbFileName.Replace(".mdb",".ldb"))) {
                System.IO.File.Delete(dbFileName.Replace(".mdb", ".ldb"));
            }

            pu.SetProgress("Performing DAO engine Compact action ...", 40);
            var engine = new DAO.DBEngine();
            
            engine.CompactDatabase(SrcName: dbFileName+".bak", DstName: dbFileName+".car" );

            await Task.Delay(5000);
            pu.SetProgress("Compact and repair is completed successfully", 70);
            
            engine.FreeLocks();
            engine = null;

            await Task.Delay(3000);
            pu.SetProgress("DAO engine is closed", 80);
            pu.SetProgress($"Database file size before compact : {new System.IO.FileInfo(dbFileName+".bak").Length/1024} MB",85);

            int limit = 0;
            while (limit<10 && System.IO.File.Exists(dbFileName)) {
                await Task.Delay(1000);
                try {
                    System.IO.File.Delete(dbFileName);
                } catch {
                    pu.SetProgress("Database file is still not released....", 85+limit++);
                }
            }

            

            pu.SetProgress("database file is deleted", 90);

            System.IO.File.Copy(dbFileName+".car", dbFileName, true);
            pu.SetProgress("Compact and Repair is completed", 95);
            await Task.Delay(3000);
            ModelLibrary.Common.DBConnectionManager.Instance.Open();
            await Task.Delay(300);
            pu.SetProgress("Database connection is re-opened after compact and rapair", 98);
            await Task.Delay(50);
            pu.SetProgress($"Database file size after compact : {new System.IO.FileInfo(dbFileName).Length / 1024} MB", 99);
            await Task.Delay(50);
            pu.SetProgress("Compact and Repair completed successfully !!",100);
        }

        //public void FixColumnNames() {
        //    var ctlg = new ADOX.Catalog();
        //    var conn = new ADODB.Connection();
        //    conn.Open(GetConnectionString());
            
        //    ctlg.ActiveConnection = conn;
            
        //    foreach (ADOX.Table table in ctlg.Tables) {
        //        //try { table.Name = table.Name.Replace("", ""); } catch { }
        //        foreach(ADOX.Column col in table.Columns) {
        //            Console.WriteLine($"{col.Name} : {col.Type} : {col.Attributes}");
        //        }
        //    }
            
        //    conn.Close();
        //    conn = null;
        //}

        public void Dispose() {
            this.Close();
        }
    }
}