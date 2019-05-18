using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Data;
using System.Reflection;

namespace ModelLibrary.Common
{
    public abstract class BaseModel : IModel
    {

        public static Dictionary<Type, DbType> DataTypeMapping = new Dictionary<Type, DbType>() {
            [typeof(string)] = DbType.String,
            [typeof(int)] = DbType.Int32,
            [typeof(double)] = DbType.Double,
            [typeof(DateTime)] = DbType.DateTime,
            [typeof(DateTime?)] = DbType.DateTime,
            [typeof(Boolean)] = DbType.Boolean
        };

        //Database table properties
        public int Id               { get; set; }
        public string Created_By    { get; set; }
        public string Updated_By    { get; set; }
        public DateTime? Created_On { get; set; }
        public DateTime? Updated_On { get; set; }


        

        public virtual Statement GetDeleteStatement() {
            return new Statement(GetSource()) {
                Sql = $"DELETE FROM [{GetSource()}] WHERE [Id]=@Id",
                Parameters = GetParameters(new string[] { "Id" })
            };
        }

        public virtual Statement GetInsertStatement() {
            
            string[] fields_without_id = (from field in GetFields()
                                          where !field.ToLower().Equals("id")
                                          select field).ToArray<string>();

            return new Statement(GetSource()) {
                Sql = string.Format("INSERT INTO [{0}] ([{1}]) VALUES (@{2})",
                    GetSource(),
                    string.Join("],[", fields_without_id),
                    string.Join(",@", fields_without_id)
                ),
                Parameters = GetParameters(fields_without_id)
            };
        }

        public virtual Statement GetUpdateStatement() {
            string[] fields_without_id = (from field in GetFields()
                                          where !(
                                                    field.ToLower().Equals("id") ||
                                                    field.ToLower().Equals("created_by") ||
                                                    field.ToLower().Equals("created_on")
                                                 )
                                          select field).ToArray<string>();


            return new Statement(GetSource()) {
                Sql = string.Format("UPDATE [{0}] SET {1} WHERE [Id]=@Id",
                    GetSource(),
                    string.Join(",", (from f in fields_without_id select string.Format("[{0}]=@{0}", f)).ToArray())
                ),
                Parameters = GetParameters(fields_without_id.Concat(new string[] { "Id" }).ToArray())
            };
        }

        public virtual Statement GetSelectStatement() {
            return new Statement(GetSource()) {
                Sql = string.Format($"SELECT * FROM [{GetSource()}] ORDER BY 1")
            };
        }

        public virtual Statement GetSelectStatement(string[] whereFields) {
            string query = "";

            if (whereFields.Length == 0) {
                query = $"SELECT * FROM [{GetSource()}] ORDER BY 1";
            } else {
                query = string.Format("SELECT * FROM [{0}] WHERE {1} ORDER BY 1",
                                        GetSource(),
                                        string.Join(" AND ", (from string wf
                                                                in whereFields
                                                            select $"[{wf}]=@{wf}" )));
            }
            return new Statement(GetSource()) {
                Sql = query,
                Parameters = GetParameters(whereFields)
            };
        }




        private static IDbDataParameter GetParameterObject(Type datatype) {
            return DBConnectionManager.Instance.GetDbDataParameter("?", DataTypeMapping[datatype], 255, null);
        }

        public IDataParameter[] GetParameters(string[] keys) {
            IDataParameter[] result = new IDataParameter[keys.Length];
            if (keys.Length == 0) return result;
            for (int i = 0; i < keys.Length; i++) {
                string key = keys[i];
                result[i] = GetParameterObject(this.GetType().GetProperty(key).PropertyType);
                result[i].ParameterName = "@" + key;
                result[i].Value = this.GetType().GetProperty(key).GetValue(this) ?? DBNull.Value;
                if (result[i].DbType == DbType.DateTime && result[i].Value != DBNull.Value) {
                    result[i].Value = ((DateTime)result[i].Value).ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            return result;
        }


        /// <summary>
        /// the list of fields that make up the model
        /// </summary>
        /// <returns></returns>
        public abstract string[] GetFields();
        /// <summary>
        /// the source of data to populate the model
        /// </summary>
        /// <returns>eg. Database table from/to which data is stored</returns>
        public abstract string GetSource();
        /// <summary>
        /// get list of fields that collectively make the primary key.
        /// this should be used to verify uniqueness
        /// </summary>
        /// <returns>list of fields names that are part of the primary key</returns>
        public abstract string[] GetPrimaryKeyFields();
        /// <summary>
        /// get list of fields that are marked UNIQUE.
        /// this should be used to verify uniqueness
        /// </summary>
        /// <returns>list of fields names that are marked UNIQUE</returns>
        public abstract string[] GetUniqueKeyFields();
        /// <summary>
        /// gets the list of properties/fields that are mandatory
        /// this should be used for validation before saving a model
        /// to the source, e.g. <pre>GetSource()</pre>, that such fields
        /// contain data in them, i.e. NOT NULL
        /// </summary>
        /// <returns>list of fields names that are marked REQUIRED</returns>
        public abstract string[] GetRequiredFields();
        /// <summary>
        /// converts the model to printable format, this can be useful in logging
        /// </summary>
        /// <returns>string representation of the model</returns>
        public override string ToString() {
            return string.Join(",",(
                    from PropertyInfo propertyInfo 
                      in this.GetType().GetProperties()
                  select $"{propertyInfo.Name}='{propertyInfo.GetValue(this)}'"));
        }
    }
}