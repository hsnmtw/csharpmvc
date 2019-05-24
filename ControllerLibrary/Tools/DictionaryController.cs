using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerLibrary.Common;
using ModelLibrary.Common;
using ModelLibrary.Tools;

namespace ControllerLibrary.Tools
{
    [ForControllerAttribute(Entities.Dictionary, Enabled = true)]
    public class DictionaryController : AbstractDBController {

        
        private static Dictionary<string, string> en = new Dictionary<string, string>();
        private static Dictionary<string, string> ar = new Dictionary<string, string>();

        public static LanguageState LanguageState { get; set; }

        public string this[string word]{
            get {
                if(LanguageState == LanguageState.Arabic)
                    return en.ContainsKey(word) ? en[word] : word;
                else
                    return ar.ContainsKey(word) ? ar[word] : word;
            }
        }

        public DictionaryController() : base(DBEntitiesFactory.GetEntity(Entities.Dictionary)) {
            foreach (DictionaryModel model in Read()) {
                en[model.WordInEnglish] = model.WordInArabic;
                ar[model.WordInArabic] = model.WordInEnglish;
            }
        }

    }
}
