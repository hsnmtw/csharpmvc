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

        
        private Dictionary<string, string> myDictionary = new Dictionary<string, string>();

        public static LanguageState LanguageState { get; set; }

        public string this[string word]{
            get {
                
                return myDictionary.ContainsKey(word) ? myDictionary[word] : word;
            }
        }


        public DictionaryController() : base(DBEntitiesFactory.GetEntity(Entities.Dictionary)) {
            foreach (DictionaryModel model in Read()) {
                this.myDictionary[model.WordInArabic] = model.WordInEnglish;
                this.myDictionary[model.WordInEnglish] = model.WordInArabic;
            }
        }

    }
}
