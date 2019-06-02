using MVCHIS;
using MVCHIS.Billing;
using MVCHIS.Common;
using MVCHIS.Customers;
using MVCHIS.Housing;
using MVCHIS.Security;
using MVCHIS.Tools;
using MVCHIS.Utils;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MVCHIS.Common {

    public class BaseView<M,C> : UserControl, IView where C:IDBController<M> where M:BaseModel  {

        public Action AfterSave { get; set; }
        public virtual C Controller { get; set; } 
        public virtual M Model {
            get {
                if (Controller == null) return null;
                M getmodel = Controller.NewModel();
                foreach (var x in Mapper.Keys) {
                    string text = Mapper[x].Text;
                    Mapper[x].Text = text.Trim();
                         if (isBoolean(x))  Prop(x).SetValue(getmodel, ((CheckBox)Mapper[x]).Checked);
                    else if (isDateTime(x)) Prop(x).SetValue(getmodel, text.Equals("") ? default(DateTime?) : Convert.ToDateTime(text));
                    else if (isDouble(x))   Prop(x).SetValue(getmodel, Convert.ToDouble($"0{text}"));
                    else if (isInt32(x))    Prop(x).SetValue(getmodel, Convert.ToInt32($"0{text}"));
                    else if (isInt64(x))    Prop(x).SetValue(getmodel, Convert.ToInt64($"0{text}"));
                    else Prop(x).SetValue(getmodel, text);
                }
                return getmodel;
            }
            set {
                M model;
                if (value == null && Controller!=null) { model = Controller.NewModel(); } else { model = value; }
                //model = value;
                Console.WriteLine("++++"+model);
                foreach (var x in Mapper.Keys) {
                    if (isBoolean(x)) {
                        ((CheckBox)Mapper[x]).Checked = Convert.ToBoolean(Prop(x).GetValue(model));
                    } else if (isDateTime(x)) {
                        var date = Prop(x).GetValue(model);
                        if (date == null || ((DateTime)date).Equals(new DateTime(1, 1, 1))) {
                            Mapper[x].Text = "";
                        } else {
                            var dateFormat = (x.Contains("On") ? $"{FormsHelper.DATE_FORMAT} {FormsHelper.TIME_FORMAT}" : (x.Contains("Time") ? FormsHelper.TIME_FORMAT : FormsHelper.DATE_FORMAT));
                            Mapper[x].Text = ((DateTime)Prop(x).GetValue(model)).ToString($"{Mapper[x].Tag}".Equals("") ? dateFormat : $"{Mapper[x].Tag}");
                        }
                    } else if(isDouble(x)){
                        Mapper[x].Text = ((double)Prop(x).GetValue(model)).ToString("0.00");
                    } else {
                        var val = Prop(x).GetValue(model);
                        if (x.EndsWith("Id") && "0".Equals($"{val}")) Mapper[x].Text = "";
                        else Mapper[x].Text = Convert.ToString(val);
                    }
                }
                Console.WriteLine("++++" + model);
                ModelChanged?.Invoke();
            }
        }

        private readonly Func<string, bool> isDouble,isInt32,isInt64,isBoolean,isDateTime;
        private readonly Func<string, PropertyInfo> Prop;

        
        public Dictionary<string, Control> Mapper { get; set; }
        public Button SaveButton { get; set; }
        public Button NewButton { get; set; }
        public Button DeleteButton { get; set; }

        public bool   SaveButtonEnabled { get; set; }
        public bool    NewButtonEnabled { get; set; }
        public bool DeleteButtonEnabled { get; set; }

        public Action ModelChanged { get; set; }
        public Control DefaultControl { get; set; }
        public Action AfterNew { get; set; }
        public Action AfterDelete { get; set; }

        public BaseView() : base() {
           
            
            Name = GetType().Name;
            if (DesignMode||(Site!=null && Site.DesignMode)) return;

            Mapper = new Dictionary<string, Control>();
            Prop = new Func<string, PropertyInfo>(x => typeof(M).GetProperty(x));
            isBoolean  = new Func<string, bool>(x => (Mapper[x] is CheckBox )
                                                  && Prop(x).PropertyType == typeof(bool));
            isDateTime = new Func<string, bool>(x => Prop(x).PropertyType == typeof(DateTime) 
                                                  || Prop(x).PropertyType == typeof(DateTime?));
            isInt64    = new Func<string, bool>(x => Prop(x).PropertyType == typeof(Int64));
            isInt32    = new Func<string, bool>(x => Prop(x).PropertyType == typeof(Int32)
                                                  || Prop(x).PropertyType == typeof(int));
            isDouble   = new Func<string, bool>(x => Prop(x).PropertyType == typeof(double)
                                                  || Prop(x).PropertyType == typeof(Double));

            //model = Activator.CreateInstance<M>();
            Load += (s, e) => {
                if (DesignMode) return;
                Controller = (C)DBControllersFactory.GetController<M>();
                new PermissionsHelper<M,C>(this);
                if (SaveButton != null) {
                    SaveButton.Enabled = SaveButtonEnabled;
                    SaveButton.Click += (bs, be) => {
                        //try {
                            Controller.Save(Model);
                            Model = Controller.Find(Model, Controller.GetMetaData().UniqueKeyFields.ToArray());
                            AfterSave?.Invoke();
                        try{}catch(Exception ex) {
                            FormsHelper.Error(ex.Message);
                        }
                    };
                }
                if (DeleteButton != null) {
                    DeleteButton.Enabled = DeleteButtonEnabled;
                    DeleteButton.Click += (bs, be) => { Controller.Delete(Model); NewButton?.PerformClick(); AfterDelete?.Invoke(); };
                }
                if (NewButton != null) {
                    NewButton.Enabled = NewButtonEnabled;
                    NewButton.Click += (bs, be) => { Model = Controller.NewModel(); DefaultControl?.Select(); AfterNew?.Invoke(); };
                }
                var controls = (from cntrl in Mapper.Values orderby cntrl.TabIndex where cntrl.TabStop select cntrl);
                foreach(var cntrl in controls) {
                    cntrl.KeyDown += (se, ee) => {
                        if(ee.KeyCode == Keys.Enter) {
                            ee.Handled = true;
                            ee.SuppressKeyPress = true;
                            SendKeys.Send("\t");
                        }
                    };
                }
                DefaultControl = controls.FirstOrDefault();
                DefaultControl?.Focus();
            };

        }

        public void ValidateDate(TextBoxBase textbox) {
            if (DateTime.TryParse(textbox.Text, out DateTime date)) {
                textbox.Text = date.ToString(FormsHelper.DATE_FORMAT);
            } else {
                textbox.Text = "";
            }
        }

        public void SetModel(BaseModel model) {
            Model = (M)model;// Controller.FindById<M>(new int[] { Model.Id }).FirstOrDefault();
        }

        public BaseModel GetModel() => Model;
    }
}
