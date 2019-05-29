using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    [ForModel(MODELS.Dictionary)]
    public class DictionaryEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(DictionaryModel)
            , PrimaryKeyFields = new string[]{ "Id" }
            , RequiredFields = new string[] { "Id", "WordInEnglish", "WordInArabic" }
            , UniqueKeyFields = new string[] { "WordInEnglish" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["WordInEnglish"] = 250,
                ["WordInArabic"] = 250
            }
            , Source = "ToolsDictionary"
        };
    }
}
