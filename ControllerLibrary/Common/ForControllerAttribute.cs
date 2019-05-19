using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {
    [AttributeUsage(AttributeTargets.Class)]
    public class ForControllerAttribute : Attribute {
        public ControllersEnum ControllersEnum { get; set; }
        public bool Enabled { get; set; }
        public ForControllerAttribute(ControllersEnum controllersEnum) : base() {
            this.ControllersEnum = controllersEnum;
        }
    }
}
