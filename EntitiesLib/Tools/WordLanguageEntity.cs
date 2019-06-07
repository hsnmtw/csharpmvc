using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.DictionaryLanguage)]
    public class WordLanguageEntity : AbstractDBEntity<WordLanguageModel> {

        public override MetaData MetaData => new MetaData() {
              PrimaryKeyField  = "Id" 
            , Fields           = new HashSet<string> { "CreatedBy","CreatedOn","Id","ReadOnly","UpdatedBy","UpdatedOn","WordId","LanguageId","WordInLanguage" }
            , RequiredFields   = new HashSet<string> { "Id", "WordId", "LanguageId", "WordInLanguage" }
            , UniqueKeyFields  = new HashSet<HashSet<string>> { new HashSet<string> { "WordId", "LanguageId" } }
            , ForeignKeys      = new Dictionary<string, Tuple<MODELS, string>> {
                ["WordId"]     = new Tuple<MODELS, string>(MODELS.Word,"Id"),
                ["LanguageId"] = new Tuple<MODELS, string>(MODELS.Language,"Id")
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"     ] = 10,
                ["UpdatedBy"     ] = 10,
                ["WordInLanguage"] = 250
            }
            , Source = ENTITIES.WordLanguage
        };
    }
}
