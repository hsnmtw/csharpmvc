using MVCHIS.Security;
using System;
using System.Data;

namespace MVCHIS.Common {
    class MVCAdaptor<C> where C : IDBController {
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
            Controller = Activator.CreateInstance<C>();
        }

        public void Requery() {
            recordset = Controller.GetData<AuditModel>();
            Count = recordset.Rows.Count;
        }
    }
}
