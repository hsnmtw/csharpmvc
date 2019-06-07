using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Dictionary)]
    public class WordEntity : AbstractDBEntity<WordModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField = "Id" 
            , Fields          = new HashSet<string> { "CreatedBy","CreatedOn","Id","ReadOnly","UpdatedBy","UpdatedOn","WordInEnglish" }
            , RequiredFields  = new HashSet<string> { "Id", "WordInEnglish" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "WordInEnglish" } }
            , ForeignKeys     = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"    ] = 10,
                ["UpdatedBy"    ] = 10,
                ["WordInEnglish"] = 250
            }
            , Source = ENTITIES.Word
        };
    }
}
