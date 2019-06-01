using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace MVCHIS.Common {
    public abstract class AbstractDBController<M> : IDBController<M> where M:BaseModel{
        private IDBEntity<M> BaseEntity { get; set; }
        public AbstractDBController() : base() {
            BaseEntity = DBEntitiesFactory.GetEntity<M>();
        }
        public virtual bool Validate(M model) {
            return BaseEntity.Validate(model);
        }
        //public abstract void Initialize();

        public virtual DataTable GetDataById(IEnumerable<int> Ids) => BaseEntity.GetDataById(NewModel(), Ids);
        public virtual IEnumerable<M> FindById(IEnumerable<int> Ids) => BaseEntity.FindById(NewModel(), Ids);
        public virtual M Find(M model, params string[] whereFields) => BaseEntity.Find(model,whereFields);
        public virtual M NewModel() => BaseEntity.NewModel();
        public virtual int Delete(M model) => BaseEntity.Delete(model);
        public virtual IEnumerable<M> Read() => Read(NewModel());
        public virtual IEnumerable<M> Read(M model, params string[] whereFields) => BaseEntity.Read(model, false, whereFields);
        public virtual IEnumerable<M> Read(M model, bool like = false, params string[] whereFields) => BaseEntity.Read(model, like, whereFields);
        public virtual int Save(M model){
            if (!Validate(model)) throw new Exception("Validation error.");
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

        public DataTable GetData() => BaseEntity.GetData(NewModel());

        public object Dispatch(string action, params object[] arguments) {
            return GetType().GetMethod(action).Invoke(this,arguments);
        }
    }
}
