using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Common {
    public class SQLController {
        public const string NEWLINE = "\r\n";

        public bool isOLEDBConnection() => ConfigLoader.ConnectionString.ToLower().Contains("oledb");

        public int Execute(string sql) => DBConnectionManager.Instance.Execute(sql);

        public string Query(string sql) {

            IEnumerable<Dictionary<string, object>> query = DBConnectionManager.Instance.QueryAsDictionary(sql);
            if (query.Count() == 0) return "NO ROWS !!!";
            var sb = new StringBuilder();
            var first = query.First();
            string[] vals, keys;
            if (first.GetType().ToString().Contains("Dictionary")) {
                keys = (from key in first.Keys orderby key select key).ToArray();
                vals = new string[keys.Length];
                for (int k = 0; k < keys.Length; k++) {
                    vals[k] = (string.Format("{0,-25}", keys[k]));
                }
                sb.Append(string.Join(",", vals)).Append(NEWLINE);
                for (int k = 0; k < keys.Length; k++) {
                    vals[k] = (string.Format("{0,-25}", "-----------------------"));
                }
                sb.Append(string.Join(",", vals)).Append(NEWLINE);
                foreach (var item in query) {
                    vals = new string[keys.Length];
                    for (int k = 0; k < keys.Length; k++) {
                        vals[k] = (string.Format("{0,-25}", item[keys[k]]));
                    }
                    sb.Append(string.Join(",", vals)).Append(NEWLINE);
                }
            }
            return sb.ToString();
        }
    }
}
