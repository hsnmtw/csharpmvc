using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    [ForModel(MODELS.Compound)]
    public class CompoundEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            ModelType = typeof(CompoundModel)
            , PrimaryKeyFields = new string[] { "Id" }
            , RequiredFields   = new string[] { "Id", "CompoundName" }
            , UniqueKeyFields  = new string[] { "CompoundName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["CompoundName"]      = 50,
                ["CompoundLocation"]  = 100
            }
            , Source = "HousingCompound"
            };
    }
}
