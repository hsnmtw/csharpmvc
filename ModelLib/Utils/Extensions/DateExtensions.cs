using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Utils.Extensions {
    public static class DateExtensions {
        public static TimeSpan Diff(this DateTime source, DateTime other) {
            return source - other;
        }

        public static TimeSpan Diff(this DateTime? source, DateTime other) {
            return ((DateTime)source) - other;
        }
    }
}
