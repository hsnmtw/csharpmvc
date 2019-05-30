using System.Collections.Generic;

namespace MVCHIS.Common {
    //[ForModel(MODELS.Entity)]
    public class EntityEntity : AbstractDBEntity {

        public override MetaData MetaData => new MetaData() {
              ModelType       = typeof(EntityModel)
            , PrimaryKeyField = "Id" 
            , RequiredFields  = new List<string> { "Id", "EntityName", "EntityDesc" }
            , UniqueKeyFields = new List<string> { "EntityName" }
            , ForeignKeys     = new Dictionary<string, System.Tuple<string, string>> {
            }
            , GetSizes = new Dictionary<string, int> {
                ["CreatedBy"]  = 50,
                ["UpdatedBy"]  = 50,
                ["EntityName"] = 50,
                ["EntityDesc"] = 100
            }
            , Source = "CommonEntites"
            };
    }
}
