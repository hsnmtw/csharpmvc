using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Common {
    public abstract class DBEntity : IEntity {
        public abstract MetaData MetaData { get; }

        public void ValidateMetaData(Type M) {
            var mfields = new HashSet<string>(M.GetProperties().Select(x => x.Name));
            var efields = MetaData.Fields;
            if (!mfields.SetEquals(efields)) {
                throw new Exception($"MODEL and ENTITY are not in SYNC : \n M:[\"{string.Join("\",\"", mfields.OrderBy(x => x))}\"] \n E:[\"{string.Join("\",\"", efields.OrderBy(x => x))}\"]");
            }
            var rfields = MetaData.RequiredFields;
            if (!rfields.Select(x => mfields.Contains(x)).All(x => x)) {
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

        public abstract string GetDDL();

        internal string GetDDL(Type M) {
            var cols = from c in MetaData.Fields where c != "Id" select c;
            var size = MetaData.Sizes;
            var dtps = from p in cols where p != "Id" select ddltype(M.GetProperty(p).PropertyType, size.ContainsKey(p) ? size[p] : -1);
            var rqrd = MetaData.RequiredFields;
            var ukey = string.Join(",", MetaData.UniqueKeyFields.Select((x, i) => $"CONSTRAINT {MetaData.Source}_UK{i + 1} UNIQUE ({string.Join(",", x)})"));
            var pkey = string.Join(",", MetaData.PrimaryKeyField);
            var cdef = from tpl in cols.Zip(dtps, (a, b) => new Tuple<string, string>(a, b)) select $@"[{tpl.Item1}] {tpl.Item2} {(rqrd.Contains(tpl.Item1) ? "NOT NULL" : "")}";
            cdef = cdef.Concat(new string[] { "[Id] INTEGER IDENTITY(1,1) NOT NULL" });
            //var fkey = string.Join("", from k in MetaData.ForeignKeys select $", CONSTRAINT {MetaData.Source}_FK_{k.Key} FOREIGN KEY({k.Key}) REFERENCES { ((IEntity)DBEntitiesFactory.GetEntityByName( $"{k.Value.Item1}Entity")).MetaData.Source }({k.Value.Item2})");
            //return $@"CREATE TABLE {MetaData.Source} ({string.Join(",", cdef)}, CONSTRAINT {MetaData.Source}_PK PRIMARY KEY({pkey}), {ukey} {fkey});";
            return $@"CREATE TABLE [{MetaData.Source}] ({string.Join(",", cdef)});";
        }

        private static string ddltype(Type propertyType, int size) {

            return new Dictionary<Type, string> {
                [typeof(string)] = $"VARCHAR({size})"
                , [typeof(Int64)] = "INTEGER IDENTITY(1,1)"
                , [typeof(int)] = "INTEGER"
                , [typeof(bool)] = "CHAR(1)"
                , [typeof(double)] = "DECIMAL(5,2)"
                , [typeof(DateTime)] = "DATETIME"
                , [typeof(DateTime?)] = "DATETIME"
            }
            [propertyType];
        }
    }
}
