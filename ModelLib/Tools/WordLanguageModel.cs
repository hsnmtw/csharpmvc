using MVCHIS.Common;

namespace MVCHIS.Tools {
    public class WordLanguageModel : BaseModel
    {
        public int    WordId         { get; set; }
        public int    LanguageId     { get; set; }
        public string WordInLanguage { get; set; }
    }
}
