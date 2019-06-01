using MVCHIS.Security;
using System;
using System.Data;

namespace MVCHIS.Common {
    class MVCAdaptor<M,C> where C:IDBController<M> where M : BaseModel {
        public C Controller { get; private set; }
        private DataTable recordset { get; set; }

        public int Count {
            get;
            private set;
        }

        public DataRow this[int index]{
            get {
                return this.recordset.Rows[index];
            }
        }

        public MVCAdaptor() {
            Controller = (C)DBControllersFactory.GetController(typeof(C));
        }

        public void Requery() {
            recordset = Controller.GetData();
            Count = recordset.Rows.Count;
        }
    }
}
