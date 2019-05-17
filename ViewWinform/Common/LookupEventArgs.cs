using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewWinform.Common {
    class LookupEventArgs : EventArgs {
        public string SelectedValueFromLookup { get; set; }
        public LookupEventArgs(string svfl) {
            this.SelectedValueFromLookup = svfl;
        }
    }
}
