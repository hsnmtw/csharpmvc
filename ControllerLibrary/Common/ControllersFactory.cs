using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {
    public static class ControllersFactory<M> where M:BaseModel {

        public static IDBController<M> CreateDBController(ControllersEnum dBControllersEnum){
            return null;
        }

        
    }
}
