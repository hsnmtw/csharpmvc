using MVCHIS.Common;
using System;
using System.Collections.Generic;

namespace MVCHIS.Housing {
    //[ForModel(MODELS.Compound)]
    public class CompoundEntity : AbstractDBEntity<CompoundModel> {

        public override MetaData MetaData => new MetaData() {
            ////  ModelType        = typeof(CompoundModel)
              PrimaryKeyField  = "Id"
            , Fields           = new HashSet<string> {"ReadOnly", "Id", "CreatedBy", "CreatedOn", "UpdatedBy", "UpdatedOn",
                                                       "CompoundName", "CompoundLocation" }
            , RequiredFields   = new HashSet<string> { "Id", "CompoundName" }
            , UniqueKeyFields  = new HashSet<string> { "CompoundName" }
            , ForeignKeys      = new Dictionary<string, Tuple<string, string>> {
            }
            , Sizes = new Dictionary<string, int> {
                ["CreatedBy"       ] = 50,
                ["UpdatedBy"       ] = 50,
                ["CompoundName"    ] = 50,
                ["CompoundLocation"] = 100
            }
            , Source = "HousingCompound"
            };
    }
}
