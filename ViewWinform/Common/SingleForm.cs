using ControllerLibrary.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewWinform.Utils;

namespace ViewWinform.Common {
    public class SingleForm : Form, ISingleForm {

        public SingleForm() {
            this.Load += (s, e) => {
                if (DictionaryController.LanguageState == LanguageState.Arabic) {
                    this.RightToLeft = RightToLeft.Yes;
                    FormsHelper.ApplyLanguageLocalization(this);
                }
            };
        }

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
