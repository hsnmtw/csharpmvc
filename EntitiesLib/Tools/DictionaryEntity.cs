using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    [ForEntity(Entities.Dictionary)]
    public class DictionaryEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(DictionaryModel)
            , GetPrimaryKeyFields = new string[]{ "Id" }
            , GetRequiredFields = new string[] { "Id", "WordInEnglish", "WordInArabic" }
            , GetUniqueKeyFields = new string[] { "WordInEnglish" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["WordInEnglish"] = 250,
                ["WordInArabic"] = 250
            }
            , GetSource = "ToolsDictionary"
        };
    }
}
