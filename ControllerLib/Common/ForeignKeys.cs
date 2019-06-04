using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCHIS.Utils;


namespace MVCHIS.Common {
    public class ForeignKeys {

        private static ForeignKeys instance = null;
        public static ForeignKeys Instance {
            get {
                if (instance == null) { instance = new ForeignKeys(); }
                return instance;
            }
        }

        public MODELS GetMatchingKey(string key) {
            if (key.EndsWith("Id")) key = key.Remove(key.Length-2);
            foreach(MODELS mKey in lookUps.Keys) {
                if (key.EndsWith(mKey.ToString())) return mKey;
            }
            return 0;
        }

        public bool ContainsKey(string key) => lookUps.Keys.Any(x => x.ToString().Equals(key));

        public string this[string key, object oid] => this[lookUps.Keys.Where(x => x.ToString().Equals(key)).FirstOrDefault(), oid];

        public bool ContainsKey(MODELS key) => lookUps.ContainsKey(key);
        public string this[MODELS key, object oid] {
            get {
                if(!int.TryParse($"{oid}",out int id)) { id = -1; }
                return this[key, id];
            }
        }
        public string this[MODELS key,int id] {
            get {
                if (false == (ContainsKey(key) && lookUps[key].ContainsKey(id))) return null;
                return lookUps[key][id];
            }
        }

        private Dictionary<MODELS, Dictionary<int, string>> lookUps;
        private ForeignKeys() {
            lookUps = new Dictionary<MODELS, Dictionary<int, string>>();
        }

        public void Put<M>(IDBController<M> controller) where M:BaseModel {
            var key = (MODELS)Enum.Parse(typeof(MODELS), typeof(M).Name.Remove(typeof(M).Name.Length - "Model".Length));

            if (ContainsKey(key)) return;

            var uk  = controller.GetMetaData().UniqueKeyFields.SelectMany(x => x).Distinct();
            var ufs = uk.Select(f => f.FromCamelCaseToWords().Split(' '));
            var uf  = ufs.Select(x => x.Length > 1 && x[x.Length - 1] == "Id" ? x[x.Length - 2] : null).ToArray();
            var MT  = typeof(M);
            var lookup = controller
                            .Read()
                            .ToDictionary(x => x.Id, x => string.Join(" | ", uk.Select( (y,i) => (uf[i]==null ? MT.GetProperty(y).GetValue(x) : this[uf[i], MT.GetProperty(y).GetValue(x)]).ToSortableString()  )));

            if (!lookUps.ContainsKey(key)) {
                controller.OnSaveAction += delegate (M model) {
                    lookUps[key][model.Id] = string.Join(" | ", uk.Select(y => MT.GetProperty(y).GetValue(model)));
                };
                controller.OnDeleteAction += delegate (M model) {
                    try { lookUps[key].Remove(model.Id); } catch { }
                };
            }
            lookUps[key] = lookup;
            Console.WriteLine($" + [FK] {key}");
        }

        public Dictionary<int,string> GetLookUp(string source) {
            bool found = Enum.TryParse(source,out MODELS key);
            if (found && ContainsKey(key)) {
                return lookUps[key];
            }
            return null;
        }
    }
}
