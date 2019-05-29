using MVCHIS;
using MVCHIS.Billing;
using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Common {

    public class BaseView<M,C> : Form, IView where M:BaseModel where C:IDBController {

        public Action AfterSave { get; set; }
        public virtual C Controller { get; set; } 
        private M model;
        public virtual M Model {
            get {
                if (model == null) { model = Activator.CreateInstance<M>(); }
                foreach (var x in Mapper.Keys) {
                    string text = Mapper[x].Text;
                    Mapper[x].Text = text.Trim();
                         if (isBoolean(x))  Prop(x).SetValue(model, ((CheckBox)Mapper[x]).Checked);
                    else if (isDateTime(x)) Prop(x).SetValue(model, text.Equals("") ? default(DateTime?) : Convert.ToDateTime(text));
                    else if (isDouble(x))   Prop(x).SetValue(model, Convert.ToDouble($"0{text}"));
                    else if (isInt32(x))    Prop(x).SetValue(model, Convert.ToInt32($"0{text}"));
                    else if (isInt64(x))    Prop(x).SetValue(model, Convert.ToInt64($"0{text}"));
                    else Prop(x).SetValue(model, text);
                }
                return model;
            }
            set {
                if (value == null) { model = Activator.CreateInstance<M>(); } else { model = value; }
                foreach (var x in Mapper.Keys) {
                    if (isBoolean(x)) {
                        ((CheckBox)Mapper[x]).Checked = Convert.ToBoolean(Prop(x).GetValue(model));
                    } else if (isDateTime(x)) {
                        var date = Prop(x).GetValue(model);
                        if (date == null) {
                            Mapper[x].Text = "";
                        } else {
                            var dateFormat = (x.Contains("On") ? $"{FormsHelper.DATE_FORMAT} {FormsHelper.TIME_FORMAT}" : (x.Contains("Time")? FormsHelper.TIME_FORMAT : FormsHelper.DATE_FORMAT));
                            Mapper[x].Text = ((DateTime)Prop(x).GetValue(model)).ToString($"{Mapper[x].Tag}".Equals("") ? dateFormat : $"{Mapper[x].Tag}");
                        }
                    } else {
                        Mapper[x].Text = Convert.ToString(Prop(x).GetValue(model));
                    }
                }
                ModelChanged?.Invoke();
            }
        }

        private readonly Func<string, bool> isDouble,isInt32,isInt64,isBoolean,isDateTime;
        private readonly Func<string, PropertyInfo> Prop;

        
        public Dictionary<string, Control> Mapper { get; set; }
        public Dictionary<string, IDBController> Controllers { get; set; }
        public Button SaveButton { get; set; }
        public Button NewButton { get; set; }
        public Button DeleteButton { get; set; }

        public bool   SaveButtonEnabled { get; set; }
        public bool    NewButtonEnabled { get; set; }
        public bool DeleteButtonEnabled { get; set; }

        public Action ModelChanged { get; set; }

        public BaseView() : base() {
            
            MdiParent = MainView.Instance;
            Controllers = new Dictionary<string, IDBController>();
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
                new PermissionsHelper<M, C>(this);
                if (SaveButton != null) {
                    SaveButton.Enabled = SaveButtonEnabled;
                    SaveButton.Click += (bs, be) => {
                        Controller.Save(Model);
                        Model = Controller.Find(Model, Controller.GetMetaData().GetUniqueKeyFields);
                        AfterSave?.Invoke();
                    };
                }
                if (DeleteButton != null) {
                    DeleteButton.Enabled = DeleteButtonEnabled;
                    DeleteButton.Click += (bs, be) => { Controller.Delete(Model); NewButton?.PerformClick(); };
                }
                if (NewButton != null) {
                    NewButton.Enabled = NewButtonEnabled;
                    NewButton.Click += (bs, be) => { Model = Controller.NewModel<M>(); };
                }
            };

        }

        public void ValidateDate(TextBoxBase textbox) {
            if (DateTime.TryParse(textbox.Text, out DateTime date)) {
                textbox.Text = date.ToString(FormsHelper.DATE_FORMAT);
            } else {
                textbox.Text = "";
            }
        }

    }
}
