using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Common {
    public class SingleForm : Form, ISingleForm {

        public void PerformAction(string action) {
            try {
                var buttons = this.Controls.Find($"btn{action}", true).OfType<Button>();
                if (buttons.Count() == 0) return;
                buttons.First().PerformClick();
            } catch { }
        }

        public virtual void UpdateModel() { } 
    }
}
