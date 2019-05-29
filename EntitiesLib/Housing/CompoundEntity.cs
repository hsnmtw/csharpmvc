using MVCHIS.Common;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    [ForModel(MODELS.Compound)]
    public class CompoundEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
            GetModelType = typeof(CompoundModel)
            , GetPrimaryKeyFields = new string[] { "Id" }
            , GetRequiredFields   = new string[] { "Id", "CompoundName" }
            , GetUniqueKeyFields  = new string[] { "CompoundName" }
            , GetSizes = new Dictionary<string, int> { ["CreatedBy"] = 50, ["UpdatedBy"] = 50,
                ["CompoundName"]      = 50,
                ["CompoundLocation"]  = 100
            }
            , GetSource = "HousingCompound"
            };
    }
}
