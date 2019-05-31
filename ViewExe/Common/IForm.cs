using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCHIS.Common {
    public interface IForm {
        IBinder<BaseModel> Binder { get; set; }
        Control DefaultControl { get; set; }
    }
}
