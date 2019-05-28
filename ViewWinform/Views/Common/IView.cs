using MVCWinform.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinform.Common {
    public interface IView {
        Action AfterSave     { get; set; }
        Action ModelChanged { get; set; }
        Dictionary<string, Control> Mapper { get; set; }
        Dictionary<string, IDBController> Controllers { get; set; }
        Button SaveButton { get; set; }
        Button NewButton { get; set; }
        Button DeleteButton { get; set; }
    }
}
