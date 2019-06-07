using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCHIS.Tools {
    //[ForModel(MODELS.Dictionary, Enabled = true)]
    public class WordController : AbstractDBController<WordModel> {

        private LanguageController     CntrlLG;
        private WordLanguageController CntrlWL;

        public static LanguageState CurrentLanguage { get; private set; }


        private Dictionary<string, string> en = new Dictionary<string, string>();
        

        private int prevlangid = -1;
        private int langid = 0;
        public string this[string word]{
            get {
                //if (xx == null || !xx.ContainsKey(langid) || en == null) return word;
                //if (xx[langid].ContainsKey(word) == false && en.ContainsKey(word) == false) return word;
                //if (CurrentLanguage == LanguageState.Default && xx[langid].ContainsKey(word) == false) {
                //    if (xx.ContainsKey(prevlangid) && xx[prevlangid].ContainsKey(word)) return xx[prevlangid][word];
                //    return word;
                //}
                //if (CurrentLanguage != LanguageState.Default && en.ContainsKey(word) == false) return word;

                //return CurrentLanguage == LanguageState.Default ? xx[langid][word] : en[word];
                return en.ContainsKey(word) ? en[word] : word;
            }
            set {
                //if (CurrentLanguage == LanguageState.Default) xx[langid][word] = value;
                //else en[word] = value;
            }
        }

        public WordController() : base() {
            CurrentLanguage = LanguageState.Default;
            CntrlWL = DBControllersFactory.WordLanguage();
            CntrlLG = DBControllersFactory.Language();
            foreach (var w in Select(new WordModel { }, "Id,WordInEnglish")) {
                en[w.WordInEnglish] = w.WordInEnglish;
            }
        }


        public void ReadDictionary(int language) {
            prevlangid = langid;
            langid = language;
            CurrentLanguage = (language==0) ? LanguageState.Default : LanguageState.Translation;
            foreach (var w in Select(new WordModel { }, "Id,WordInEnglish")) {
                en[w.WordInEnglish] = w.WordInEnglish;
                foreach (var wl in CntrlWL.Select(new WordLanguageModel { LanguageId=language, WordId = w.Id }, "LanguageId,WordInLanguage", false, "LanguageId", "WordId")) {
                    en[w.WordInEnglish] = wl.WordInLanguage;
                    en[wl.WordInLanguage] = w.WordInEnglish;
                }
            }
        }

        public int GetCurrentLanguageId() {
            return langid;
        }

        public IEnumerable<WordLanguageModel> GetWordInLanguages(int wordId) {
            return CntrlWL.Read(new WordLanguageModel { WordId = wordId }, "WordId");
        }

        public int DeleteWordInLanguage(int wordLanguageId) {
            return CntrlWL.Delete(new WordLanguageModel { Id = wordLanguageId });
        }

        public Dictionary<int,string> GetLanguagesNotEnteredForWord(int wordId) {
            var languages = CntrlLG.GetKeysAndValues();
            var wlanguages = CntrlWL.Select(new WordLanguageModel { WordId = wordId }, "LanguageId",false,"WordId");
            return languages.Where(x => wlanguages.Select(y => y.LanguageId).Contains(x.Key)==false).ToDictionary(x => x.Key,x => x.Value);
        }

        public void SetToDefault() {
            CurrentLanguage = LanguageState.Default;
        }
    }
}
