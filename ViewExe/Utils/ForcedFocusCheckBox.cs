using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Utils {
    public class ForcedFocusCheckBox : System.Windows.Forms.CheckBox {
        protected override bool ShowFocusCues {
            get { return true; }
        }
    }
}
