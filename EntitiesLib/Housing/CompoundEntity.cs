using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Compound)]
    public class CompoundEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
              ModelType        = typeof(CompoundModel)
            , PrimaryKeyField  = "Id" 
            , RequiredFields   = new List<string> { "Id", "CompoundName" }
            , UniqueKeyFields  = new List<string> { "CompoundName" }
            , ForeignKeys      = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["CompoundName"]      = 50,
                ["CompoundLocation"]  = 100
            }
            , Source = "HousingCompound"
            };
    }
}
