using System;
using System.Collections.Generic;
using System.Data;

namespace MVCWinform.Common {
    public class AbstractDBController : IDBController {
        private IDBEntity BaseEntity { get; set; }
        private AbstractDBController() { }
        public AbstractDBController(IDBEntity baseEntity) {
            if (baseEntity == null) throw new ArgumentNullException("baseEntity");
            this.BaseEntity = baseEntity;
        }
        public virtual M Find<M>(M model, params string[] whereFields) => this.BaseEntity.Find(model,whereFields);
        public virtual object CreateNewModel() => this.BaseEntity.NewModel();
        public virtual int Delete(object model) => this.BaseEntity.Delete(model);
        public virtual List<object> Read() => Read(CreateNewModel());
        public virtual List<object> Read(object model, params string[] whereFields) => this.BaseEntity.Read(model, false, whereFields);
        public virtual List<object> Read(object model, bool like = false, params string[] whereFields) => this.BaseEntity.Read(model, like, whereFields);
        public virtual int Save(object model){
            var type = model.GetType();
            if (Convert.ToInt32(type.GetProperty("Id").GetValue(model)) == 0) {
                type.GetProperty("CreatedBy").SetValue(model, Session.Instance.CurrentUser==null ? "SYSTEM" : Session.Instance.CurrentUser.UserName);
                type.GetProperty("CreatedOn").SetValue(model, DateTime.Now);
                return BaseEntity.Create(model);
            } else {
                type.GetProperty("UpdatedBy").SetValue(model, Session.Instance.CurrentUser == null ? "SYSTEM" : Session.Instance.CurrentUser.UserName);
                type.GetProperty("UpdatedOn").SetValue(model, DateTime.Now);
                return BaseEntity.Update(model,"Id");
            }
        }
        public MetaData GetMetaData() => this.BaseEntity.MetaData;

        public DataTable ConvertToDataTable(List<object> models) => AbstractDBEntity.ConvertToDataTable(models);

        public object Dispatch(string action, params object[] arguments) {
            return this.GetType().GetMethod(action).Invoke(this,arguments);
        }
    }
}
