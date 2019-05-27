using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace MVCWinform.Common {
    public class ParametersFactory {


        public static Dictionary<Type, DbType> DataTypeMapping = new Dictionary<Type, DbType>() {
            [typeof(string)]    = DbType.String,
            [typeof(int)]       = DbType.Int32,
            [typeof(double)]    = DbType.Double,
            [typeof(DateTime)]  = DbType.DateTime,
            [typeof(DateTime?)] = DbType.DateTime,
            [typeof(Boolean)]   = DbType.Boolean
        };

        public static IDataParameter[] CreateParameters(object model, string[] keys) {
            IDataParameter[] result = new IDataParameter[keys.Length];
            if (keys.Length == 0) return result;
            for (int i = 0; i < keys.Length; i++) {
                var key = keys[i];
                var propinfo = model.GetType().GetProperty(key);
                result[i] = GetParameterObject(propinfo.PropertyType);
                result[i].ParameterName = $"@{key}";
                result[i].Value = propinfo.GetValue(model) ?? DBNull.Value;
                if (result[i].DbType == DbType.DateTime && result[i].Value != DBNull.Value) {
                    result[i].Value = ((DateTime)result[i].Value).ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            return result;
        }

        private static IDbDataParameter GetParameterObject(Type datatype) {
            return CreateParameter(DBConnectionManager.dbFactory, "?", DataTypeMapping[datatype], 255, null);
        }

        
        public static IDbDataParameter CreateParameter(DbProviderFactory dbFactory,string name, DbType dbType, int size, object value) {
            IDbDataParameter parameter = dbFactory.CreateParameter();
            parameter.ParameterName = name;
            parameter.DbType = dbType;
            parameter.Size = size;
            parameter.Value = value;
            return parameter;
        }
    }
}
