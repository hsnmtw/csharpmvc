using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewWinform.Common {
    public interface ISingleForm {
        void PerformAction(string action);
        void UpdateModel();
    }
}
