using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ModelLibrary.Common;
using ModelLibrary.Common;
using ControllerLibrary.Security;
using ModelLibrary.Security;
using System.Reflection;

namespace ControllerLibrary.Common
{

    public abstract class AbstractDBController<M> : IDBController<M> where M : BaseModel {

        protected DBConnectionManager database = DBConnectionManager.Instance;


        public List<M> Read() {
            return Read(Activator.CreateInstance<M>(), new string[] { });
        }

        public List<M> Read(M model, string[] whereFields) {

            var dt = database.Query(model.GetSelectStatement(whereFields));
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

        public virtual DataTable GetTable(M model, string[] whereFields) {
            return database.Query(Activator.CreateInstance<M>().GetSelectStatement(whereFields));
        }
        public virtual DataTable GetTable() {
            return database.Query(Activator.CreateInstance<M>().GetSelectStatement());
        }

        public virtual M Save(M model) {
            if (model.Id == 0) { Create(model); } else { Update(model); }
            return this.Read(model, new string[] { "Created_On" }).First();
        }

        private void Create(M model) {
            model.Created_By = Session.Instance.CurrentUser.User_Name;
            model.Created_On = DateTime.Now;
            database.execute(model.GetInsertStatement());
            if(this.GetType().Equals(typeof(AuditController)) == false) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = $"insert new record into [{model.GetSource()}] fields [{model}]"
                });
            }
        }
        private void Update(M model) {
            model.Updated_By = Session.Instance.CurrentUser.User_Name;
            model.Updated_On = DateTime.Now;
            database.execute(model.GetUpdateStatement());
            if (this.GetType().Equals(typeof(AuditController)) == false) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = $"update record of [{model.GetSource()}] with fields [{model}]"
                });
            }
        }
        public virtual void Delete(M model) {
            database.execute(model.GetDeleteStatement());
            if (this.GetType().Equals(typeof(AuditController)) == false) {
                new AuditController().registerEvent(new AuditModel() {
                    User_Name = Session.Instance.CurrentUser.User_Name,
                    Event_Comments = $"delete record from [{model.GetSource()}] with fields [{model}]"
                });
            }
        }
    }
}