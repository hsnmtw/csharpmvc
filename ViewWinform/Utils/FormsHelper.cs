using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Customers;
using ViewWinform.Common;
using ViewWinform.Customers;

namespace ViewWinform.Utils
{
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

        public static Form showView(Form owner,UserControl userControl)
        {
            var form = new Form() { MdiParent = owner, Text = userControl.Name };
            form.Controls.Add(userControl);
            form.Show();
            form.Size = new System.Drawing.Size(userControl.Width+20,userControl.Height+20);
            userControl.Dock = DockStyle.Fill;
            //form.WindowState = FormWindowState.Maximized;
            return form;
        }

        

        public static void BindViewToModel<M>(Control cntrl,ref M model)
        {
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

            string[] buttons = { "btnSave","btnNew","btnRemove" };

            foreach (Control control in cntrl.Controls)
            {
                if (control.GetType().Equals(typeof(Button)) && control.Text.Equals(CALENDAR) ) {
                    string[] txt = $"{control.Tag}".Split('/');
                    control.Click += (s,e) => {
                        var calendar = new Tools.CalendarForm();
                        if (calendar.ShowDialog() == DialogResult.OK) {
                            if (txt.Length > 0) {
                                cntrl.Controls.Find(txt[0], true).First().Text = calendar.Date.ToString(ConfigLoader.CultureInfoDateTimeFormatShortDatePattern);
                                if (txt.Length > 1) {
                                    cntrl.Controls.Find(txt[1], true).First().Text = calendar.Date.ToString(ConfigLoader.CultureInfoDateTimeFormatLongDatePattern);
                                }
                            }
                        }
                    };
                }
                if (buttons.Contains(control.Name)) {
                    
                    ((ISingleForm)form).UpdateModel();
                    switch (control.Name) {
                        case "btnNew":  control.Click += (s, e) => {
                                form.GetType().GetProperty("Model").SetValue(form,Activator.CreateInstance(modeltype));
                                //successMessage("NEW");
                            };
                            break;
                        case "btnSave":
                            control.Click += (s, e) => {
                                var Controller = (IDBController)form.GetType().GetField("Controller").GetValue(form);
                                var Model      = form.GetType().GetProperty("Model");
                                ModelLibrary.Common.DBModificationResult result = Controller.Save(Model.GetValue(form));
                                //Utils.FormsHelper.Success("SUCCESS ::: saved");
                                Model.SetValue(form, result.Result);
                                //successMessage("SAVE");
                                MainView.Instance.setProgress("Saved Successfully", 100);
                            };
                            break;
                        case "btnRemove":
                            control.Click += (s, e) => {
                                var Controller = (IDBController)form.GetType().GetProperty("Controller").GetValue(form);
                                var Model = form.GetType().GetProperty("Model");
                                ModelLibrary.Common.DBModificationResult result = Controller.Delete(Model.GetValue(form));
                                //Utils.FormsHelper.Success("SUCCESS ::: deleted");
                                Model.SetValue(form, Activator.CreateInstance(Model.PropertyType));
                                //successMessage("NEW");
                                MainView.Instance.setProgress("Deleted Successfully", 100);
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

        internal static M PopulateModelFromControls<M>(M model, Control container) {
            PropertyInfo[] properties = model.GetType().GetProperties();
            MemberInfo[] members = container.GetType().GetMembers();

            for (int i = 0; i < properties.Length; i++) {
                string prop = properties[i].Name;
                var chk = container.Controls.Find($"chk{prop}", true).OfType<CheckBox>();
                var txt = container.Controls.Find($"txt{prop}", true).OfType<TextBox>();

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
            }
            return model;
        }

        internal static void PopulateControlsFromModel(object model, Control container) {
            PropertyInfo[] properties = model.GetType().GetProperties();
            MemberInfo[] members = container.GetType().GetMembers();

            for (int i = 0; i < properties.Length; i++) {
                string prop = properties[i].Name;
                var chk = container.Controls.Find($"chk{prop}", true).OfType<CheckBox>();
                var txt = container.Controls.Find($"txt{prop}", true).OfType<TextBox>();

                if (chk.Count() > 0) {
                    chk.First().Checked = (bool)properties[i].GetValue(model);
                }
                else if (txt.Count() > 0) {
                    txt.First().Text = $"{properties[i].GetValue(model)}";
                }
            }
        }
    }
}
