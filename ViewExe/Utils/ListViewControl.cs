﻿using MVCHIS.Common;
using MVCHIS.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCHIS.Utils {
    public class ListViewControl : ListView {
        //[DllImportAttribute("uxtheme.dll")]
        //private static extern int SetWindowTheme(IntPtr hWnd, string appname, string idlist);

        //protected override void OnHandleCreated(EventArgs e) {
        //    SetWindowTheme(this.Handle, "", "");
        //    base.OnHandleCreated(e);
        //}
        private List<object> theList;

        public string Filter { get; set; }

        public ListViewControl() {
            Font = new System.Drawing.Font("Consolas", 9F);
            FullRowSelect = true;
            GridLines = true;
            HideSelection = false;
            LabelWrap = false;
            MultiSelect = false;
            View = System.Windows.Forms.View.Details;
        }


        //public int LoadingFKs = 0;
        //public Action LoadFKCompleted;

        public static Dictionary<string, Dictionary<int, string>> FK = new Dictionary<string, Dictionary<int, string>>();
        //public void LoadFKs(params string[] ShownColumns) {
        //    try {

        //        var fks = ((IController)DBControllersFactory.GetController(ModelType)).GetMetaData().ForeignKeys;
        //        var CntrlET = DBControllersFactory.GetController<EntityModel>();

        //        foreach (string key in ShownColumns.Where(x => x.EndsWith("Id") && x.Length > 2)) {
        //            if (FK.Keys.Contains(key)) continue;
        //            Interlocked.Exchange(ref LoadingFKs, 1); // lock

        //            if (fks.ContainsKey(key)) {
        //                Enum.TryParse<MODELS>(key, out MODELS m);
        //                IController Cntrl = (IController)DBControllersFactory.GetController(m);
        //                var UniqueKeys = Cntrl.GetMetaData().UniqueKeyFields.Flatten().ToArray().Concat(new string[] { "Id" }).ToArray();
        //                var fkdata = new DataView(Cntrl.GetData()).ToTable(false, UniqueKeys);
        //                FK[key] = new Dictionary<int, string>();
        //                foreach (DataRow row in fkdata.Rows) {
        //                    FK[key][(int)row["Id"]] = string.Join(" | ", row.ItemArray );
        //                }
        //            }
        //        }
        //        Interlocked.Exchange(ref LoadingFKs, 0); //release lock
                
        //    } catch (Exception ex) {
        //        Console.WriteLine($"-LISTVIEW: LOOKUP ERROR: {ex.Message}");
        //    }
        //    LoadFKCompleted?.Invoke();
        //}

        internal void AddRowFromModel<M>(M model) {
            if (model == null) return;
            AddRowFromArray((from ColumnHeader c in Columns select typeof(M).GetProperty(c.Name).GetValue(model))?.ToArray());
        }

        public void AddRowFromArray(object[] cells) {
            var val = cells[0];
            if (FK.Keys.Contains(Columns[0].Name)) {
                val = FK[Columns[0].Name][int.Parse(val.ToString())];
            }
            var item = new ListViewItem(val.ToSortableString());
            for (int i = 1; i < Columns.Count; i++) {
                val = cells[i];
                if (FK.Keys.Contains(Columns[i].Name)) {
                    val = FK[Columns[i].Name][int.Parse(val.ToString())];
                }
                item.SubItems.Add(val.ToSortableString());

            }
            if ("".Equals(Filter)) {
                Items.Add(item);
            }
            else if ((item + ":" + string.Join("|", item.SubItems.OfType<ListViewItem.ListViewSubItem>().Select(x => x.Text))).ToLower().Contains(Filter.ToLower())) {
                Items.Add(item);
            }
        }


        public void LoadData<M>(string filter, IEnumerable<M> data, params string[] shownColumns) {
            Filter = filter;
            BeginUpdate();
            
            if (shownColumns == null || shownColumns.Length == 0) {
                shownColumns = (from PropertyInfo column in typeof(M).GetProperties() select column.Name).ToArray();
            }

            if (Columns.Count == 0) {
                LoadColumns(shownColumns);
            }

            //if (shownColumns.Where(x => x.Length > 2 && x.EndsWith("Id") && !FK.ContainsKey(x)).Count()>0) {
            //    LoadFKs(shownColumns);
            //}

            Items.Clear();
            foreach (M row in data) {
                AddRowFromModel(row);
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



        private void LoadColumns(params string[] columns) {

            for(int i = 0; i < columns.Length; i++) {
                string c = columns[i];
                string t = c;

                if (c.Length > 2 && c.EndsWith("Id")) t = c.Substring(0, c.Length - 2);
                if (c.Length > 2 && c.EndsWith("Code")) t = c.Substring(0, c.Length - 4);

                Columns.Add(new ColumnHeader() { Name=c, Text=t.FromCamelCaseToWords() });
            }

            //var colsi = from c in columns select (c.Length > 2 && c.EndsWith("Id")) ? c.Substring(0, c.Length - 2) : c;
            //var colsw = from c in colsi select (c.Length > 2 && c.EndsWith("Code")) ? c.Substring(0, c.Length - 4) : c;
            //Columns.AddRange((from c in colsw select new ColumnHeader() { Name = c,Text = c.FromCamelCaseToWords() }).ToArray());

            Utils.FormsHelper.ApplyLanguageLocalization(this);
        }

        public void LoadData(string filter,DataTable data,params string[] shownColumns) {
            Filter = filter;
            BeginUpdate();
            
            if (shownColumns == null || shownColumns.Length == 0) {
                shownColumns = (from DataColumn column in data.Columns select column.ColumnName).ToArray();
            }
            if (Columns.Count == 0) {
                LoadColumns(shownColumns);
            }

            //if (shownColumns.Where(x => x.Length > 2 && x.EndsWith("Id") && !FK.ContainsKey(x)).Count() > 0) {
            //    LoadFKs(shownColumns);
            //}

            Items.Clear();
            foreach (DataRow row in data.Rows) {
                AddRowFromArray((from string col in shownColumns select row[col]).ToArray<object>());                
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