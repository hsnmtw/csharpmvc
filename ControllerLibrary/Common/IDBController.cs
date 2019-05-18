using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ModelLibrary.Common;
using ModelLibrary.Common;
using ControllerLibrary.Security;
using ModelLibrary.Security;
using System.Reflection;

namespace ControllerLibrary.Common {

    public interface IDBController<M> : BaseController where M : BaseModel {        
        DataTable GetTable(M model, string[] whereFields);
        List<M> Read();
        List<M> Read(M model, string[] whereFields);
        M Save(M model);
        void Delete(M model);
    }
}