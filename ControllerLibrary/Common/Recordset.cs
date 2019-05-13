using ModelLibrary.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace ControllerLibrary.Common {

    public class Recordset<M> : IEnumerator<M> where M : BaseModel {
        private IDataReader reader;
        private int position { get; set; }
        public M Current { get; private set; }

        object IEnumerator.Current { get { return (object)Current; } }

        public Recordset(IDataReader reader) {
            this.reader = reader;
            this.position = -1;
        }

        public void Dispose() {
            try {
                this.reader.Close();
                this.reader.Dispose();
                this.reader = null;
            } catch { }
        }

        public bool MoveNext() {
            if (reader.Read()) {
                
                M model = Activator.CreateInstance<M>();
                
                for (int i = 0; i < reader.FieldCount; i++) {
                    string field = reader.GetName(i);
                    object value = reader.GetValue(i);
                    if ("id".Equals(field.ToLower())) {
                        typeof(M).GetProperty(field).SetValue(model, value.ToString());
                    } else {
                        typeof(M).GetProperty(field).SetValue(model, DBNull.Value.Equals( value ) ? null : value );
                    }
                }
                this.Current = model;
                this.position++;
                return true;
            } else {
                return false;
            }
        }

        public void Reset() {
            this.position = 0;
        }
    }
}
