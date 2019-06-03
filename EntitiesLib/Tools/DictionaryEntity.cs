using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Dictionary)]
    public class DictionaryEntity : AbstractDBEntity<DictionaryModel> {

        public override MetaData MetaData => new MetaData() {
            //ModelType = typeof(DictionaryModel)
              PrimaryKeyField = "Id" 
            , Fields          = new HashSet<string> { "CreatedBy","CreatedOn","Id","ReadOnly","UpdatedBy","UpdatedOn","WordInArabic","WordInEnglish" }
            , RequiredFields  = new HashSet<string> { "Id", "WordInEnglish", "WordInArabic" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "WordInEnglish" } }
            , ForeignKeys     = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"    ] = 10,
                ["UpdatedBy"    ] = 10,
                ["WordInEnglish"] = 250,
                ["WordInArabic" ] = 250
            }
            , Source = "ToolsDictionary"
        };
    }
}
