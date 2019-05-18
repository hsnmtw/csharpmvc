using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Data;
using System.Reflection;
using System.Xml;

namespace ModelLibrary.Common
{
    [Serializable]
    public abstract class BaseModel : IModel, IComparable, ICloneable {
        //Database table properties
        public int Id               { get; set; }
        public string Created_By    { get; set; }
        public string Updated_By    { get; set; }
        public DateTime? Created_On { get; set; }
        public DateTime? Updated_On { get; set; }

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