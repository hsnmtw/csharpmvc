
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace MVCHIS.Common {
    public class DBConnectionManager
    {
        public static string FACTORY, CONNECTION_STRING;
        public static DbProviderFactory dbFactory => DbProviderFactories.GetFactory(FACTORY);
        private IDbConnection connection;

        private static DBConnectionManager instance = null;
        public static DBConnectionManager Instance {
            get {
                if (instance == null) { instance = new DBConnectionManager(); }
                return instance;
            }
        }

        //public List<string> Tables => from dt in connection.GetOleDbSchemaTable()

        public void Open() {
            if (connection!=null && connection.State == ConnectionState.Open) return;
            connection = dbFactory.CreateConnection();
            connection.ConnectionString = CONNECTION_STRING;
            connection.Open();
        }

        public int Execute(string sql, params KeyValuePair<string, object>[] parameters) {
            Console.WriteLine(sql);
            int result=-1;
            if (connection == null || connection.State != ConnectionState.Open) Open();
            using(var command = connection.CreateCommand()) {
                command.CommandText = sql;
                foreach(var parameter in parameters) {
                    var param = dbFactory.CreateParameter();
                    param.ParameterName = parameter.Key;
                    param.Value = parameter.Value ?? DBNull.Value;
                    command.Parameters.Add(param);
                }
                result = command.ExecuteNonQuery();
            }
            return result;
        }

        public  List<M> Query<M>(M m,string sql, params KeyValuePair<string, object>[] parameters) {
            if (connection == null || connection.State != ConnectionState.Open) {
                Open();
            }
            var modelType = m.GetType();
            var prps = new Dictionary<string, PropertyInfo>();
            foreach(var pinfo in modelType.GetProperties()) {
                prps[pinfo.Name] = pinfo;
            }
            List<M> result = new List<M>();
            using (var command = connection.CreateCommand()) {
                command.CommandText = sql;
                foreach (var parameter in parameters) {
                    var param = dbFactory.CreateParameter();
                    param.ParameterName = parameter.Key;
                    param.Value = parameter.Value ?? DBNull.Value;
                    command.Parameters.Add(param);
                }
                using (var reader = command.ExecuteReader()) {
                    var names = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
                    foreach (IDataRecord record in reader as IEnumerable) {
                        object model = Activator.CreateInstance(modelType);
                        foreach (var name in names) {
                            if (record[name].Equals(DBNull.Value)) continue;
                            if (prps[name].PropertyType == typeof(bool)) {
                                prps[name].SetValue(model, !"0".Equals(record[name]));
                            } else if (prps[name].PropertyType == typeof(double)) {
                                prps[name].SetValue(model, double.Parse($"{record[name]}"));
                            } else {
                                prps[name].SetValue(model, record[name]);
                            }
                        }
                        //yield return (M)model;
                        result.Add((M)model);
                    }
                    reader.Close();
                }
            }
            return result;
        }


        public IEnumerable<Dictionary<string, object>> QueryAsDictionary(string sql, params KeyValuePair<string,object>[] parameters) {
            if (connection == null || connection.State != ConnectionState.Open) {
                Open();
            }
            using (var command = connection.CreateCommand()) {
                command.CommandText = sql;
                foreach (var parameter in parameters) {
                    var param = dbFactory.CreateParameter();
                    param.ParameterName = parameter.Key;
                    param.Value = parameter.Value ?? DBNull.Value;
                    command.Parameters.Add(param);
                }
                using (var reader = command.ExecuteReader()) {
                    var names = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
                    var model = new Dictionary<string, object>();
                    foreach (IDataRecord record in reader as IEnumerable) {
                        foreach (var name in names) {
                            if (record[name].Equals(DBNull.Value)) model[name] = null;
                            else model[name] = record[name];
                        }
                        yield return model;
                    }
                    reader.Close();
                }
            }
        }

        public DataTable GetData(string sql, params KeyValuePair<string, object>[] parameters) {
            var table = new DataTable();
            using (var command = (DbCommand)connection.CreateCommand()) {
                command.CommandText = sql;
                foreach (var parameter in parameters) {
                    var param = dbFactory.CreateParameter();
                    param.ParameterName = parameter.Key;
                    param.Value = parameter.Value ?? DBNull.Value;
                    command.Parameters.Add(param);
                }
                using (var adaptor = dbFactory.CreateDataAdapter()) {
                    adaptor.SelectCommand = command;
                    adaptor.Fill(table);
                }
            }
            return table;
        }

            //public static DataTable ConvertToDataTable<M>(IEnumerable<M> data) {
            //    var table = new DataTable();
            //    if (data.Count() == 0) return table;
            //    string[] columns = (from p in typeof(M).GetProperties() select p.Name).ToArray();
            //    foreach (var column in columns) {
            //        table.Columns.Add(column);
            //    }
            //    if (data.Count() == 0) return table;
            //    foreach (var item in data) {
            //        var row = new object[columns.Count()];
            //        for(int i = 0; i < columns.Count(); i++) {
            //            row[i] = typeof(M).GetProperty(columns[i]).GetValue(item);
            //        }
            //        table.Rows.Add(row);
            //    }
            //    return table;
            //}
        }
}