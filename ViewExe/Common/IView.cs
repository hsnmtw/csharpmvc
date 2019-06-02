﻿using MVCHIS.Common;
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
        Dictionary<string, Control> Mapper { get; set; }
        Button SaveButton { get; set; }
        Button NewButton { get; set; }
        Button DeleteButton { get; set; }

        bool   SaveButtonEnabled { get; set; }
        bool    NewButtonEnabled { get; set; }
        bool DeleteButtonEnabled { get; set; }
        void SetModel(BaseModel model);
        BaseModel GetModel();
        Control DefaultControl { get; set; }
    }
}
