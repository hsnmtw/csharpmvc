using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace MVCWinform.Common {
    public abstract class AbstractDBEntity : IDBEntity {

        private const string EQ = "=";
        private const string LIKE = "LIKE";

        public abstract MetaData MetaData { get; }

        public AbstractDBEntity() : base() {
        }

        public object NewModel() {
            return Activator.CreateInstance(MetaData.GetModelType);
        }
        public virtual M Find<M>(M model, params string[] whereFields) {
            var mdl = NewModel();
            var prp = (from PropertyInfo pinfo in mdl.GetType().GetProperties() orderby pinfo.Name select pinfo.Name);
            var slc = string.Join(",", prp);
            var src = MetaData.GetSource;
            var whr = string.Join(" AND ", (from c in whereFields select $"{c}=@{c}"));
            var sql = $"SELECT {slc} FROM {src} {(whereFields.Length>0? $" WHERE ({whr})" : "")}";
            var prm = (from c in whereFields select new KeyValuePair<string,object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model)))).ToArray();
            var tbl = DBConnectionManager.Query(sql, model.GetType(), prm).OfType<M>();
            if (tbl.Count() == 0) return default(M);
            //foreach (var p in prp) mdl.GetType().GetProperty(p).SetValue(mdl, tbl.Rows[0][p] == System.DBNull.Value ? null : tbl.Rows[0][p]);
            return tbl.First();
        }

        public virtual int Create(object model) {
            var props = (from pinfo in model.GetType().GetProperties() where !pinfo.Name.ToLower().Equals("id") select pinfo.Name);
            var src = MetaData.GetSource;
            var col = string.Join(",",(from c in props select $"{c}"));
            var val = string.Join(",",(from c in props select $"@{c}"));
            var sql = $"INSERT INTO {src} ({col}) VALUES ({val})";
            //var prm = (from c in props select PrepareParameter(model.GetType().GetProperty(c).GetValue(model))).ToArray();
            var prm = (from c in props select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model)))).ToArray();
            return DBConnectionManager.Execute(sql, prm);
        }

        public virtual List<object> Read(object model, bool like = false, params string[] whereFields) {
            var prp = (from pinfo in model.GetType().GetProperties() orderby pinfo.Name select pinfo.Name);
            var slc = string.Join(",",prp); if ("".Equals(slc.Trim())) slc = "*";
            var src = MetaData.GetSource;
            var opr = like ? LIKE : EQ;
            var whr = string.Join(" AND ", (from c in whereFields select $"{c} {opr} @{c}"));
            var sql = $"SELECT {slc} FROM {src} {(whereFields.Length > 0 ? $" WHERE ({whr})" : "")}";
            //var prm = (from c in whereFields select PrepareParameter(model.GetType().GetProperty(c).GetValue(model))).ToArray();
            var prm = (from c in whereFields select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model)))).ToArray();
            return DBConnectionManager.Query(sql,model.GetType(), prm);
        }


        public virtual int Update(object model, params string[] whereFields) {
            if (whereFields.Length == 0) whereFields = new string[] { "Id" };
            var props = (from pinfo in model.GetType().GetProperties() where !pinfo.Name.ToLower().Equals("id") select pinfo.Name);
            var src = MetaData.GetSource;
            var cvl = string.Join(",", (from c in props select $"{c}=@{c}"));
            var whr = string.Join(" AND ", (from c in whereFields select $"{c}=@{c}"));
            var sql = $"UPDATE {src} SET {cvl} WHERE ({whr}) AND (ReadOnly='0')";
            var id  = model.GetType().GetProperty("Id").GetValue(model);
            //var prm = (from c in props select PrepareParameter(model.GetType().GetProperty(c).GetValue(model))).Concat(new object[]{id}).ToArray();
            var prm = (from c in props.Concat(whereFields) select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model)))).ToArray();
            return DBConnectionManager.Execute(sql, prm);
        }
        
        public virtual int Delete(object model,params string[]whereFields) {
            if (whereFields.Length == 0) whereFields = new string[] { "Id" };
            var src = MetaData.GetSource;
            var whr = string.Join(" AND ", (from c in whereFields select $"{c}=@{c}"));
            var sql = $"DELETE FROM {src} WHERE ({whr}) AND (ReadOnly='0')";
            //var id = model.GetType().GetProperty("Id").GetValue(model);
            //var prm = (from c in whereFields select PrepareParameter(model.GetType().GetProperty(c).GetValue(model))).Concat(new object[] { id }).ToArray();
            var prm = (from c in whereFields select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model)))).ToArray();
            return DBConnectionManager.Execute(sql, prm);
        }

        public static DataTable ConvertToDataTable(List<object> models) {
            return DBConnectionManager.ConvertToDataTable(models);
        }

        public static object PrepareParameter(object value) {
            if (value != null && typeof(bool).Equals(value.GetType())) {
                return Convert.ToBoolean(value) ? "1" : "0"; // "True" : "False";
            } 
            if (value != null && typeof(DateTime).Equals(value.GetType())) {
                return ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss");
            }
            return value;
        }



        public string GetDDL() {
            var cols = MetaData.GetFields;
            var size = MetaData.GetSizes;
            var dtps = from p in cols select ddltype(this.MetaData.GetModelType.GetProperty(p).PropertyType, size.ContainsKey(p) ? size[p] : -1);
            var rqrd = MetaData.GetRequiredFields;
            var uniq = string.Join(",",MetaData.GetUniqueKeyFields );
            var pkey = string.Join(",",MetaData.GetPrimaryKeyFields);
            var cdef = from tpl in cols.Zip(dtps,(a,b) => new Tuple<string,string>(a,b)) select $@"{tpl.Item1} {tpl.Item2} {(rqrd.Contains(tpl.Item1) ? "NOT NULL" : "")}";
            return $@"CREATE TABLE {MetaData.GetSource} ({string.Join(",",cdef)}, PRIMARY KEY({pkey}), UNIQUE ({uniq}))";
        }

        private string ddltype(Type propertyType,int size) {

            return new Dictionary<Type, string> 
            {
                 [typeof(string)]    = $"VARCHAR({size})"
                ,[typeof(Int64)]     = "int IDENTITY(1,1)"
                ,[typeof(int)]       = "INTEGER"
                ,[typeof(bool)]      = "CHAR(1)"
                ,[typeof(double)]    = "NUMBER"
                ,[typeof(DateTime)]  = "DATETIME"
                ,[typeof(DateTime?)] = "DATETIME"
            }
            [propertyType];
        }
    }
}
