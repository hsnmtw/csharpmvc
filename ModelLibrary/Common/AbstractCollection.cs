using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Common {
    public abstract class AbstractCollection : BaseCollection {

        protected DBConnectionManager database = DBConnectionManager.Instance;

        public abstract MetaData MetaData { get; }

        public virtual Statement GetDeleteStatement(object model) {
            return new Statement(MetaData.GetSource) {
                Sql = $"DELETE FROM [{MetaData.GetSource}] WHERE ([Id]=@Id)",
                Parameters = ParametersFactory.CreateParameters(model,new string[] { "Id" })
            };
        }

        public virtual Statement GetInsertStatement(object model) {

            string[] fields_without_id = (from field in MetaData.GetFields
                                          where !field.ToLower().Equals("id")
                                          select field).ToArray<string>();

            return new Statement(MetaData.GetSource) {
                Sql = string.Format("INSERT INTO [{0}] ([{1}]) VALUES (@{2})",
                    MetaData.GetSource,
                    string.Join("],[", fields_without_id),
                    string.Join(",@", fields_without_id)
                ),
                Parameters = ParametersFactory.CreateParameters(model,fields_without_id)
            };
        }

        public virtual Statement GetUpdateStatement(object model) {
            string[] fields_without_id = (from field in MetaData.GetFields
                                          where !(
                                                    field.ToLower().Equals("id") ||
                                                    field.ToLower().Equals("created_by") ||
                                                    field.ToLower().Equals("created_on")
                                                 )
                                          select field).ToArray<string>();


            return new Statement(MetaData.GetSource) {
                Sql = string.Format("UPDATE [{0}] SET {1} WHERE ([Id]=@Id)",
                    MetaData.GetSource,
                    string.Join(",", (from f in fields_without_id select string.Format("[{0}]=@{0}", f)).ToArray())
                ),
                Parameters = ParametersFactory.CreateParameters(model, fields_without_id.Concat(new string[] { "Id" }).ToArray())
            };
        }

        public virtual Statement GetSelectStatement() {
            return new Statement(MetaData.GetSource) {
                Sql = string.Format($"SELECT * FROM [{MetaData.GetSource}] ORDER BY 1")
            };
        }

        public virtual Statement GetSelectStatement(object model, string[] whereFields) {
            string query = "";

            if (whereFields.Length == 0) {
                query = $"SELECT * FROM [{MetaData.GetSource}] ORDER BY 1";
            } else {
                query = string.Format("SELECT * FROM [{0}] WHERE ({1}) ORDER BY 1",
                                        MetaData.GetSource,
                                        string.Join(" AND ", (from string wf
                                                                in whereFields
                                                              select $"[{wf}]=@{wf}")));
            }
            return new Statement(MetaData.GetSource) {
                Sql = query,
                Parameters = ParametersFactory.CreateParameters(model, whereFields)
            };
        }


        public List<object> Read() {
            return Read(CreateNew(), new string[] { });
        }

        public List<object> Read(object model, string[] whereFields) {

            var dt = database.Query(GetSelectStatement(model,whereFields));
            var result = new List<object>();
            foreach (DataRow row in dt.Rows) {
                var newModel = CreateNew();
                for (int i = 0; i < dt.Columns.Count; i++) {
                        model.GetType().GetProperty(dt.Columns[i].ColumnName).SetValue(
                        newModel,
                        DBNull.Value.Equals(row[i]) ? null : row[i]
                    );
                }
                result.Add(newModel);
            }
            //if (result.Count < 1) throw new Exception();
            return result;
        }

        public virtual DataTable GetTable(object model, string[] whereFields) {
            return database.Query(GetSelectStatement(model,whereFields));
        }
        public virtual DataTable GetTable() {
            return database.Query(GetSelectStatement());
        }

        public object CreateNew() {
            return Activator.CreateInstance(MetaData.GetModelType);
        }

        public virtual object Save(object model) {
            if (((BaseModel)model).Id == 0) { Create(model); } else { Update(model); }
            return this.Read(model, new string[] { "Created_On" }).First();
        }

        private void Create(object model) {
            //model.Created_By = Session.Instance.CurrentUser == null ? "SYSTEM" : Session.Instance.CurrentUser.User_Name;
            //model.Created_On = DateTime.Now;
            database.Execute(GetInsertStatement(model));
            //if (this.GetType().Equals(typeof(AuditController)) == false) {
            //    new AuditController().registerEvent(new AuditModel() {
            //        User_Name = Session.Instance.CurrentUser.User_Name,
            //        Event_Comments = $"insert new record into [{model.GetSource()}] fields [{model}]"
            //    });
            //}
        }
        private void Update(object model) {
            //model.Updated_By = Session.Instance.CurrentUser.User_Name;
            //model.Updated_On = DateTime.Now;
            database.Execute(GetUpdateStatement(model));
            //if (this.GetType().Equals(typeof(AuditController)) == false) {
            //    new AuditController().registerEvent(new AuditModel() {
            //        User_Name = Session.Instance.CurrentUser.User_Name,
            //        Event_Comments = $"update record of [{model.GetSource()}] with fields [{model}]"
            //    });
            //}
        }
        public virtual void Delete(object model) {
            database.Execute(GetDeleteStatement(model));
            //if (this.GetType().Equals(typeof(AuditController)) == false) {
            //    new AuditController().registerEvent(new AuditModel() {
            //        User_Name = Session.Instance.CurrentUser.User_Name,
            //        Event_Comments = $"delete record from [{model.GetSource()}] with fields [{model}]"
            //    });
            //}
        }
    }
}
