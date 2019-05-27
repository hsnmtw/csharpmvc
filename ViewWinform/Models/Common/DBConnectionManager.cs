
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace MVCWinform.Common {
    public class DBConnectionManager
    {
        public static string FACTORY, CONNECTION_STRING;
        public static DbProviderFactory dbFactory => DbProviderFactories.GetFactory(FACTORY);

        public static int Execute(string sql, params KeyValuePair<string, object>[] parameters) {
            int result=-1;
            using (IDbConnection connection = dbFactory.CreateConnection()) {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                //result = connection.Execute(sql, parameters);
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
                connection.Close();
                connection.Dispose();
            }
            return result;
        }

        public static List<object> Query(string sql,Type type, params KeyValuePair<string,object>[] parameters) {
            List<object> result = new List<object>();
            using (IDbConnection connection = dbFactory.CreateConnection()) {
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                using (var command = connection.CreateCommand()) {
                    command.CommandText = sql;
                    foreach (var parameter in parameters) {
                        var param = dbFactory.CreateParameter();
                        param.ParameterName = parameter.Key;
                        param.Value = parameter.Value ?? DBNull.Value;
                        
                        command.Parameters.Add(param);
                    }
                    using (var reader = command.ExecuteReader()) {
                        var names = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                        foreach (IDataRecord record in reader as IEnumerable) {
                            dynamic model = (type==null) ? new Dictionary<string,object>() : Activator.CreateInstance(type);
                            foreach (var name in names) {
                                object value = record[name] == DBNull.Value ? null : record[name];
                                if (type == null) {
                                    model[name] = value;
                                } else {
                                    switch (type.GetProperty(name).PropertyType.ToString()) {
                                        case "System.Boolean":
                                        case "bool":
                                            type.GetProperty(name).SetValue(model, !$"{value}".Equals("0"));
                                            break;
                                        default:
                                            type.GetProperty(name).SetValue(model, value);
                                            break;
                                    }
                                    
                                }
                            }
                            //yield return model;
                            result.Add(model);
                        }
                        reader.Close();
                    }
                }
                connection.Close();
                connection.Dispose();
            }
            return result;
        }


        public static DataTable ConvertToDataTable(List<object> data) {
            var table = new DataTable();
            if (data.Count() == 0) return table;
            string[] columns = (from p in data[0].GetType().GetProperties() select p.Name).ToArray();
            foreach (var column in columns) {
                table.Columns.Add(column);
            }
            if (data.Count() == 0) return table;
            foreach (var item in data) {
                var row = new object[columns.Count()];
                for(int i = 0; i < columns.Count(); i++) {
                    row[i] = item.GetType().GetProperty(columns[i]).GetValue(item);
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}