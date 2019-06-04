using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVCHIS.Utils {
    public static class Strings {
        public static string FromCamelCaseToWords(this string word) {
            return Regex.Replace(word, "(\\B[A-Z])", " $1");
        }

        public static string ToSortableString(this object o) {
            if (o is int     ) return ((int     )o).ToSortableString();
            if (o is double  ) return ((double  )o).ToSortableString();
            if (o is bool    ) return ((bool    )o).ToSortableString();
            if (o is DateTime) return ((DateTime)o).ToSortableString();

            return o?.ToString();
        }

        public static string ToSortableString(this DateTime datetime) {
            return datetime.ToString("yyyy-MM-dd");
        }

        public static string ToSortableString(this double d) {
            return $"{d,5:###.00}";
        }

        public static string ToSortableString(this int i) {
            return i.ToString();
        }

        public static string ToSortableString(this bool b) {
            return b ? FormsHelper.TICK : "";
        }
    }
}
