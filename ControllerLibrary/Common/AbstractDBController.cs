using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ControllerLibrary.Common {
    public class AbstractDBController : IDBController {
        private IDBEntity BaseEntity { get; set; }
        private AbstractDBController() { }
        public AbstractDBController(IDBEntity baseEntity) {
            if (baseEntity == null) throw new ArgumentNullException("baseEntity");
            this.BaseEntity = baseEntity;
        }
        public virtual object CreateNewModel() => this.BaseEntity.CreateNew();
        public virtual DBModificationResult Delete(object model) => this.BaseEntity.Delete(model);
        public virtual DataTable GetTable() => GetTable(new object(),new string[] { });
        public virtual DataTable GetTable(object model, string[] whereFields,bool like=false) => this.BaseEntity.GetTable(model, whereFields,like);
        public virtual ResultSet GetTable(object model, string[] whereFields,bool like,int offset, int length) => this.BaseEntity.GetTable(model, whereFields,like,offset,length);
        public virtual List<object> Read() => BaseEntity.Read();
        public virtual List<object> Read(object model, params string[] whereFields) => BaseEntity.Read(model, whereFields);
        public virtual DBModificationResult Save(object anyModel) {
            var model = (BaseModel)anyModel;
            if (model.Id == 0) {
                model.CreatedBy = Session.Instance.CurrentUser==null ? "SYSTEM" : Session.Instance.CurrentUser.UserName;
                model.CreatedOn = DateTime.Now;
            } else {
                model.UpdatedBy = Session.Instance.CurrentUser == null ? "SYSTEM" : Session.Instance.CurrentUser.UserName;
                model.UpdatedOn = DateTime.Now;
            }
            return BaseEntity.Save(model);
        }

        public MetaData GetMetaData() => this.BaseEntity.MetaData;

        public object Dispatch(string action, params object[] arguments) {
            return this.GetType().GetMethod(action).Invoke(this,arguments);
        }
    }
}
