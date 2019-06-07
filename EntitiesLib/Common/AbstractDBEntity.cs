using MVCHIS.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace MVCHIS.Common {
    public abstract class AbstractDBEntity<M> : DBEntity, IDBEntity<M> where M:BaseModel {

        private const string EQ = "IN";
        private const string LIKE = "LIKE";

        public AbstractDBEntity() : base() {
            ValidateMetaData(typeof(M));
        }


        public virtual string Validate(M model) {
            BaseValidator<M> validator = new BaseValidator<M>(MetaData);
            var vresult = validator.Validate(model);
            return vresult.Errors.Select(x => x.ErrorMessage).ToList().Print().Replace(",",",\n");
        }

        public DataTable GetDataById(M model, IEnumerable<int> Ids) {
            if (Ids == null || Ids.Count() == 0) return new DataTable();
            var tpl = GetSQLAndParameters(model,"*", false, "Id");
            var sql = tpl.Item1.Replace("@Id", string.Join(",", Ids));
            return DBConnectionManager.Instance.GetData(sql);
        }

        public IEnumerable<M> FindById(M model, IEnumerable<int> Ids) {
            if (Ids==null || Ids.Count() == 0) return new List<M>();
            var tpl = GetSQLAndParameters(model,"*",false,"Id");
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
            var xcl = new string[] { "Id", "UpdatedBy", "UpdatedOn", "ReadOnly" };
            var prp = (from pinfo in model.GetType().GetProperties() where !xcl.Contains(pinfo.Name) select pinfo.Name);
            var src = MetaData.Source;
            var col = string.Join(",",(from c in prp select $"[{c}]"));
            var val = string.Join(",",(from c in prp select $"@{c}"));
            var sql = $"INSERT INTO [{src}] ({col}) VALUES ({val})";
            var prm = (from c in prp select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return DBConnectionManager.Instance.Execute(sql, prm);
        }

        public virtual Tuple<string, KeyValuePair<string, object>[]> GetSQLAndParameters(M model,string fields="*", bool like = false, params string[] whereFields) {
            //var prp = (from pinfo in model.GetType().GetProperties() orderby pinfo.Name select pinfo.Name);
            //var slc = string.Join("],[", prp); if ("".Equals(slc.Trim())) slc = "*";
            var slc = fields=="*" ? "*" : $"[{string.Join("],[",fields.Split(','))}]";
            var src = MetaData.Source;
            var opr = like ? LIKE : EQ;
            var whr = string.Join(" AND ", (from c in whereFields select $"{c} {opr} (@{c})"));
            var sql = $"SELECT {slc} FROM [{src}] {(whereFields.Length > 0 ? $" WHERE ({whr})" : "")}".Replace("[*]","*");
            var prm = (from c in whereFields select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return new Tuple<string, KeyValuePair<string, object>[]>(sql,prm);
        }

        public virtual IEnumerable<M> Select(M model,string fields="*", bool like = false, params string[] whereFields) {
            var tpl = GetSQLAndParameters(model,fields, like, whereFields);
            return DBConnectionManager.Instance.Query(model,tpl.Item1,tpl.Item2);
        }

        public DataTable GetData(M model,string fields="*", bool like = false, params string[] whereFields) {
            var tpl = GetSQLAndParameters(model, fields, like, whereFields);
            return DBConnectionManager.Instance.GetData(tpl.Item1,tpl.Item2);
        }


        public virtual int Update(M model, params string[] whereFields) {
            if (whereFields.Length == 0) whereFields = new string[] { "Id" };
            var xcl = new string[] { "Id", "CreatedBy", "CreatedOn" };
            var prp = (from pinfo in model.GetType().GetProperties() where !xcl.Contains(pinfo.Name) select pinfo.Name);
            var src = MetaData.Source;
            var cvl = string.Join(",", (from c in prp select $"[{c}]=@{c}"));
            var whr = string.Join(" AND ", (from c in whereFields select $"[{c}]=@{c}"));
            var sql = $"UPDATE [{src}] SET {cvl} WHERE ({whr}) AND ([ReadOnly] is NULL OR [ReadOnly]='0')";
            var prm = (from c in prp.Concat(whereFields) select new KeyValuePair<string, object>($"@{c}", PrepareParameter(model.GetType().GetProperty(c).GetValue(model))))?.ToArray();
            return DBConnectionManager.Instance.Execute(sql, prm);
        }
        
        public virtual int Delete(M model,params string[]whereFields) {
            if (whereFields.Length == 0) whereFields = new string[] { "Id" };
            var src = MetaData.Source;
            var whr = string.Join(" AND ", (from c in whereFields select $"[{c}]=@{c}"));
            var sql = $"DELETE FROM [{src}] WHERE ({whr}) AND ([ReadOnly] is NULL OR [ReadOnly]='0')";
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

        public override string GetDDL() => GetDDL(typeof(M));
    }
}
