using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Language)]
    public class LanguageEntity : AbstractDBEntity<LanguageModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField = "Id" 
            , Fields          = new HashSet<string> { "CreatedBy","CreatedOn","Id","ReadOnly","UpdatedBy","UpdatedOn","LanguageName" }
            , RequiredFields  = new HashSet<string> { "Id", "LanguageName" }
            , UniqueKeyFields = new HashSet<HashSet<string>> { new HashSet<string> { "LanguageName" } }
            , ForeignKeys     = new Dictionary<string, Tuple<MODELS, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"    ] = 10,
                ["UpdatedBy"    ] = 10,
                ["LanguageName" ] = 50
            }
            , Source = ENTITIES.Language
        };
    }
}
