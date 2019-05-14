using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManagerLibrary.Common;
using System.Data.Common;
using ModelLibrary.Common;
using ControllerLibrary.Security;
using ModelLibrary.Security;
using System.Reflection;

namespace ControllerLibrary.Common
{

    public abstract class AbstractController<M> where M : BaseModel {

        public static Dictionary<Type, DbType> DataTypeMapping = new Dictionary<Type, DbType>() {
            [typeof(string)]   = DbType.String,
            [typeof(int)]      = DbType.Int32,
            [typeof(double)]   = DbType.Double,
            [typeof(DateTime)] = DbType.Date
        };


        protected DBConnectionManager db = DBConnectionManager.Instance;
        //public abstract void updateMetaData();
        //public abstract DataTable search(M model);


        public List<M> search(M model,string[]whereFields) {
            var reader = db.getReader(new DBManagerLibrary.Common.Statement() {
                sql = string.Format(@"SELECT [{0}] 
                                        FROM {1} 
                                       WHERE {2} ", 
                                       string.Join("],[", fields), 
                                       this.TABLE_NAME,
                                       string.Join(" AND ", (from wf in whereFields select string.Format("[{0}]=@{0}",wf)) )),
                parameters = getParameters(whereFields, model)
            });
            var result = new List<M>();
            while (reader.Read()) {
                var m = Activator.CreateInstance<M>();
                for (int i = 0; i < fields.Length; i++) {
                    typeof(M).GetProperty(fields[i]).SetValue(m, DBNull.Value.Equals(reader.GetValue(i)) ? null : reader.GetValue(i) );
                }
                result.Add(m);
            }
            return result;
        }


        public void save(M model) {
            if (model.Id == 0) insert(model);
            else update(model);
        }

