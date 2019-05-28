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
        public virtual M Find<M>(M model, params string[] whereFields) => BaseEntity.Find(model,whereFields);
        public virtual M NewModel<M>() => BaseEntity.NewModel<M>();
        public virtual int Delete(BaseModel model) => BaseEntity.Delete(model);
        public virtual IEnumerable<M> Read<M>() => Read(Activator.CreateInstance<M>());
        public virtual IEnumerable<M> Read<M>(M model, params string[] whereFields) => BaseEntity.Read(model, false, whereFields);
        public virtual IEnumerable<M> Read<M>(M model, bool like = false, params string[] whereFields) => BaseEntity.Read(model, like, whereFields);
        public virtual int Save(BaseModel model){
            //var type = model.GetType();
            if (model.Id == 0) {
                model.CreatedBy = (Session.Instance.CurrentUser==null ? "SYSTEM" : Session.Instance.CurrentUser.UserName);
                model.CreatedOn = (DateTime.Now);
                return BaseEntity.Create(model);
            } else {
                model.UpdatedBy = (Session.Instance.CurrentUser == null ? "SYSTEM" : Session.Instance.CurrentUser.UserName);
                model.UpdatedOn = (DateTime.Now);
                return BaseEntity.Update(model,"Id");
            }
        }
        public MetaData GetMetaData() => BaseEntity.MetaData;

        public DataTable GetData<M>() => BaseEntity.GetData(NewModel<M>());

        public object Dispatch(string action, params object[] arguments) {
            return GetType().GetMethod(action).Invoke(this,arguments);
        }
    }
}
