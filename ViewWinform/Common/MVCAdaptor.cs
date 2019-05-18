using ControllerLibrary.Common;
using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ViewWinform.Common {
    class MVCAdaptor<C, M> where C : AbstractDBController<M> where M : BaseModel {
        public C Controller { get; private set; }
        private List<M> recordset { get; set; }

        public int Count {
            get;
            private set;
        }

        public M this[int index]{
            get {
                return this.recordset[index];
            }
        }

        public MVCAdaptor() {
            this.Controller = Activator.CreateInstance<C>();
        }

        public void Requery() {
            this.recordset = this.Controller.Read();
            this.Count = this.recordset.Count;
        }
    }
}
