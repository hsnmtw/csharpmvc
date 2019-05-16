using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DBManagerLibrary.Common;
using ModelLibrary.Common;
using ControllerLibrary.Security;
using ModelLibrary.Security;
using System.Reflection;

namespace ControllerLibrary.Common
{

    public abstract class AbstractDBController<M> : BaseController where M : BaseModel {
        public abstract string Source { get;  }

        public static Dictionary<Type, DbType> DataTypeMapping = new Dictionary<Type, DbType>() {
            [typeof(string)]    = DbType.String,
            [typeof(int)]       = DbType.Int32,
            [typeof(double)]    = DbType.Double,
            [typeof(DateTime)]  = DbType.DateTime,
            [typeof(DateTime?)] = DbType.DateTime,
            [typeof(Boolean)]   = DbType.Boolean
        };

        protected DBConnectionManager db = DBConnectionManager.Instance;

        public List<M> search(M model,string[]whereFields) {
            return selectModelsAsList(model,whereFields);
        }

        public M CreateNewModel() {
            return Activator.CreateInstance<M>();
        }

        public DataTable selectModelsAsDataTable(IEnumerable<string> selectedFields) {
            return this.selectModelsAsDataTable(selectedFields, Activator.CreateInstance<M>(), new string[] { });
        }

        public DataTable selectModelsAsDataTable(IEnumerable<string> selectedFields, M model, string[] whereFields) {

            string query = "";

            if (whereFields.Length == 0) {
                query = string.Format("SELECT * FROM {0} ORDER BY 1", this.Source);

            } else {
                query = string.Format("SELECT * FROM {0} WHERE {1} ORDER BY 1",
                                        this.Source,
                                        string.Join(" AND ", (from string wf
                                                                in whereFields
                                                              select string.Format("[{0}]=@{0}", wf))));
            }
            
            DataTable dt = db.query(new Statement(this.Source,query, getParameters(whereFields, model)));
            DataView dv = new DataView(dt);
            return dv.ToTable(false, selectedFields.ToArray());
        }

        public List<M> selectModelsAsList() {
            return selectModelsAsList(Activator.CreateInstance<M>(), new string[] { });
        }

