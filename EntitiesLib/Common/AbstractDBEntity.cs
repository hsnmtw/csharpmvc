using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace MVCHIS.Common {
    public abstract class AbstractDBEntity : IDBEntity {

        private const string EQ = "IN";
        private const string LIKE = "LIKE";

        public abstract MetaData MetaData { get; }

        public AbstractDBEntity() : base() {
        }

        public virtual bool Validate<M>(M model) {
            var p = MetaData.RequiredFields;
            var q = p.Select(x => "".Equals($"{model.GetType().GetProperty(x).GetValue(model)}".Trim()));
            var w = q.All(y => !y);
            return w;
        }

        public DataTable GetDataById<M>(M model, IEnumerable<int> Ids) {
            if (Ids == null || Ids.Count() == 0) return new DataTable();
            var tpl = GetSQLAndParameters(model, false, "Id");
            var sql = tpl.Item1.Replace("@Id", string.Join(",", Ids));
            return DBConnectionManager.Instance.GetData(sql);
        }

        public IEnumerable<M> FindById<M>(M model, IEnumerable<int> Ids) {
            if (Ids==null || Ids.Count() == 0) return new List<M>();
            var tpl = GetSQLAndParameters(model,false,"Id");
            var sql = tpl.Item1.Replace("@Id", string.Join(",", Ids));
            return DBConnectionManager.Instance.Query(model, sql);
        }

        public M NewModel<M>() {
            return (M)Activator.CreateInstance(MetaData.ModelType);
        }
        public virtual M Find<M>(M model, params string[] whereFields) {
            var mdl = NewModel<M>();
            var prp = (from PropertyInfo pinfo in mdl.GetType().GetProperties() orderby pinfo.Name select pinfo.Name);
            var slc = string.Join("],[", prp);
            var src = MetaData.Source;
            var whr = string.Join(" AND ", (from c in whereFields select $"[{c}]=@{c}"));
            var sql = $"SELECT [{slc}] FROM [{src}] {(whereFields.Length>0? $" WHERE ({whr})" : "")}";
            var prm = (from c in whereFields select new KeyValuePair<string,object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            var tbl = DBConnectionManager.Instance.Query(model,sql, prm);
            return tbl.FirstOrDefault();
        }

        public virtual int Create<M>(M model) {
            var xcl = new string[] { "Id", "UpdatedBy", "UpdatedOn" };
            var prp = (from pinfo in model.GetType().GetProperties() where !xcl.Contains(pinfo.Name) select pinfo.Name);
            var src = MetaData.Source;
            var col = string.Join(",",(from c in prp select $"[{c}]"));
            var val = string.Join(",",(from c in prp select $"@{c}"));
            var sql = $"INSERT INTO [{src}] ({col}) VALUES ({val})";
            var prm = (from c in prp select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return DBConnectionManager.Instance.Execute(sql, prm);
        }

        public virtual Tuple<string, KeyValuePair<string, object>[]> GetSQLAndParameters<M>(M model, bool like = false, params string[] whereFields) {
            var prp = (from pinfo in model.GetType().GetProperties() orderby pinfo.Name select pinfo.Name);
            var slc = string.Join(",", prp); if ("".Equals(slc.Trim())) slc = "*";
            var src = MetaData.Source;
            var opr = like ? LIKE : EQ;
            var whr = string.Join(" AND ", (from c in whereFields select $"{c} {opr} (@{c})"));
            var sql = $"SELECT {slc} FROM {src} {(whereFields.Length > 0 ? $" WHERE ({whr})" : "")}";
            var prm = (from c in whereFields select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return new Tuple<string, KeyValuePair<string, object>[]>(sql,prm);
        }

        public virtual IEnumerable<M> Read<M>(M model, bool like = false, params string[] whereFields) {
            var tpl = GetSQLAndParameters(model, like, whereFields);
            return DBConnectionManager.Instance.Query(model,tpl.Item1,tpl.Item2);
        }

        public DataTable GetData<M>(M model, bool like = false, params string[] whereFields) {
            var tpl = GetSQLAndParameters(model, like, whereFields);
            return DBConnectionManager.Instance.GetData(tpl.Item1,tpl.Item2);
        }


        public virtual int Update<M>(M model, params string[] whereFields) {
            if (whereFields.Length == 0) whereFields = new string[] { "Id" };
            var xcl = new string[] { "Id", "CreatedBy", "CreatedOn" };
            var prp = (from pinfo in model.GetType().GetProperties() where !xcl.Contains(pinfo.Name) select pinfo.Name);
            var src = MetaData.Source;
            var cvl = string.Join(",", (from c in prp select $"[{c}]=@{c}"));
            var whr = string.Join(" AND ", (from c in whereFields select $"[{c}]=@{c}"));
            var sql = $"UPDATE [{src}] SET {cvl} WHERE ({whr}) AND (ReadOnly='0')";
            var prm = (from c in prp.Concat(whereFields) select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return DBConnectionManager.Instance.Execute(sql, prm);
        }
        
        public virtual int Delete<M>(M model,params string[]whereFields) {
            if (whereFields.Length == 0) whereFields = new string[] { "Id" };
            var src = MetaData.Source;
            var whr = string.Join(" AND ", (from c in whereFields select $"[{c}]=@{c}"));
            var sql = $"DELETE FROM [{src}] WHERE ({whr}) AND (ReadOnly='0')";
            var prm = (from c in whereFields select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return DBConnectionManager.Instance.Execute(sql, prm);
        }



        public static object PrepareParameter(object value) {
            if (value != null && typeof(bool).Equals(value.GetType())) {
                return Convert.ToBoolean(value) ? "1" : "0"; // "True" : "False";
            } 
            if (value != null && typeof(DateTime).Equals(value.GetType())) {
                return ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (value != null && typeof(string).Equals(value.GetType())) {
                return $"{value}".Trim();
            }
            return value;
        }



        public string GetDDL() {
            var cols = from c in MetaData.GetFields where c!="Id" select c;
            var size = MetaData.GetSizes;
            var dtps = from p in cols where p!="Id" select ddltype(this.MetaData.ModelType.GetProperty(p).PropertyType, size.ContainsKey(p) ? size[p] : -1);
            var rqrd = MetaData.RequiredFields;
            var uniq = string.Join(",",MetaData.UniqueKeyFields );
            var pkey = string.Join(",",MetaData.PrimaryKeyField);
            var cdef = from tpl in cols.Zip(dtps,(a,b) => new Tuple<string,string>(a,b)) select $@"{tpl.Item1} {tpl.Item2} {(rqrd.Contains(tpl.Item1) ? "NOT NULL" : "")}";
            cdef = cdef.Concat(new string[] { "Id INTEGER IDENTITY(1,1) NOT NULL" });
            var fkey = string.Join("",from k in MetaData.ForeignKeys select $",FOREIGN KEY({k.Key}) REFERENCES {k.Value.Item1}({k.Value.Item2})");
            return $@"CREATE TABLE {MetaData.Source} ({string.Join(",",cdef)}, PRIMARY KEY({pkey}), UNIQUE ({uniq}) {fkey})";
        }

        private string ddltype(Type propertyType,int size) {

            return new Dictionary<Type, string> 
            {
                 [typeof(string)]    = $"VARCHAR({size})"
                ,[typeof(Int64)]     = "INTEGER IDENTITY(1,1)"
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
