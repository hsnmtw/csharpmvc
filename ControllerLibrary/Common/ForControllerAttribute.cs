using ModelLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {
    [AttributeUsage(AttributeTargets.Class)]
    public class ForControllerAttribute : Attribute {
        public Entities ControllersEnum { get; set; }
        public bool Enabled { get; set; }
        public ForControllerAttribute(Entities controllersEnum) : base() {
            this.ControllersEnum = controllersEnum;
        }
    }
}
