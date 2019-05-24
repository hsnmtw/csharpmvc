using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Common;

namespace ModelLibrary.Tools
{
    public class DictionaryEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(DictionaryModel)
            , GetPrimaryKeyFields = "Id".Split(',')
            , GetRequiredFields = "Id,WordInEnglish,WordInArabic".Split(',')
            , GetSource = "ToolsDictionary"
            , GetUniqueKeyFields = new string[] { "WordInEnglish" }
            };
    }
}
