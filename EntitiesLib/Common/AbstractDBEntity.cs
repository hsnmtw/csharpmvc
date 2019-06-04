using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace MVCHIS.Common {
    public abstract class AbstractDBEntity<M> : IDBEntity<M> where M:BaseModel {

        private const string EQ = "IN";
        private const string LIKE = "LIKE";

        public abstract MetaData MetaData { get; }

        public AbstractDBEntity() : base() {
            ValidateMetaData();
        }
        public void ValidateMetaData() { 
            var mfields = new HashSet<string>(typeof(M).GetProperties().Select(x => x.Name));
            var efields = MetaData.Fields;
            if (!mfields.SetEquals(efields)) {
                throw new Exception($"MODEL and ENTITY are not in SYNC : \n M:[\"{string.Join("\",\"",mfields.OrderBy(x=>x))}\"] \n E:[\"{string.Join("\",\"",efields.OrderBy(x => x))}\"]");
            }
            var rfields = MetaData.RequiredFields;
            if(!rfields.Select(x => mfields.Contains(x)).All(x => x)) {
                throw new Exception($"ENTITY Required fields are not in MODEL : \n M:[\"{string.Join("\",\"", mfields.OrderBy(x => x))}\"] \n E:[\"{string.Join("\",\"", rfields.OrderBy(x => x))}\"]");
            }
            var ufields = new HashSet<string>(MetaData.UniqueKeyFields.SelectMany(x => x).ToList());
            if (!ufields.Select(x => mfields.Contains(x)).All(x => x)) {
                throw new Exception($"ENTITY Unique fields are not in MODEL : \n M:[\"{string.Join("\",\"", mfields.OrderBy(x => x))}\"] \n E:[\"{string.Join("\",\"", ufields.OrderBy(x => x))}\"]");
            }
            var pfield = MetaData.PrimaryKeyField;
            if (!mfields.Contains(pfield)) {
                throw new Exception($"ENTITY Primary fields are not in MODEL : \n M:[\"{string.Join("\",\"", mfields.OrderBy(x => x))}\"] \n E:[\"{pfield}\"]");
            }
            var ffields = MetaData.ForeignKeys.Keys;
            if (!ffields.Select(x => mfields.Contains(x)).All(x => x)) {
                throw new Exception($"ENTITY Primary fields are not in MODEL : \n M:[\"{string.Join("\",\"", mfields.OrderBy(x => x))}\"] \n E:[\"{string.Join("\",\"", ffields.OrderBy(x => x))}\"]");
            }


        }

        public virtual bool Validate(M model) {
            var p = MetaData.RequiredFields;
            var i = p.Select(x => x.EndsWith("Id") && x.Length>2 && "0".Equals($"{model.GetType().GetProperty(x).GetValue(model)}".Trim()));
            var q = p.Select(x => "".Equals($"{model.GetType().GetProperty(x).GetValue(model)}".Trim()));
            var w = q.All(y => !y) && i.All(y => !y);
            return w;
        }

        public DataTable GetDataById(M model, IEnumerable<int> Ids) {
            if (Ids == null || Ids.Count() == 0) return new DataTable();
            var tpl = GetSQLAndParameters(model, false, "Id");
            var sql = tpl.Item1.Replace("@Id", string.Join(",", Ids));
            return DBConnectionManager.Instance.GetData(sql);
        }

        public IEnumerable<M> FindById(M model, IEnumerable<int> Ids) {
            if (Ids==null || Ids.Count() == 0) return new List<M>();
            var tpl = GetSQLAndParameters(model,false,"Id");
            var sql = tpl.Item1.Replace("@Id", string.Join(",", Ids));
            return DBConnectionManager.Instance.Query(model, sql);
        }

        public M NewModel() {
            return Activator.CreateInstance<M>();
        }

        public virtual M Find(M model, params string[] whereFields) {
            var mdl = NewModel();
            var prp = (from PropertyInfo pinfo in mdl.GetType().GetProperties() orderby pinfo.Name select pinfo.Name);
            var slc = string.Join("],[", prp);
            var src = MetaData.Source;
            var whr = string.Join(" AND ", (from c in whereFields select $"[{c}]=@{c}"));
            var sql = $"SELECT [{slc}] FROM [{src}] {(whereFields.Length>0? $" WHERE ({whr})" : "")}";
            var prm = (from c in whereFields select new KeyValuePair<string,object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            var tbl = DBConnectionManager.Instance.Query(model,sql, prm);
            var rsl = tbl.FirstOrDefault();
            return rsl;// == null ? rsl : NewModel();
        }

        public virtual M Exists(M model) {
            var unq = MetaData.UniqueKeyFields;
            var whr = from us in unq select string.Join(" AND ", from u in us select $"[{u}]=@{u}" ); // [[s]]
            var exs = $"SELECT * FROM {MetaData.Source} WHERE ({string.Join(") OR (", whr )})";
            var prm = unq.SelectMany(x => x).Distinct().Select(c => new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return DBConnectionManager.Instance.Query(model,exs,prm).FirstOrDefault();
        }

        public virtual int Create(M model) {
            var exs = Exists(model);
            if (exs != null) throw new Exception($"DB ERROR : UNIQUE KEY VIOLATION -- Model with same Unique Key exists with Id ({exs.Id})");
            var xcl = new string[] { "Id", "UpdatedBy", "UpdatedOn" };
            var prp = (from pinfo in model.GetType().GetProperties() where !xcl.Contains(pinfo.Name) select pinfo.Name);
            var src = MetaData.Source;
            var col = string.Join(",",(from c in prp select $"[{c}]"));
            var val = string.Join(",",(from c in prp select $"@{c}"));
            var sql = $"INSERT INTO [{src}] ({col}) VALUES ({val})";
            var prm = (from c in prp select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return DBConnectionManager.Instance.Execute(sql, prm);
        }

        public virtual Tuple<string, KeyValuePair<string, object>[]> GetSQLAndParameters(M model, bool like = false, params string[] whereFields) {
            var prp = (from pinfo in model.GetType().GetProperties() orderby pinfo.Name select pinfo.Name);
            var slc = string.Join(",", prp); if ("".Equals(slc.Trim())) slc = "*";
            var src = MetaData.Source;
            var opr = like ? LIKE : EQ;
            var whr = string.Join(" AND ", (from c in whereFields select $"{c} {opr} (@{c})"));
            var sql = $"SELECT {slc} FROM {src} {(whereFields.Length > 0 ? $" WHERE ({whr})" : "")}";
            var prm = (from c in whereFields select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return new Tuple<string, KeyValuePair<string, object>[]>(sql,prm);
        }

        public virtual IEnumerable<M> Read(M model, bool like = false, params string[] whereFields) {
            var tpl = GetSQLAndParameters(model, like, whereFields);
            return DBConnectionManager.Instance.Query(model,tpl.Item1,tpl.Item2);
        }

        public DataTable GetData(M model, bool like = false, params string[] whereFields) {
            var tpl = GetSQLAndParameters(model, like, whereFields);
            return DBConnectionManager.Instance.GetData(tpl.Item1,tpl.Item2);
        }


        public virtual int Update(M model, params string[] whereFields) {
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
        
        public virtual int Delete(M model,params string[]whereFields) {
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
            var cols = from c in MetaData.Fields where c != "Id" select c;
            var size = MetaData.Sizes;
            var dtps = from p in cols where p != "Id" select ddltype(typeof(M).GetProperty(p).PropertyType, size.ContainsKey(p) ? size[p] : -1);
            var rqrd = MetaData.RequiredFields;
            var ukey = string.Join(",", MetaData.UniqueKeyFields.Select((x, i) => $"CONSTRAINT {MetaData.Source}_UK{i + 1} UNIQUE ({string.Join(",", x)})"));
            var pkey = string.Join(",", MetaData.PrimaryKeyField);
            var cdef = from tpl in cols.Zip(dtps, (a, b) => new Tuple<string, string>(a, b)) select $@"{tpl.Item1} {tpl.Item2} {(rqrd.Contains(tpl.Item1) ? "NOT NULL" : "")}";
            cdef = cdef.Concat(new string[] { "Id INTEGER IDENTITY(1,1) NOT NULL" });
            //var fkey = string.Join("", from k in MetaData.ForeignKeys select $", CONSTRAINT {MetaData.Source}_FK_{k.Key} FOREIGN KEY({k.Key}) REFERENCES {k.Value.Item1}({k.Value.Item2})");
            //return $@"CREATE TABLE {MetaData.Source} ({string.Join(",", cdef)}, CONSTRAINT {MetaData.Source}_PK PRIMARY KEY({pkey}), {ukey} {fkey});";
            return $@"CREATE TABLE {MetaData.Source} ({string.Join(",", cdef)});";
        }

        private static string ddltype(Type propertyType,int size) {

            return new Dictionary<Type, string> 
            {
                 [typeof(string)]    = $"VARCHAR({size})"
                ,[typeof(Int64)]     = "INTEGER IDENTITY(1,1)"
                ,[typeof(int)]       = "INTEGER"
                ,[typeof(bool)]      = "CHAR(1)"
                ,[typeof(double)]    = "DECIMAL(5,2)"
                ,[typeof(DateTime)]  = "DATETIME"
                ,[typeof(DateTime?)] = "DATETIME"
            }
            [propertyType];
        }
    }
}
