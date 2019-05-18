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
        public virtual void Delete(object model) => this.BaseCollection.Delete(model);
        public virtual DataTable GetTable() => this.BaseCollection.GetTable();
        public virtual DataTable GetTable(object model, string[] whereFields) => this.BaseCollection.GetTable(model, whereFields);
        public virtual List<object> Read() => BaseCollection.Read();
        public virtual List<object> Read(object model, string[] whereFields) => BaseCollection.Read(model, whereFields);
        public virtual object Save(object _model) {
            var model = (BaseModel)_model;
            if (model.Id == 0) {
                model.Created_By = Session.Instance.CurrentUser==null ? "SYSTEM" : Session.Instance.CurrentUser.User_Name;
                model.Created_On = DateTime.Now;
            } else {
                model.Updated_By = Session.Instance.CurrentUser == null ? "SYSTEM" : Session.Instance.CurrentUser.User_Name;
                model.Updated_On = DateTime.Now;
            }
            return BaseCollection.Save(_model);
        }

        public MetaData GetMetaData() => this.BaseCollection.MetaData;
    }
}
