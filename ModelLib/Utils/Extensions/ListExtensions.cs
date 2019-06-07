using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Utils.Extensions {

    public class STriple : Tuple<string, string, string> {
        public STriple(string item1, string item2, string item3) : base(item1, item2, item3) {
        }
    }
    public class FList<T> : List<T>   { public override string ToString() => ListExtensions.Print(this); }
    public class FSet<T> : HashSet<T> { public override string ToString() => ListExtensions.Print(this); }
    public class FMap<K,V> : Dictionary<K,V> { public override string ToString() => ListExtensions.Print(this); }


    public static class ListExtensions {

        public static DataTable ToDataTable<M>(this IEnumerable<M> source) {
            var table = new DataTable();
            var pis = typeof(M).GetProperties();
            table.Columns.AddRange(pis.Select(x => new DataColumn(x.Name)).ToArray());
            foreach(M m in source) {
                table.Rows.Add((from DataColumn c in table.Columns select typeof(M).GetProperty(c.ColumnName).GetValue(m))?.ToArray());
            }
            return table;
        }

        public static bool Empty<T>(IEnumerable<T> source) {
            return source.Count() == 0;
        }

        public static string Print<T>(this List<T> source) {
            return $"[{string.Join(",",source)}]";
        }

        public static string Print<T>(this HashSet<T> source) {
            return $"{{{string.Join(",", source)}}}";
        }

        public static string Print<K,V>(this KeyValuePair<K,V> source) {
            return $"({source.Key},{source.Value})";
        }

        public static string Print<K,V>(this Dictionary<K,V> source) {
            return Empty(source) ? "{}" : $"{{\"{string.Join(",", source.Print())}\"}}";
        }


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
