using MVCWinform.Billing;
using MVCWinform.Common;
using MVCWinform.Customers;
using MVCWinform.Housing;
using MVCWinform.Security;
using MVCWinform.Tools;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace ViewWinform.Common {

    public class BaseView<M,C> : Form, IView where M:BaseModel where C:IDBController {

        public virtual C Controller { get; set; } 
        private M model;
        public virtual M Model {
            get {
                if (model == null) { model = Activator.CreateInstance<M>(); }
                foreach (var x in Mapper.Keys) {
                    string text = Mapper[x].Text;
                    Mapper[x].Text = text.Trim();
                    if (isBoolean(x)) Prop(x).SetValue(model, ((CheckBox)Mapper[x]).Checked);
                    else if (isDateTime(x)) Prop(x).SetValue(model, text.Equals("") ? default(DateTime?) : Convert.ToDateTime(text));
                    else if (isDouble(x)) Prop(x).SetValue(model, Convert.ToDouble($"0{text}"));
                    else if (isInt32(x)) Prop(x).SetValue(model, Convert.ToInt32($"0{text}"));
                    else if (isInt64(x)) Prop(x).SetValue(model, Convert.ToInt64($"0{text}"));
                    else Prop(x).SetValue(model, text);
                }
                return model;
            }
            set {
                if (value == null) { model = Activator.CreateInstance<M>(); } else { model = value; }
                foreach (var x in Mapper.Keys) {
                    Mapper[x].Text = Convert.ToString(Prop(x).GetValue(model));
                }
            }
        }

        private readonly Func<string, bool> isDouble,isInt32,isInt64,isBoolean,isDateTime;
        private readonly Func<string, PropertyInfo> Prop;

        public Dictionary<string, Control> Mapper { get; set; }
        public Button SaveButton { get; set; }
        public Button NewButton { get; set; }
        public Button DeleteButton { get; set; }

        public BaseView() : base() {
            Mapper = new Dictionary<string, Control>();
            Prop = new Func<string, PropertyInfo>(x => typeof(M).GetProperty(x));
            isBoolean  = new Func<string, bool>(x => Mapper[x].GetType() == typeof(CheckBox) 
                                                  && Prop(x).PropertyType == typeof(bool));
            isDateTime = new Func<string, bool>(x => Prop(x).PropertyType == typeof(DateTime) 
                                                  || Prop(x).PropertyType == typeof(DateTime?));
            isInt64    = new Func<string, bool>(x => Prop(x).PropertyType == typeof(Int64));
            isInt32    = new Func<string, bool>(x => Prop(x).PropertyType == typeof(Int32)
                                                  || Prop(x).PropertyType == typeof(int));
            isDouble   = new Func<string, bool>(x => Prop(x).PropertyType == typeof(double)
                                                  || Prop(x).PropertyType == typeof(Double));

            Load += (s, e) => {
                if (SaveButton != null)   SaveButton.Click   += (bs, be) => { Controller.Save(Model); Model = Controller.Find(Model, Controller.GetMetaData().GetUniqueKeyFields); };
                if (DeleteButton != null) DeleteButton.Click += (bs, be) => { Controller.Delete(Model); NewButton?.PerformClick(); };
                if (NewButton != null)    NewButton.Click    += (bs, be) => { Model = Controller.NewModel<M>(); };
            };

        }


    }
}
