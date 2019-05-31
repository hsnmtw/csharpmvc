using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCHIS.Common {
    public class BaseForm : UserControl, IForm {
        public IBinder<BaseModel> Binder  {get;set;}
        public Control DefaultControl {get;set;}
    }
}
