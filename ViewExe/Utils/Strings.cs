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
    }
}
