using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ModelLibrary.Common {
    
    class TableModel<M> : DataTable where M : BaseModel {
        private List<M> _modeles;
        public TableModel(string name,List<M> models) : base(name) {
            this._modeles = models;
            Type type = typeof(M);
            //populate rows
            foreach (var property in type.GetProperties()) {
                this.Columns.Add(property.Name);
            }
            //populate columns
            foreach(M model in models) {
                object[] values = new object[this.Columns.Count];
                for(int i = 0; i < values.Length; i++) {
                    values[i] = type.GetProperty(Columns[i].ColumnName).GetValue(model);
                }
                this.Rows.Add(values);
            }
        }

        public TableModel(DataTable table) : base(table.TableName) {
            this._modeles = new List<M>();
            //populate rows
            for (int i=0;i<table.Columns.Count;i++) {
                this.Columns.Add(table.Columns[i].ColumnName);
            }
            //populate columns
            foreach (DataRow row in table.Rows) {
                object[] values = new object[this.Columns.Count];
                M model = Activator.CreateInstance<M>();
                for (int i = 0; i < values.Length; i++) {
                    values[i] = row[i];
                    if ("id".Equals(Columns[i].ColumnName.ToLower())) {
                        typeof(M).GetProperty(Columns[i].ColumnName).SetValue(model, values[i].ToString());
                    } else {
                        typeof(M).GetProperty(Columns[i].ColumnName).SetValue(model, DBNull.Value.Equals( values[i] ) ? null : values[i]);
                    }
                }
                this._modeles.Add(model);
                this.Rows.Add(values);
            }
        }

        public List<M> ToList() {
            return _modeles.ToList();
        }
    }
}
