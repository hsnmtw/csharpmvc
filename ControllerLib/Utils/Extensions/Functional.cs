using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Utils {
    public static class Functional {
        public static IEnumerable<T> ToSet<T>(this IEnumerable<T> source) {
            return new HashSet<T>(source);
        }

        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> source) {
            return source.SelectMany(x => x);
        }

        public static IEnumerable<T> Ordered<T>(this IEnumerable<T> source) {
            return source.OrderBy(x => x);
        }

        public static IEnumerable<O> Map<I,O>(this IEnumerable<I> source,Func<I,O> func) {
            return source.Select(x => func(x));
        }

        public static DataTable ToDataTable<K,V>(this Dictionary<K,V> data) {
            DataTable source = new DataTable();
            source.Columns.AddRange(new[] { new DataColumn("Key"), new DataColumn("Value") });
            foreach (var kv in data) {
                source.Rows.Add(new object[] { kv.Key, kv.Value });
            }
            return source;
        }
    }
}
