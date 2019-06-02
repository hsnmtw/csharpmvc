using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using MVCHIS.Common;
using System.Data;
using System.Reflection;

namespace MVCHIS.Utils {
    public class ListViewControl : ListView {
        //[DllImportAttribute("uxtheme.dll")]
        //private static extern int SetWindowTheme(IntPtr hWnd, string appname, string idlist);

        //protected override void OnHandleCreated(EventArgs e) {
        //    SetWindowTheme(this.Handle, "", "");
        //    base.OnHandleCreated(e);
        //}

        public ListViewControl() {
            Font = new System.Drawing.Font("Consolas", 9F);
            FullRowSelect = true;
            GridLines = true;
            HideSelection = false;
            LabelWrap = false;
            MultiSelect = false;
            View = System.Windows.Forms.View.Details;
        }


        public int LoadingFKs = 0;
        public Action LoadFKCompleted;

        public static Dictionary<string, Dictionary<int, string>> FK = new Dictionary<string, Dictionary<int, string>>();
        public void LoadFKs(params string[] ShownColumns) {
            try {

                foreach (string key in ShownColumns.Where(x => x.EndsWith("Id") && x.Length > 2)) {
                    if (FK.Keys.Contains(key)) continue;
                    Interlocked.Exchange(ref LoadingFKs, 1); // lock
                    if (Enum.TryParse<MODELS>(key.Substring(0, key.Length - 2), out MODELS m)) {
                        IController Cntrl = (IController)DBControllersFactory.GetController(m);
                        var UniqueKeys = Cntrl.GetMetaData().UniqueKeyFields.ToArray().Concat(new string[] { "Id" }).ToArray();
                        var fkdata = new DataView(Cntrl.GetData()).ToTable(false, UniqueKeys);
                        FK[key] = new Dictionary<int, string>();
                        foreach (DataRow row in fkdata.Rows) {
                            FK[key][(int)row["Id"]] = string.Join(" | ", row.ItemArray );
                        }
                    }
                }
                Interlocked.Exchange(ref LoadingFKs, 0); //release lock
                
            } catch (Exception ex) {
                Console.WriteLine($"-LISTVIEW: LOOKUP ERROR: {ex.Message}");
            }
            LoadFKCompleted?.Invoke();
        }

        public void LoadData<M>(string filter, List<M> data, params string[] shownColumns) {
            BeginUpdate();
            if (data.Count == 0) {
                Items.Clear();
                return;
            }
            if (shownColumns == null || shownColumns.Length == 0) {
                shownColumns = (from PropertyInfo column in typeof(M).GetProperties() select column.Name).ToArray();
            }

            if (Columns.Count == 0) {
                Columns.AddRange((from c in shownColumns select new ColumnHeader(c) { Text = c.FromCamelCaseToWords() }).ToArray());
            }

            if (shownColumns.Where(x => x.Length > 2 && x.EndsWith("Id") && !FK.ContainsKey(x)).Count()>0) {
                LoadFKs(shownColumns);
            }

            Items.Clear();
            foreach (M row in data) {
                var row0 = typeof(M).GetProperty(shownColumns[0]).GetValue(row);
                var val = row0.ToString();
                if (FK.Keys.Contains(shownColumns[0])) {
                    val = FK[shownColumns[0]][(int)row0];
                }
                var item = new ListViewItem(val);
                for (int i = 1; i < shownColumns.Length; i++) {
                    var rowi = typeof(M).GetProperty(shownColumns[i]).GetValue(row);
                    val = rowi.ToString();

                    if (FK.Keys.Contains(shownColumns[i])) {
                        val = FK[shownColumns[i]][(int)rowi];
                    }
                    item.SubItems.Add(val);

                }
                if ((item + ":" + string.Join("|", item.SubItems.OfType<ListViewItem.ListViewSubItem>().Select(x => x.Text))).ToLower().Contains(filter.ToLower())) {
                    Items.Add(item);
                }

            }
            AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            if (Columns.Count > 0) {
                Columns[Columns.Count - 1].Width -= 5;
            }
            if (Items.Count > 0) {
                Items[0].Selected = true;
                Select();
                Focus();
            }
            EndUpdate();
        }

        public void LoadData(string filter,DataTable data,params string[] shownColumns) {
            BeginUpdate();
            if (data.Rows.Count == 0) {
                Items.Clear();
                return;
            }
            if (shownColumns == null || shownColumns.Length == 0) {
                shownColumns = (from DataColumn column in data.Columns select column.ColumnName).ToArray();
            }
            if (Columns.Count == 0) {
                Columns.AddRange((from c in shownColumns select new ColumnHeader(c) { Text = c.FromCamelCaseToWords() }).ToArray());
            }

            if (shownColumns.Where(x => x.Length > 2 && x.EndsWith("Id") && !FK.ContainsKey(x)).Count() > 0) {
                LoadFKs(shownColumns);
            }

            var view = new DataView(data);

            var table = view.ToTable(false, shownColumns);
            Items.Clear();
            foreach (DataRow row in table.Rows) {
                var val = row[0].ToString();
                if (FK.Keys.Contains(shownColumns[0])) {
                    val = FK[shownColumns[0]][(int)row[0]];
                }
                var item = new ListViewItem(val);
                for (int i = 1; i < shownColumns.Length; i++) {
                    val = row[i].ToString();

                    if (FK.Keys.Contains(shownColumns[i])) {
                        val = FK[shownColumns[i]][(int)row[i]];
                    }
                    item.SubItems.Add(val);
                    
                }
                if((item+":"+string.Join("|", item.SubItems.OfType<ListViewItem.ListViewSubItem>().Select(x => x.Text))).ToLower().Contains(filter.ToLower())) {
                    Items.Add(item);
                }
                
            }
            AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            if (Columns.Count > 0) {
                Columns[Columns.Count - 1].Width -= 5;
            }
            if (Items.Count > 0) {
                Items[0].Selected = true;
                Select();
                Focus();
            }
            EndUpdate();
        }


    }
}
