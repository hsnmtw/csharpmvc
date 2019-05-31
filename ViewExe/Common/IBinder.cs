using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCHIS.Common {
    public interface IBinder<M> {
        M Model { get; set; }
        IDBController Controller { get; set; }
        Action AfterSave     { get; set; }
        Action ModelChanged { get; set; }
        Dictionary<string, Control> Mapper { get; set; }
        Dictionary<string, IDBController> Controllers { get; set; }
        Button SaveButton { get; set; }
        Button NewButton { get; set; }
        Button DeleteButton { get; set; }
        Control DefaultControl { get; set; }
        bool   SaveButtonEnabled { get; set; }
        bool    NewButtonEnabled { get; set; }
        bool DeleteButtonEnabled { get; set; }
        string ValidateDate(string text);
    }
}
