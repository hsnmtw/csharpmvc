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
using System.ComponentModel;
using System.Drawing;
using System.Threading;

namespace MVCHIS.Common {

    public class BaseView<M,C> : UserControl, IView where C:IDBController<M> where M:BaseModel  {
        [Browsable(false),EditorBrowsable(EditorBrowsableState.Never),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<bool> AfterSave { get; set; }
        [Browsable(false),EditorBrowsable(EditorBrowsableState.Never),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual C Controller { get; set; }
        [Browsable(false),EditorBrowsable(EditorBrowsableState.Never),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
                //Console.WriteLine("++++"+model);
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
                //Console.WriteLine("++++" + model);
                ModelChanged?.Invoke();
            }
        }

        private Func<string, bool> isDouble,isInt32,isInt64,isBoolean,isDateTime;
        private Func<string, PropertyInfo> Prop;

        private Dictionary<string, Control> mapper = new Dictionary<string, Control>();
        [Browsable(false),EditorBrowsable(EditorBrowsableState.Never),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, Control> Mapper => mapper;
        public Button SaveButton { get; set; }
        public Button NewButton { get; set; }
        public Button DeleteButton { get; set; }

        public bool   SaveButtonEnabled { get; set; }
        public bool    NewButtonEnabled { get; set; }
        public bool DeleteButtonEnabled { get; set; }
        [Browsable(false),EditorBrowsable(EditorBrowsableState.Never),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action ModelChanged { get; set; }
        public Control DefaultControl { get; set; }
        [Browsable(false),EditorBrowsable(EditorBrowsableState.Never),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<bool> AfterNew { get; set; }
        [Browsable(false),EditorBrowsable(EditorBrowsableState.Never),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<bool> AfterDelete { get; set; }

        public BaseView() : base() {
            Name = GetType().Name;
            if (DesignMode || (Site != null && Site.DesignMode)) return;

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
            Load += ViewLoadingEvent;
            
        }

        public void ViewLoadingEvent(object sender, EventArgs e) {
            if (DesignMode || (Site != null && Site.DesignMode)) return;
            Controller = (C)DBControllersFactory.GetController<M>();
            new Thread(delegate() {
                BeginInvoke((Action) delegate() { InitializeView(); });
            }).Start();
            new Thread(delegate() {
                LoadForeignKeys(ForeignKeys.Instance);
            }).Start();
        }

        private void InitializeView() {
            SuspendLayout();

            //Thread.Sleep(10);
            ForeignKeys.Instance.Put(Controller);

            var md = Controller.GetMetaData();
            var uqkeys = md.UniqueKeyFields.Flatten();
            var rqkeys = md.RequiredFields;
            var sizes  = md.Sizes;

            foreach(var cntrl in uqkeys.Where(x => Mapper.ContainsKey(x))) {
                Mapper[cntrl].BackColor = Color.FromArgb(192, 255, 192);
            }
            foreach(var cntrl in rqkeys.Where(x => Mapper.ContainsKey(x))) {
                Controls.Add(new Label() { Name = $"RQ_{cntrl}", Text = "*", ForeColor = Color.Red, Top = Mapper[cntrl].Top + 5, Left = Mapper[cntrl].Left - 15 });
            }
            foreach(var cntrl in sizes.Where(x => Mapper.ContainsKey(x.Key) && Mapper[x.Key] is TextBox)) {
                ((TextBox)Mapper[cntrl.Key]).MaxLength = cntrl.Value;
            }

            new PermissionsHelper<M, C>(this);
            if (SaveButton != null) {
                SaveButton.Enabled = SaveButtonEnabled;
                SaveButton.Click += SaveModelEvent;
            }
            if (DeleteButton != null) {
                DeleteButton.Enabled = DeleteButtonEnabled;
                DeleteButton.Click += DeleteModelEvent;
            }
            if (NewButton != null) {
                NewButton.Enabled = NewButtonEnabled;
                NewButton.Click += NewModelEvent;
            }
            //var controls = (from cntrl in Mapper.Values orderby cntrl.TabIndex where cntrl.TabStop select cntrl);
            
            foreach (string cntrl in Mapper.Keys) {
                Mapper[cntrl].Name = cntrl;
                Mapper[cntrl].KeyDown += MapperControlKeyDownEvent;
            }
            DefaultControl = Mapper.Values.Where(x => x.TabStop).OrderBy(x => x.TabIndex).FirstOrDefault();
            DefaultControl?.Focus();
            ResumeLayout();
            Invalidate();
        }



        private void SaveModelEvent(object sender, EventArgs e) {
            //try {
            int saveresult = Controller.Save(Model);
            if (saveresult > 0) Model = Controller.Find(Model, Controller.GetMetaData().UniqueKeyFields.FirstOrDefault().ToArray());
            AfterSave?.Invoke(saveresult > 0);
            try { } catch (Exception ex) {
                FormsHelper.Error(ex.Message);
            };
        }

        private void MapperControlKeyDownEvent(object sender, KeyEventArgs ee) {
            if (ee.KeyCode == Keys.Enter) {
                ee.Handled = true;
                ee.SuppressKeyPress = true;
                SendKeys.Send("\t");
            }
        }

        private void NewModelEvent(object sender, EventArgs e) {
            Model = Controller.NewModel();
            DefaultControl?.Select();
            AfterNew?.Invoke(true);
        }

        public void DeleteModelEvent(object sender, EventArgs e) {
            int deleteresult = Controller.Delete(Model);
            if (deleteresult > 0) NewButton?.PerformClick();
            AfterDelete?.Invoke(deleteresult > 0);
        }

        public void ValidateDate(TextBoxBase textbox) {
            if (DateTime.TryParse(textbox.Text, out DateTime date)) {
                textbox.Text = date.ToString(FormsHelper.DATE_FORMAT);
            } else {
                textbox.Text = "";
            }
        }

        public virtual void LoadForeignKeys(ForeignKeys FK) { }

        public void SetModel(BaseModel model) {
            Model = (M)model;// Controller.FindById<M>(new int[] { Model.Id }).FirstOrDefault();
        }
        [Browsable(false),EditorBrowsable(EditorBrowsableState.Never),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BaseModel GetModel() => Model;
    }
}
