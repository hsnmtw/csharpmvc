using ControllerLibrary.Common;
using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ViewWinform.Common {
    class MVCAdaptor<C, M> where C : AbstractController<M> where M : BaseModel {
        public C Controller { get; private set; }
        private Recordset<M> recordset { get; set; }
        private List<M> Models { get; set; }

        private System.Data.IDataParameter[] filters = { };

        private string[] filterfield;
        private M filterModel;

        public int Count {
            get;
            private set;
        }

        public M this[int index]{
            get {
                if (index < 0 || this.Models == null || Count == 0 || index >= Count) return null;
                for(int i = this.Models.Count-1; i < index && recordset.MoveNext(); i++) {
                    this.Models.Add(recordset.Current);
                }
                return this.Models[index];
            }
        }

        public MVCAdaptor() {
            this.Controller = Activator.CreateInstance<C>();
        }

        public MVCAdaptor(string[] fields, M model) {
            this.Controller = Activator.CreateInstance<C>();
            this.filterfield = fields;
            this.filterModel = model;
        }

        public void Requery() {

            this.recordset = this.Controller.getRecordset(this.Controller.getParameters(this.filterfield, this.filterModel));
            this.Models = new List<M>();
            this.Count = this.Controller.count(this.Controller.getParameters(this.filterfield, this.filterModel));
        }
    }
}
