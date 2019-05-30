using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Dictionary)]
    public class DictionaryEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(DictionaryModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields  = new List<string> { "Id", "WordInEnglish", "WordInArabic" }
            , UniqueKeyFields = new List<string> { "WordInEnglish" }
            , ForeignKeys     = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"    ] = 50,
                ["UpdatedBy"    ] = 50,
                ["WordInEnglish"] = 250,
                ["WordInArabic" ] = 250
            }
            , Source = "ToolsDictionary"
        };
    }
}