        public List<M> selectModelsAsList(M model, string[] whereFields) {

            string query = "";

            if (whereFields.Length == 0) {
                query = string.Format("SELECT * FROM {0} ORDER BY 1", this.Source);
            } else {
                query = string.Format("SELECT * FROM {0} WHERE {1} ORDER BY 1",
                                        this.Source,
                                        string.Join(" AND ", (from string wf
                                                                in whereFields
                                                                select string.Format("[{0}]=@{0}", wf))));
            }
            var dt = db.query(new Statement(this.Source) {
                Sql = query,
                Parameters = getParameters(whereFields, model)
            });
            var result = new List<M>();
            foreach (DataRow row in dt.Rows) {
                var m = Activator.CreateInstance<M>();
                for (int i = 0; i < dt.Columns.Count; i++) {
                    typeof(M).GetProperty(dt.Columns[i].ColumnName).SetValue(
                        m, 
                        DBNull.Value.Equals(row[i]) ? null : row[i]
                    );
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
                    Event_Comments = string.Format("insert new record into [{0}] fields [{1}]",this.Source, convertModelToString(model))
                });
            }
        }
        public void update(M model) {
            db.execute(getUpdateStatement(model));
            if (this.GetType().Equals(typeof(AuditController)) == false) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = string.Format("update record of [{0}] fields [{1}]", this.Source, convertModelToString(model))
                });
            }
        }
        public void delete(M model) {
            db.execute(getDeleteStatement(model));
            if (this.GetType().Equals(typeof(AuditController)) == false) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = string.Format("delete record from [{0}] fields [{1}]", this.Source, convertModelToString(model))
                });
            }
        }
        public virtual DataTable all() {
            return db.query(getSelectStatement());
        }

        public int count() {
            int cnt = (int)db.query_scalar(new Statement(this.Source,"SELECT COUNT(*) FROM " + this.Source));
            return cnt;
        }

        public int count(IDataParameter[] parameters) {
            string WHERE = string.Join(" AND ", (from parameter in parameters select string.Format("[{0}]={0}", parameter.ParameterName))).Replace("[@", "[");
            int cnt = (int)db.query_scalar(new Statement(this.Source) {
                Sql = string.Format("SELECT COUNT(*) FROM {0} WHERE 1=1 AND {1}",this.Source,WHERE),
                Parameters = parameters
            });
            return cnt;
        }

        public AbstractDBController(){}

        public M find(M model) {
            var dt = db.query(new Statement(this.Source) {
                Sql = string.Format("SELECT * FROM {0} WHERE [Id]=@Id",this.Source),
                Parameters = new IDataParameter[] {
                    DBConnectionManager.Instance.getDbDataParameter("Id", DbType.Int32, 0, model.Id )
                }
            });

            if (dt.Rows.Count==0) {
                return null;
            } else {
                M foundModel = Activator.CreateInstance<M>();
                DataRow row = dt.Rows[0];
                for (int i = 0; i < dt.Columns.Count; i++) {
                    typeof(M).GetProperty(dt.Columns[i].ColumnName).SetValue(
                        foundModel,
                        DBNull.Value.Equals(row[i]) ? null : row[i]
                    );
                }
                return foundModel;
            }
        }

        public string[] fields { get { return (from property in typeof(M).GetProperties() select property.Name).ToArray<string>(); } }

        public static IDbDataParameter getParameterObject(Type datatype) {
            return DBConnectionManager.Instance.getDbDataParameter("?", DataTypeMapping[datatype] , 255, null);        
        }

        public virtual Statement getSelectStatement() {
            return new Statement(this.Source) {
                Sql = string.Format("SELECT * FROM {0} ORDER BY 1", this.Source),
                Parameters = new IDataParameter[0]
            };
        }

        public virtual Statement getInsertStatement(M model) {
            model.Created_On = DateTime.Now;
            model.Created_By = Session.Instance.CurrentUser == null ? "SYSTEM" : Session.Instance.CurrentUser.User_Name;

            string[] fields_without_id = (from field in fields
                                          where !field.ToLower().Equals("id")
                                          select field).ToArray<string>();

            return new Statement(this.Source) {
                Sql = string.Format("INSERT INTO {0} ([{1}]) VALUES ({2})",
                    Source,
                    string.Join("],[", fields_without_id),
                    string.Join(",", (from field in fields where !field.ToLower().Equals("id") select "@"+field).ToArray())
                ),
                Parameters = getParameters(fields_without_id, model)
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

            model.Updated_On = DateTime.Now;
            model.Updated_By = Session.Instance.CurrentUser.User_Name;
            return new Statement(this.Source) {
                Sql = string.Format("UPDATE {0} SET {1} WHERE [Id]=@Id",
                    Source,
                    string.Join(",", (from f in fields_without_id select string.Format("[{0}]=@{0}", f) ).ToArray())
                ),
                Parameters = getParameters( fields_without_id.Concat(new string[] { "Id" }).ToArray(),model )
            };
        }

        public virtual Statement getDeleteStatement(M model) {
            return new Statement(this.Source) {
                Sql = string.Format("DELETE FROM {0} WHERE [Id]=@Id", Source),
                Parameters = getParameters(new string[] { "Id" }, model)
            };
        }

        public IDataParameter[] getParameters(M model) {
            return this.getParameters(this.fields, model);
        }

        public IDataParameter[] getParameters(string[] keys, M model) {
            IDataParameter[] result = new IDataParameter[keys.Length];
            if (keys.Length == 0) return result;
            for(int i = 0; i < keys.Length; i++) {
                string key = keys[i];
                result[i] = getParameterObject( typeof(M).GetProperty(key).PropertyType );
                result[i].ParameterName = "@" + key;
                result[i].Value = model.GetType().GetProperty(key).GetValue(model) ?? DBNull.Value;
                if(result[i].DbType == DbType.DateTime && result[i].Value != DBNull.Value) {
                    result[i].Value = ((DateTime)result[i].Value).ToString("yyyy-MM-dd HH:mm:ss");
                }
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