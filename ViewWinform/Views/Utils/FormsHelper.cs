using MVCWinform.Common;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MVCWinform.Utils {
    public class FormsHelper
    {
        public const string ARROW = "↓";
        public const string CALENDAR = "📅";

        public static void Error(string message)
        {
            MessageBox.Show(message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void Success(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ApplyLanguageLocalization(Control cntrl) {
            
            if (cntrl == null) return;
            var form = cntrl;
            int i = 10;
            while (--i > 0 && (form != null) && !(form is Form)) {
                form = form.Parent;
            }
            
            form.Text = MainView.Instance.dictionaryController[form.Text];
            if(form!=cntrl) cntrl.Text = MainView.Instance.dictionaryController[cntrl.Text];

            var languageEnabledTypes = new Type[]{
                typeof(Label),
                typeof(Button),
                typeof(CheckBox),
                typeof(RadioButton),
                typeof(MenuStrip),
                typeof(Panel),
                typeof(GroupBox)
            };

            foreach (Control control in cntrl.Controls) {
                if (languageEnabledTypes.Contains(control.GetType())) {
                    control.Text = MainView.Instance.dictionaryController[control.Text];
                    if (control.GetType().Equals(typeof(Panel))) {
                        foreach (var pcontrol in control.Controls.OfType<Label>()) {
                            pcontrol.Text = MainView.Instance.dictionaryController[pcontrol.Text];
                        }
                    }
                    else if (control.GetType().Equals(typeof(GroupBox))) {
                        foreach (var pcontrol in control.Controls.OfType<Label>()) {
                            pcontrol.Text = MainView.Instance.dictionaryController[pcontrol.Text];
                        }
                    }
                    else if (control.GetType().Equals(typeof(MenuStrip))) {
                        foreach(var menu in ((MenuStrip)control).Items.OfType<ToolStripMenuItem>()) {
                            menu.Text = MainView.Instance.dictionaryController[menu.Text];
                            foreach(var cmenu in menu.DropDownItems.OfType<ToolStripMenuItem>()) {
                                cmenu.Text = MainView.Instance.dictionaryController[cmenu.Text];
                            }
                        }
                    }
                }
            }
        }

        private static void BindViewToModel<M>(Control cntrl,ref M model)
        {
            //return;

            if (cntrl == null) return;
            var form = cntrl;
            int i = 10;
            while (--i > 0 && (form != null) && !(form is Form)) {
                form = form.Parent;
            }
            var modeltype = form.GetType().GetProperty("Model").PropertyType; //= model.GetType();
            var allowedTypes = new Type[] {
                typeof(MaskedTextBox),
                typeof(TextBox),
                typeof(ComboBox),
                typeof(CheckBox)
            };

            string[] buttons = { "btnSave","btnNew","btnDelete" };



            foreach (Control control in cntrl.Controls)
            {

                if (control.GetType().Equals(typeof(Button)) && control.Text.Equals(CALENDAR) ) {
                    string txt = $"{control.Tag}";
                    control.Click += (s,e) => {
                        var calendar = new Tools.CalendarForm() {  };
                        if (calendar.ShowDialog() == DialogResult.OK) {
                            if (txt.Length > 0) {
                                Control box = cntrl.Controls.Find(txt, true).First();
                                string format = ConfigLoader.CultureInfoDateTimeFormatShortDatePattern;
                                if(box.Tag != null && box.Tag.ToString().Contains("DateFormat:")) {
                                    format = box.Tag.ToString().Replace("DateFormat:","");
                                }
                                box.Text = calendar.Date.ToString(format);
                            }
                        }
                    };
                }
                if (buttons.Contains(control.Name)) {
                    FormsHelper.Error("29837:error");
                    //((ISingleForm)form).UpdateModel();
                    switch (control.Name) {
                        case "btnNew":  control.Click += (s, e) => {
                                form.GetType().GetProperty("Model").SetValue(form,Activator.CreateInstance(modeltype));
                                //successMessage("NEW");
                            };
                            break;
                        case "btnSave":
                            control.Click += (s, e) => {
                                var Controller = (IDBController)form.GetType().GetField("Controller").GetValue(form);
                                var ModelProp  = form.GetType().GetProperty("Model");
                                var m = (BaseModel)ModelProp.GetValue(form);
                                Controller.Save(m);
                      //          var mdl = Controller.NewModel();
                                //var idp = mdl.GetType().GetProperty("Id");
                                //idp.SetValue(mdl, idp.GetValue(m));
                                //var saved = Controller.Find(mdl, "Id");
                                //ModelProp.SetValue(form, saved);
                                //MainView.Instance.setProgress("Saved Successfully", 0);
                            };
                            break;
                        case "btnDelete":
                            control.Click += (s, e) => {
                                var Controller = (IDBController)form.GetType().GetField("Controller").GetValue(form);
                                var mprop = form.GetType().GetProperty("Model");
                                Controller.Delete((BaseModel)mprop.GetValue(form));
                                mprop.SetValue(form, Activator.CreateInstance(mprop.PropertyType));
                                MainView.Instance.setProgress("Deleted Successfully", 0);
                            };
                            break;
                        case "btnDuplicate":
                            control.Click += (s, e) => {
                                try {

                                    var fmodel = (BaseModel)form.GetType().GetProperty("Model").GetValue(form);
                                    fmodel.Id = 0;
                                    fmodel.CreatedBy = null;
                                    fmodel.CreatedOn = null;
                                    fmodel.UpdatedBy = null;
                                    fmodel.UpdatedOn = null;

                                    form.GetType().GetProperty("Model").SetValue(form, fmodel);
                                } catch { }
                            };
                            break;
                    }
                }
                else if (allowedTypes.Contains(control.GetType()))
                {
                    if (control.GetType().Equals(typeof(TextBox))) {
                        control.LostFocus += (s, e) => control.Text = control.Text.Trim();
                        if (((TextBox)control).ReadOnly) {
                            control.KeyDown += (s, e) => {
                                if (e.KeyCode == Keys.Back) {
                                    control.Text = "";
                                    e.Handled = true;
                                    e.SuppressKeyPress = true;
                                }
                            };
                        }
                    }
                    if (control.GetType().Equals(typeof(TextBox)) && ((TextBox)control).Multiline) {
                        continue;
                    }

                    control.KeyDown += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            e.SuppressKeyPress = true;
                            e.Handled = true;
                            SendKeys.Send("\t");
                        }
                    };
                }
            }
        }

        private static M PopulateModelFromControls<M>(M model, Control container) {
            //if(model == null || container==null)return model;

            PropertyInfo[] properties = model.GetType().GetProperties();
            MemberInfo[] members = container.GetType().GetMembers();

            for (int i = 0; i < properties.Length; i++) {
                string prop = properties[i].Name;
                var chk = container.Controls.Find($"chk{prop}", true).OfType<CheckBox>();
                var txt = container.Controls.Find($"txt{prop}", true).OfType<TextBox>();
                var cmb = container.Controls.Find($"cmb{prop}", true).OfType<ComboBox>();

                if (txt.Count() > 0) {
                    if (properties[i].PropertyType.Equals(typeof(string))) {
                        properties[i].SetValue(model, txt.First().Text);
                    }
                    else if (properties[i].PropertyType.Equals(typeof(int))) {
                        properties[i].SetValue(model, int.Parse($"0{txt.First().Text}"));
                    }
                    else if (properties[i].PropertyType.Equals(typeof(DateTime))) {
                        properties[i].SetValue(model, DateTime.Parse(txt.First().Text));
                    }
                    else if (properties[i].PropertyType.Equals(typeof(DateTime?))) {
                        if (txt.First().Text.Trim().Length == 0) {
                            properties[i].SetValue(model, null);
                        } else {
                            properties[i].SetValue(model, DateTime.Parse(txt.First().Text));
                        }
                    }
                } 
                else if(chk.Count() > 0) {
                    properties[i].SetValue(model, chk.First().Checked);
                } 
                else if (cmb.Count() > 0) {
                    properties[i].SetValue(model, cmb.First().Text);
                }
            }
            return model;
        }

        private static void PopulateControlsFromModel(object model, Control container) {
            //if(model == null)return;

            PropertyInfo[] properties = model.GetType().GetProperties();
            MemberInfo[] members = container.GetType().GetMembers();

            for (int i = 0; i < properties.Length; i++) {
                string prop = properties[i].Name;
                var chk = container.Controls.Find($"chk{prop}", true).OfType<CheckBox>();
                var txt = container.Controls.Find($"txt{prop}", true).OfType<TextBox>();
                var cmb = container.Controls.Find($"cmb{prop}", true).OfType<ComboBox>();

                if (chk.Count() > 0) {
                    chk.First().Checked = (bool)properties[i].GetValue(model);
                }
                else if (txt.Count() > 0) {
                    if (properties[i].PropertyType.Equals(typeof(DateTime?)) || properties[i].PropertyType.Equals(typeof(DateTime))) {

                        TextBox box = txt.First();
                        if (box.Tag != null && box.Tag.ToString().Contains("DateFormat:")) {
                            string format = box.Tag.ToString().Replace("DateFormat:", "").Trim();
                            object dvalue = properties[i].GetValue(model);
                            box.Text = dvalue==null? "" : ((DateTime)dvalue).ToString(format);
                        } else {
                            box.Text = $"{properties[i].GetValue(model)}";
                        }

                    } else {
                        txt.First().Text = $"{properties[i].GetValue(model)}";
                    }
                } 
                else if (cmb.Count() > 0) {
                    cmb.First().Text = $"{properties[i].GetValue(model)}";
                }
            }
        }
    }
}
