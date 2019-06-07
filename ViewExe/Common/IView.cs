using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCHIS.Common {
    public interface IView {
        Action<bool> AfterSave     { get; set; }
        Action<bool> AfterNew      { get; set; }
        Action<bool> AfterDelete   { get; set; }
        Action ModelChanged { get; set; }
        Dictionary<string, Control> Mapper { get; }
        Dictionary<PickListButton, TextBox> PickList { get; }
        Button SaveButton { get; set; }
        Button NewButton { get; set; }
        Button DeleteButton { get; set; }
        void SetSaveButtonEnabled  (bool Enabled);
        void SetNewButtonEnabled   (bool Enabled);
        void SetDeleteButtonEnabled(bool Enabled);
        void SetModel(BaseModel model);
        BaseModel GetModel();
        Control DefaultControl { get; set; }
        void SetModel(int id);
    }
}