        public void insert(M model) {
            db.execute(getInsertStatement(model));
            if(this.GetType().Equals(typeof(AuditController)) == false) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = string.Format("insert new record into [{0}] fields [{1}]",this.TABLE_NAME, convertModelToString(model))
                });
            }
        }
        public void update(M model) {
            db.execute(getUpdateStatement(model));
            if (this.GetType().Equals(typeof(AuditController)) == false) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = string.Format("update record of [{0}] fields [{1}]", this.TABLE_NAME, convertModelToString(model))
                });
            }
        }
        public void delete(M model) {
            db.execute(getDeleteStatement(model));
            if (this.GetType().Equals(typeof(AuditController)) == false) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = string.Format("delete record from [{0}] fields [{1}]", this.TABLE_NAME, convertModelToString(model))
                });
            }
        }
        public virtual DataTable all() {
            return db.query(getSelectStatement());
        }

        public abstract string TABLE_NAME { get; }

        public Recordset<M> getRecordset() {
            return new Recordset<M>(db.getReader(new Statement() {
                sql = string.Format("SELECT [{0}] FROM {1} ORDER BY [Id]", string.Join("],[", this.fields), this.TABLE_NAME),
            }));
        }

        public Recordset<M> getRecordset(IDataParameter[]parameters) {
            string WHERE = string.Join(" AND ", (from parameter in parameters select string.Format("[{0}]={0}", parameter.ParameterName))).Replace("[@","[");
            return new Recordset<M>(db.getReader(new Statement() {
                sql = string.Format("SELECT [{0}] FROM {1} WHERE 1=1 AND {2} ORDER BY [Id]", string.Join("],[", this.fields), this.TABLE_NAME, WHERE),
                parameters = parameters
            }));
        }


        public int count() {
            int cnt = (int)db.query_scalar(new Statement("SELECT COUNT(*) FROM " + this.TABLE_NAME));
            return cnt;
        }

        public int count(IDataParameter[] parameters) {
            string WHERE = string.Join(" AND ", (from parameter in parameters select string.Format("[{0}]={0}", parameter.ParameterName))).Replace("[@", "[");
            int cnt = (int)db.query_scalar(new Statement() {
                sql = string.Format("SELECT COUNT(*) FROM {0} WHERE 1=1 AND {1}",this.TABLE_NAME,WHERE),
                parameters = parameters
            });
            return cnt;
        }

        public AbstractController(){
            //this.updateMetaData();
            //this.MetaData = new Dictionary<string, string>() {
            //    ["Id"] = "TEXT(50)",
            //    ["Created_By"] = "TEXT(50)",
            //    ["Updated_By"] = "TEXT(50)",
            //    ["Created_On"] = "DATETIME",
            //    ["Updated_On"] = "DATETIME"
            //};
        }

        public M find(M model) {
            IDataReader reader = db.getReader(new Statement() {
                sql = string.Format("SELECT [{0}] FROM {1} WHERE [Id]=@Id",string.Join("],[",this.fields),this.TABLE_NAME),
                parameters = new IDataParameter[] {
                    DBConnectionManager.Instance.getDbDataParameter("Id", DbType.Int32, 0, model.Id )
                }
            });
            var recordset = new Recordset<M>(reader);
            if (recordset.MoveNext()) {
                return recordset.Current;
            } else {
                return null;
            }
        }

        public string[] fields { get { return (from property in typeof(M).GetProperties() select property.Name).ToArray<string>(); } }

        public static IDbDataParameter getParameterObject(Type datatype) {
            return DBConnectionManager.Instance.getDbDataParameter("?", DataTypeMapping[datatype] , 255, null);        
        }

        public virtual Statement getSelectStatement() {
            return new Statement() {
                sql = string.Format("SELECT [{0}] FROM {1} ORDER BY 1", string.Join("],[", fields), TABLE_NAME),
                parameters = new IDataParameter[0]
            };
        }

        public virtual Statement getInsertStatement(M model) {
            model.Created_On = DateTime.Now;
            model.Created_By = Session.Instance.CurrentUser == null ? "SYSTEM" : Session.Instance.CurrentUser.User_Name;

            string[] fields_without_id = (from field in fields
                                          where !field.ToLower().Equals("id")
                                          select field).ToArray<string>();

            return new Statement() {
                sql = string.Format("INSERT INTO {0} ([{1}]) VALUES ({2})",
                    TABLE_NAME,
                    string.Join("],[", fields_without_id),
                    string.Join(",", (from field in fields where !field.ToLower().Equals("id") select "@"+field).ToArray())
                ),
                parameters = getParameters(fields_without_id, model)
            };
        }

        public virtual Statement getUpdateStatement(M model) {
            string[] fields_without_id = (from field in fields
                                          where !(
                                                    field.ToLower().Equals("id")         ||
                                                    field.ToLower().Equals("created_by") ||
                                                    field.ToLower().Equals("created_on")
                                                 )
                                          select field).ToArray<string>();

            //select string.Format("[{0}]=@{0}", field)).ToArray<string>();

            model.Updated_On = DateTime.Now;
            model.Updated_By = Session.Instance.CurrentUser.User_Name;
            return new Statement() {
                sql = string.Format("UPDATE {0} SET {1} WHERE [Id]=@Id",
                    TABLE_NAME,
                    string.Join(",", (from f in fields_without_id select string.Format("[{0}]=@{0}", f) ).ToArray())
                ),
                parameters = getParameters( fields_without_id.Concat(new string[] { "Id" }).ToArray(),model )
            };
        }

        public virtual Statement getDeleteStatement(M model) {
            return new Statement() {
                sql = string.Format("DELETE FROM {0} WHERE [Id]=@Id", TABLE_NAME),
                parameters = getParameters(new string[] { "Id" }, model)
            };
        }

        public IDataParameter[] getParameters(M model) {
            return this.getParameters(this.fields, model);
        }

        public IDataParameter[] getParameters(string[] keys, M model) {
            IDataParameter[] result = new IDataParameter[keys.Length];
            for(int i = 0; i < keys.Length; i++) {
                string key = keys[i];
                result[i] = getParameterObject( typeof(M).GetProperty(key).PropertyType );
                result[i].ParameterName = "@" + key;
                result[i].Value = model.GetType().GetProperty(key).GetValue(model) ?? DBNull.Value;
            }
            return result;
        }

        public string convertModelToString(M model) {
            StringBuilder sb = new StringBuilder();
            foreach(PropertyInfo propertyInfo in model.GetType().GetProperties().OrderBy(p => p.Name)) {
                sb.Append(string.Format("{0}={1},",propertyInfo.Name,propertyInfo.GetValue(model)));
            }
            return sb.ToString();
        }
    }
}