using System;
using System.Data;

namespace MVCWinform.Common {
    class MVCAdaptor<C> where C : AbstractDBController {
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
            this.Controller = Activator.CreateInstance<C>();
        }

        public void Requery() {
            this.recordset = this.Controller.ConvertToDataTable( this.Controller.Read() );
            this.Count = this.recordset.Rows.Count;
        }
    }
}
