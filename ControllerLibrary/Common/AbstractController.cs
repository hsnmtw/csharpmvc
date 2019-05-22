using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ControllerLibrary.Common {
    public class AbstractController : BaseController {
        private BaseCollection BaseCollection { get; set; }
        private AbstractController() { }
        public AbstractController(BaseCollection baseCollection) {
            if (baseCollection == null) throw new ArgumentNullException("baseCollection");
            this.BaseCollection = baseCollection;
        }
        public virtual object CreateNewModel() => this.BaseCollection.CreateNew();
        public virtual DBModificationResult Delete(object model) => this.BaseCollection.Delete(model);
        public virtual DataTable GetTable() => GetTable(new object(),new string[] { });
        public virtual DataTable GetTable(object model, string[] whereFields,bool like=false) => this.BaseCollection.GetTable(model, whereFields,like);
        public virtual ResultSet GetTable(object model, string[] whereFields,bool like,int offset, int length) => this.BaseCollection.GetTable(model, whereFields,like,offset,length);
        public virtual List<object> Read() => BaseCollection.Read();
        public virtual List<object> Read(object model, params string[] whereFields) => BaseCollection.Read(model, whereFields);
        public virtual DBModificationResult Save(object anyModel) {
            var model = (BaseModel)anyModel;
            if (model.Id == 0) {
                model.CreatedBy = Session.Instance.CurrentUser==null ? "SYSTEM" : Session.Instance.CurrentUser.UserName;
                model.CreatedOn = DateTime.Now;
            } else {
                model.UpdatedBy = Session.Instance.CurrentUser == null ? "SYSTEM" : Session.Instance.CurrentUser.UserName;
                model.UpdatedOn = DateTime.Now;
            }
            return BaseCollection.Save(model);
        }

        public MetaData GetMetaData() => this.BaseCollection.MetaData;

        public object Dispatch(string action, params object[] arguments) {
            return this.GetType().GetMethod(action).Invoke(this,arguments);
        }
    }
}
