using System;
using System.Data;
using System.Linq;
using System.Reflection;

namespace MVCWinform.Common {
    [Serializable]
    public abstract class BaseModel : IModel, IComparable, ICloneable {
        //Database table properties
        public Int64 Id            { get; set; }
        public string CreatedBy    { get; set; }
        public string UpdatedBy    { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool      ReadOnly  { get; set; }

        //public object this[string key] => this.GetType().GetProperty(key).GetValue(this);

        public object Clone() {
            var copy = Activator.CreateInstance(this.GetType());
            foreach (var pinfo in this.GetType().GetProperties()) {
                pinfo.SetValue(copy, pinfo.GetValue(this));
            }
            return copy;
        }

        public int CompareTo(object obj) {
            return $"{obj}".CompareTo($"{this}");
        }

        public object[] ToObjectArray(string[] fields) {
            object[] objects = new object[fields.Length];
            for (int i = 0; i < fields.Length; i++) {
                var column = fields[i];
                objects[i] = GetType().GetProperty(column).GetValue(this);
            }
            return objects;
        }

        /// <summary>
        /// converts the model to printable format, this can be useful in logging
        /// </summary>
        /// <returns>string representation of the model</returns>
        public override string ToString() {
            string properties = string.Join(",", (
                    from PropertyInfo propertyInfo
                      in this.GetType().GetProperties()
                    select $"{propertyInfo.Name}='{propertyInfo.GetValue(this)}'"));
            return $"{this.GetType().Name}:[{properties}]";
        }
    }
}